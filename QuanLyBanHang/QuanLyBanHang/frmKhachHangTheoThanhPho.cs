using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace QuanLyBanHang
{
    public partial class frmKhachHangTheoThanhPho : Form
    {

        //Chuỗi kết nối
        //string strConnectionString = @"Server=.\SQLEXPRESS;Database=QuanLyBanHang;Integrated Security=True";
        //or
        string strConnectionString=@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=SSPI";

        //Đối tượng kết nối
        SqlConnection conn = null;
        //Đối tượng đưa dữ liệu vào DataTable dtKhachHang = null;
        SqlDataAdapter daKhachHang = null;
        //Đối tượng hiển thị dữ liệu lên Form
        DataTable dtKhachHang = null;

        //Thêm cho ví dụ 10.5
        //Đối tượng đưa dữ liệu vào DataTable dtThanhPho = null;
        SqlDataAdapter daThanhPho = null;
        //Đối tượng hiển thị dữ liệu lên Form
        DataTable dtThanhPho = null;

        public frmKhachHangTheoThanhPho()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadData()
        {
            try
            {
                //Khởi động kết nối
                conn = new SqlConnection(strConnectionString);

                //Vận chuyển dữ liệu lên DataTable dtThanhPho
                daThanhPho = new SqlDataAdapter("SELECT * FROM ThanhPho", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);

                //Xóa các đối tượng trong Panel
                //Đưa dữ liệu lên ComboBox
                this.cbThanhPho.DataSource = dtThanhPho;
                this.cbThanhPho.DisplayMember = "TenThanhPho";
                this.cbThanhPho.ValueMember = "ThanhPho";
    
     
                //Vận chuyển dữ liệu lên DataTable dtKhachHang
                daKhachHang = new SqlDataAdapter("SELECT * FROM Khachhang", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);
                //Đưa dữ liệu lên DataGridView
                this.dgvKhachHang.DataSource = dtKhachHang;
                //Thay đổi độ rộng cột
                dgvKhachHang.AutoResizeColumns();

                //Đếm số dòng trong datatable dtKhachHang
                //int soKH dtKhachHang.Rows.Count();
                int soKH = Convert.ToInt32(dtKhachHang.Compute("COUNT(MAKH)", string.Empty)) + 1;
                //MessageBox.Show(soKH.ToString(), "Số dòng");
                this.txtTongSoKH.Text = soKH.ToString();
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Khachhang. Lỗi rồi!!!");
            }
        }


        private void LoadDataByCity()
        {
            try
            {
                //Khởi động kết nối
                conn = new SqlConnection(strConnectionString);

                //Vận chuyển dữ liệu lên DataTable dtKhachHang
                daKhachHang = new SqlDataAdapter("SELECT * FROM Khachhang WHERE ThanhPho = '" + this.cbThanhPho.SelectedValue.ToString() + "'", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);
                //Đưa dữ liệu lên DataGridView
                this.dgvKhachHang.DataSource = dtKhachHang;
                //Thay đổi độ rộng cột
                dgvKhachHang.AutoResizeColumns();

                //Đếm số dòng trong datatable dtKhachHang
                int soKH = Convert.ToInt32(dtKhachHang.Compute("COUNT(MAKH)", string.Empty)) + 1;
                this.txtTongSoKH.Text = soKH.ToString();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Khachhang. Lỗi rồi!!!");
            }
        }

        private void frmKhachHangTheoThanhPho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmKhachHangTheoThanhPho_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Giải phóng tài nguyên
            dtKhachHang.Dispose();
            dtKhachHang = null;
            //hủy kết nối
            conn = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoadDataByCity();
        }


    }
}
