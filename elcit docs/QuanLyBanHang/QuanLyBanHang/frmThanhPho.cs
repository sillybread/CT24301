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
    public partial class frmThanhPho : Form
    {

        //Chuỗi kết nối
        //string strConnectionString = @"Server=.\SQLEXPRESS;Database=QuanLyBanHang;Integrated Security=True";
        //or
        string strConnectionString=@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=SSPI";

        //Đối tượng kết nối
        SqlConnection conn = null;
        //Đối tượng đưa dữ liệu vào DataTable dtThanhPho = null;
        SqlDataAdapter daThanhPho = null;
        //Đối tượng hiển thị dữ liệu lên Form
        DataTable dtThanhPho = null;

        //Khai báo thêm biến kiểm tra việc Thêm hay sửa dữ liệu
        bool Them;

        public frmThanhPho()
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
 
                //Vận chuyển dữ liệu lên DataTable dtKhachHang
                daThanhPho = new SqlDataAdapter("SELECT * FROM THANHPHO", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);
                //Đưa dữ liệu lên DataGridView
                this.dgvTHANHPHO.DataSource = dtThanhPho;
                //Thay đổi độ rộng cột
                dgvTHANHPHO.AutoResizeColumns();
                //Xóa trống các đối tượng trong Panel
                this.txThanhPho.ResetText();
                this.txtTenThanhPho.ResetText();
                //Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.pnlThongTinTP.Enabled = false;
                //Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnThoat.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Khachhang. Lỗi rồi!!!");
            }
        }
        private void frmThanhPho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmThanhPho_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Giải phóng tài nguyên
            dtThanhPho.Dispose();
            dtThanhPho = null;
            //hủy kết nối
            conn = null;
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Mở kết nối
            conn.Open();
            try
            {
                //Thực hiện lệnh
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                //Lấy thứ tự record hiện hành
                int r = dgvTHANHPHO.CurrentCell.RowIndex;
                //Lấy MaTP của record hiện hành
                string strTHANHPHO = dgvTHANHPHO.Rows[r].Cells[0].Value.ToString();
                //Viết câu lệnh SQL
                cmd.CommandText = System.String.Concat("Delete from ThanhPho where ThanhPho ='" + strTHANHPHO + "'");
                //cmd.CommandType = CommandType.Text;
                //Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();
                //Cập nhật lại DataGridView
                LoadData();
                //Thông báo
                MessageBox.Show("Đã xóa xong!");

            }
            catch(SqlException){
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
            //Đóng kết nối
            conn.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Xóa trống các đối tượng trong panel
            this.txThanhPho.ResetText();
            this.txtTenThanhPho.ResetText();
            //Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
            //Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.pnlThongTinTP.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kích hoạt biến Them
            Them = true;
            //Xóa trống các đối tượng trong Panel
            this.txThanhPho.ResetText();
            this.txtTenThanhPho.ResetText();
            //Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnlThongTinTP.Enabled = true;
            //Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            //Đưa con trỏ đến TextField txtMaKH
            this.txThanhPho.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kích hoạt biến Sửa
            Them = false;
            //Cho phép thao tác trên Panel
            this.pnlThongTinTP.Enabled = true;
            //Thứ tự dòng hiện hành
            int r = dgvTHANHPHO.CurrentCell.RowIndex;
            //Chuyển thông tin lên panel
            this.txThanhPho.Text = dgvTHANHPHO.Rows[r].Cells[0].Value.ToString();
            this.txtTenThanhPho.Text = dgvTHANHPHO.Rows[r].Cells[1].Value.ToString();
            //Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.pnlThongTinTP.Enabled = true;
            //Không cho thao tác trên các nút thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;
            //Đưa con trỏ đến TextField txtThanhPho
            this.txThanhPho.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Mở kết nối
            conn.Open();
            if(Them)
            {
                try
                {
                    //Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    //Lệnh Insert InTo
                    cmd.CommandText = System.String.Concat("Insert into ThanhPho values(" + "'" + 
                        this.txThanhPho.Text.ToString() + "',N'" + this.txtTenThanhPho.Text.ToString() + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    //Load lại dữ liệu trên DataGridView
                    LoadData();
                    //Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }//if

            //for updating data
            if(!Them)
            {
                try
                {
                    //Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    //Thứ tự dòng hiện hành
                    int r = dgvTHANHPHO.CurrentCell.RowIndex;
                    //MaTP hiện hành
                    string strTHANHPHO = dgvTHANHPHO.Rows[r].Cells[0].Value.ToString();
                    //Câu lệnh SQL
                    cmd.CommandText = System.String.Concat("Update ThanhPho Set TenThanhPho = N'"+
                        this.txtTenThanhPho.Text.ToString() + "' where ThanhPho ='" + strTHANHPHO + "'");
                    //Cập nhật
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    //Load lại dữ liệu lên trên DataGridView
                    LoadData();
                    //Thông báo
                    MessageBox.Show("Đã sửa xong!");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!");
                }
            }
            //Đóng kết nối
            conn.Close();
        }
    }
}
