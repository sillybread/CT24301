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
    public partial class Form3 : Form
    {
        //Chuỗi kết nối
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        //Đối tượng kết nối
        SqlConnection conn = null;
        //Đối tượng đưa dữ liệu vào Datatable dtTable
        SqlDataAdapter daTable = null;
        //Đối tượng hiển thị dữ liệu lên form
        DataTable dtTable = null;
        
        //Form Load
        void LoadData()
        {
            try
            {
                //Khởi động connection
                conn = new SqlConnection(strConnectionString);

                
                //Xử lý danh mục
                int intDM = Convert.ToInt32(this.Text);
                switch (intDM)
                {
                    case 1:
                        lblDM.Text = "Danh mục Thành phố";
                        daTable = new SqlDataAdapter("select ThanhPho, TenThanhPho from THANHPHO", conn);
                        break;
                    case 2:
                        lblDM.Text = "Danh mục Khách hàng";
                        daTable = new SqlDataAdapter("select MaKH, TenCTy from KHACHHANG", conn);
                        break;
                    case 3:
                        lblDM.Text = "Danh mục Nhân viên";
                        daTable = new SqlDataAdapter("select MaNV, Ho, Ten from NHANVIEN", conn);
                        break;
                    case 4:
                        lblDM.Text = "Danh mục Sản phẩm";
                        daTable = new SqlDataAdapter("select MaSP, TenSP, DonViTinh, DonGia from SANPHAM", conn);
                        break;
                    case 5:
                        lblDM.Text = "Danh mục Hóa đơn";
                        daTable = new SqlDataAdapter("select MaHD, MaKH, MaNV from HOADON", conn);
                        break;
                    case 6:
                        lblDM.Text = "Danh mục Chi tiết Hóa đơn";
                        daTable = new SqlDataAdapter("select * from CHITIETHOADON", conn);
                        break;
                    default:
                        break;
                }

                //Vận chuyển dữ liệu lên DataTable dtTable
                dtTable = new DataTable();
                dtTable.Clear();
                daTable.Fill(dtTable);
                //Đưa dữ liệu lên DataGridView
                dgvDANHMUC.DataSource = dtTable;
                dgvDANHMUC.AutoResizeColumns();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong. Lỗi rồi!!!");
            }
               
        }


        public Form3()
        {
            InitializeComponent();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Giải phóng tài nguyên
            dtTable.Dispose();
            dtTable = null;
            //Hủy kết nối
            conn = null;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
