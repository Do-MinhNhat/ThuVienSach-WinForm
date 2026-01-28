namespace ThuVienSach
{
    partial class QuanLy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuanLySach = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQuanLyHoaDon = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btnQuanLyMuonTraSach = new System.Windows.Forms.Button();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.btnQuanLyThanhVien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logout.png");
            this.imageList1.Images.SetKeyName(1, "doanhthu.png");
            this.imageList1.Images.SetKeyName(2, "nhanvien.png");
            this.imageList1.Images.SetKeyName(3, "khachhang.png");
            this.imageList1.Images.SetKeyName(4, "thongke.png");
            this.imageList1.Images.SetKeyName(5, "book.jpg");
            this.imageList1.Images.SetKeyName(6, "docgia.jpg");
            this.imageList1.Images.SetKeyName(7, "thanhtoan.png");
            this.imageList1.Images.SetKeyName(8, "muasach.png");
            this.imageList1.Images.SetKeyName(9, "nhacungcap.png");
            this.imageList1.Images.SetKeyName(10, "sach.jpg");
            this.imageList1.Images.SetKeyName(11, "nhanvien.png");
            this.imageList1.Images.SetKeyName(12, "library.jpg");
            this.imageList1.Images.SetKeyName(13, "muonsach.jpg");
            this.imageList1.Images.SetKeyName(14, "ms.jpg");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "GIAO DIỆN QUẢN LÝ";
            // 
            // btnQuanLySach
            // 
            this.btnQuanLySach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuanLySach.BackColor = System.Drawing.Color.White;
            this.btnQuanLySach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnQuanLySach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLySach.ImageKey = "ms.jpg";
            this.btnQuanLySach.ImageList = this.imageList1;
            this.btnQuanLySach.Location = new System.Drawing.Point(13, 73);
            this.btnQuanLySach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuanLySach.Name = "btnQuanLySach";
            this.btnQuanLySach.Size = new System.Drawing.Size(170, 135);
            this.btnQuanLySach.TabIndex = 7;
            this.btnQuanLySach.Text = "Quản lý sách";
            this.btnQuanLySach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLySach.UseVisualStyleBackColor = false;
            this.btnQuanLySach.Click += new System.EventHandler(this.btnQuanLySach_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(100)))));
            this.btnThongKe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThongKe.ImageKey = "thongke.png";
            this.btnThongKe.ImageList = this.imageList1;
            this.btnThongKe.Location = new System.Drawing.Point(729, 73);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(170, 135);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQuanLyHoaDon
            // 
            this.btnQuanLyHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuanLyHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnQuanLyHoaDon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyHoaDon.ForeColor = System.Drawing.Color.Teal;
            this.btnQuanLyHoaDon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLyHoaDon.ImageKey = "doanhthu.png";
            this.btnQuanLyHoaDon.ImageList = this.imageList1;
            this.btnQuanLyHoaDon.Location = new System.Drawing.Point(505, 73);
            this.btnQuanLyHoaDon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuanLyHoaDon.Name = "btnQuanLyHoaDon";
            this.btnQuanLyHoaDon.Size = new System.Drawing.Size(170, 135);
            this.btnQuanLyHoaDon.TabIndex = 5;
            this.btnQuanLyHoaDon.Text = "Quản Lý Hóa Đơn";
            this.btnQuanLyHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLyHoaDon.UseVisualStyleBackColor = false;
            this.btnQuanLyHoaDon.Click += new System.EventHandler(this.btnQuanLyHoaDon_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangXuat.BackColor = System.Drawing.Color.White;
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDangXuat.ImageKey = "logout.png";
            this.btnDangXuat.ImageList = this.imageList1;
            this.btnDangXuat.Location = new System.Drawing.Point(729, 238);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(170, 135);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuanLyTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoan.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnQuanLyTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLyTaiKhoan.ImageKey = "khachhang.png";
            this.btnQuanLyTaiKhoan.ImageList = this.imageList1;
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(260, 73);
            this.btnQuanLyTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(170, 135);
            this.btnQuanLyTaiKhoan.TabIndex = 0;
            this.btnQuanLyTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.btnQuanLyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnQuanLyMuonTraSach
            // 
            this.btnQuanLyMuonTraSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuanLyMuonTraSach.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnQuanLyMuonTraSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyMuonTraSach.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnQuanLyMuonTraSach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLyMuonTraSach.ImageKey = "muonsach.jpg";
            this.btnQuanLyMuonTraSach.ImageList = this.imageList1;
            this.btnQuanLyMuonTraSach.Location = new System.Drawing.Point(12, 238);
            this.btnQuanLyMuonTraSach.Name = "btnQuanLyMuonTraSach";
            this.btnQuanLyMuonTraSach.Size = new System.Drawing.Size(170, 135);
            this.btnQuanLyMuonTraSach.TabIndex = 11;
            this.btnQuanLyMuonTraSach.Text = "Quản Lý Mượn/ Trả";
            this.btnQuanLyMuonTraSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLyMuonTraSach.UseVisualStyleBackColor = false;
            this.btnQuanLyMuonTraSach.Click += new System.EventHandler(this.btnQuanLyMuonTraSach_Click);
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLapHoaDon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDon.ForeColor = System.Drawing.Color.Teal;
            this.btnLapHoaDon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLapHoaDon.ImageKey = "muasach.png";
            this.btnLapHoaDon.ImageList = this.imageList1;
            this.btnLapHoaDon.Location = new System.Drawing.Point(505, 238);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(170, 135);
            this.btnLapHoaDon.TabIndex = 10;
            this.btnLapHoaDon.Text = "Lập Hóa Đơn";
            this.btnLapHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLapHoaDon.UseVisualStyleBackColor = false;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // btnQuanLyThanhVien
            // 
            this.btnQuanLyThanhVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuanLyThanhVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLyThanhVien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyThanhVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuanLyThanhVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLyThanhVien.ImageKey = "docgia.jpg";
            this.btnQuanLyThanhVien.ImageList = this.imageList1;
            this.btnQuanLyThanhVien.Location = new System.Drawing.Point(260, 238);
            this.btnQuanLyThanhVien.Name = "btnQuanLyThanhVien";
            this.btnQuanLyThanhVien.Size = new System.Drawing.Size(170, 135);
            this.btnQuanLyThanhVien.TabIndex = 9;
            this.btnQuanLyThanhVien.Text = "Quản Lý Thành Viên";
            this.btnQuanLyThanhVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLyThanhVien.UseVisualStyleBackColor = false;
            this.btnQuanLyThanhVien.Click += new System.EventHandler(this.btnQuanLyThanhVien_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Người dùng:";
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiDung.Location = new System.Drawing.Point(202, 401);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(38, 32);
            this.lblNguoiDung.TabIndex = 13;
            this.lblNguoiDung.Text = "...";
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(912, 442);
            this.Controls.Add(this.lblNguoiDung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuanLyMuonTraSach);
            this.Controls.Add(this.btnLapHoaDon);
            this.Controls.Add(this.btnQuanLyThanhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuanLySach);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnQuanLyHoaDon);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnQuanLyTaiKhoan);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQuanLyHoaDon;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnQuanLySach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuanLyMuonTraSach;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Button btnQuanLyThanhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNguoiDung;
    }
}