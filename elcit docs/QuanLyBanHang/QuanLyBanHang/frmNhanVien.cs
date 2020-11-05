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
    public partial class frmNhanVien : Form
    {
        //Chuỗi kết nối
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        //Đối tượng kết nối
        SqlConnection conn = null;
        //Đối tượng đưa dữ liệu vào Datatable dtNhanVien
        SqlDataAdapter daNhanVien = null;
        //Đối tượng hiển thị dữ liệu lên form
        DataTable dtNhanVien = null;
        
        //Form Load
        void LoadData()
        {
            try
            {
                //Khởi động connection
                conn = new SqlConnection(strConnectionString);
                //Vận chuyển dữ liệu lên DataTable dtNhanVien
                daNhanVien = new SqlDataAdapter("select * from NHANVIEN", conn);
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                daNhanVien.Fill(dtNhanVien);
                //Đưa dữ liệu lên DataGridView
                dgvNHANVIEN.DataSource = dtNhanVien;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NHANVIEN. Lỗi rồi!!!");
            }
               
        }


        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Thật không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Giải phóng tài nguyên
            dtNhanVien.Dispose();
            dtNhanVien = null;
            //Hủy kết nối
            conn = null;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
