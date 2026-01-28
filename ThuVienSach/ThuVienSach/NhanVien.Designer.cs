namespace ThuVienSach
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuanLyMuonTraSach = new System.Windows.Forms.Button();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.btnQuanLyThanhVien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "muasach.png");
            this.imageList1.Images.SetKeyName(1, "muonsach.jpg");
            this.imageList1.Images.SetKeyName(2, "logout.png");
            this.imageList1.Images.SetKeyName(3, "docgia.jpg");
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
            this.btnDangXuat.Location = new System.Drawing.Point(254, 241);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(170, 135);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
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
            this.btnQuanLyMuonTraSach.Location = new System.Drawing.Point(495, 79);
            this.btnQuanLyMuonTraSach.Name = "btnQuanLyMuonTraSach";
            this.btnQuanLyMuonTraSach.Size = new System.Drawing.Size(170, 135);
            this.btnQuanLyMuonTraSach.TabIndex = 2;
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
            this.btnLapHoaDon.Location = new System.Drawing.Point(254, 79);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(170, 135);
            this.btnLapHoaDon.TabIndex = 1;
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
            this.btnQuanLyThanhVien.Location = new System.Drawing.Point(12, 79);
            this.btnQuanLyThanhVien.Name = "btnQuanLyThanhVien";
            this.btnQuanLyThanhVien.Size = new System.Drawing.Size(170, 135);
            this.btnQuanLyThanhVien.TabIndex = 0;
            this.btnQuanLyThanhVien.Text = "Quản Lý Thành Viên";
            this.btnQuanLyThanhVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLyThanhVien.UseVisualStyleBackColor = false;
            this.btnQuanLyThanhVien.Click += new System.EventHandler(this.btnQuanLyThanhVien_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "GIAO DIỆN NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(6, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Người dùng:";
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiDung.ForeColor = System.Drawing.Color.Blue;
            this.lblNguoiDung.Location = new System.Drawing.Point(196, 406);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(38, 32);
            this.lblNguoiDung.TabIndex = 11;
            this.lblNguoiDung.Text = "...";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(680, 447);
            this.Controls.Add(this.lblNguoiDung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnQuanLyMuonTraSach);
            this.Controls.Add(this.btnLapHoaDon);
            this.Controls.Add(this.btnQuanLyThanhVien);
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLyThanhVien;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Button btnQuanLyMuonTraSach;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNguoiDung;
    }
}