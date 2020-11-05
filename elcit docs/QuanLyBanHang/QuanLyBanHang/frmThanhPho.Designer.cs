namespace QuanLyBanHang
{
    partial class frmThanhPho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvTHANHPHO = new System.Windows.Forms.DataGridView();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTenThanhPho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlThongTinTP = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txThanhPho = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHANHPHO)).BeginInit();
            this.pnlThongTinTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(255, 315);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 52);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Trở Về";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvTHANHPHO
            // 
            this.dgvTHANHPHO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTHANHPHO.Location = new System.Drawing.Point(12, 97);
            this.dgvTHANHPHO.Name = "dgvTHANHPHO";
            this.dgvTHANHPHO.Size = new System.Drawing.Size(318, 203);
            this.dgvTHANHPHO.TabIndex = 1;
            // 
            // btnReLoad
            // 
            this.btnReLoad.Location = new System.Drawing.Point(12, 315);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(75, 23);
            this.btnReLoad.TabIndex = 2;
            this.btnReLoad.Text = "ReLoad";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(174, 344);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTenThanhPho
            // 
            this.txtTenThanhPho.Location = new System.Drawing.Point(99, 34);
            this.txtTenThanhPho.Name = "txtTenThanhPho";
            this.txtTenThanhPho.Size = new System.Drawing.Size(207, 20);
            this.txtTenThanhPho.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Thành Phố:";
            // 
            // pnlThongTinTP
            // 
            this.pnlThongTinTP.Controls.Add(this.label1);
            this.pnlThongTinTP.Controls.Add(this.label2);
            this.pnlThongTinTP.Controls.Add(this.txThanhPho);
            this.pnlThongTinTP.Controls.Add(this.txtTenThanhPho);
            this.pnlThongTinTP.Location = new System.Drawing.Point(12, 12);
            this.pnlThongTinTP.Name = "pnlThongTinTP";
            this.pnlThongTinTP.Size = new System.Drawing.Size(318, 64);
            this.pnlThongTinTP.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thành Phố:";
            // 
            // txThanhPho
            // 
            this.txThanhPho.Location = new System.Drawing.Point(99, 8);
            this.txThanhPho.Name = "txThanhPho";
            this.txThanhPho.Size = new System.Drawing.Size(100, 20);
            this.txThanhPho.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(93, 315);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(174, 315);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(12, 344);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(93, 344);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThanhPho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 375);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pnlThongTinTP);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.dgvTHANHPHO);
            this.Controls.Add(this.btnThoat);
            this.Name = "frmThanhPho";
            this.Text = "Quản lý Danh mục Thành phố";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThanhPho_FormClosing);
            this.Load += new System.EventHandler(this.frmThanhPho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHANHPHO)).EndInit();
            this.pnlThongTinTP.ResumeLayout(false);
            this.pnlThongTinTP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvTHANHPHO;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTenThanhPho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlThongTinTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txThanhPho;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}