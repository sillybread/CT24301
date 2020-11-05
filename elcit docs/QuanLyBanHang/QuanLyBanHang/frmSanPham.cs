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
//using System.Data;

namespace QuanLyBanHang
{
    public partial class frmSanPham : Form
    {
    
        //Chuỗi kết nối
        string strConnectionString=@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=SSPI";
  
        //Đối tượng kết nối
        SqlConnection conn = null;
        //Đối tượng đưa dữ liệu vào DataTable dtSanPham = null;
        SqlDataAdapter daSanPham = null;
        //Đối tượng hiển thị dữ liệu lên Form
        DataTable dtSanPham = null;
        
       public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtSanPham.Dispose();
            dtSanPham = null;
            //hủy kết nối
            conn = null;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            try{
                 //Khởi động kết nối
                conn = new SqlConnection(strConnectionString);
                // mở kết nối
                //Vận chuyển dữ liệu lên DataTable dtSanPham
                daSanPham = new SqlDataAdapter("SELECT * FROM SanPham", conn);
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                daSanPham.Fill(dtSanPham);
                //Đưa dữ liệu lên ComboBox
                this.cbSanPham.DataSource = dtSanPham;
                this.cbSanPham.DisplayMember = "TenSP";
                this.cbSanPham.ValueMember = "MaSP";

            }
            catch(SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table SanPham, Lỗi rồi!!!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Khai báo biến traloi
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(traloi == DialogResult.OK) 
                Application.Exit();
        }
    }
}
