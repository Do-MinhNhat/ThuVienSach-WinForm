namespace ThuVienSach
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.grpTTTV = new System.Windows.Forms.GroupBox();
            this.radThongKeNhapSach = new System.Windows.Forms.RadioButton();
            this.radThongKeMuonSach = new System.Windows.Forms.RadioButton();
            this.radThongKeSach = new System.Windows.Forms.RadioButton();
            this.radHoaDonBan = new System.Windows.Forms.RadioButton();
            this.radThongKeNhanVien = new System.Windows.Forms.RadioButton();
            this.radThongKeKhachHang = new System.Windows.Forms.RadioButton();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.grpTTTV.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "quaylai.jpg");
            this.imageList1.Images.SetKeyName(1, "thongke.png");
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.White;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.Teal;
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuayLai.ImageKey = "quaylai.jpg";
            this.btnQuayLai.ImageList = this.imageList1;
            this.btnQuayLai.Location = new System.Drawing.Point(23, 173);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(94, 71);
            this.btnQuayLai.TabIndex = 5;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.White;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Teal;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThongKe.ImageKey = "thongke.png";
            this.btnThongKe.ImageList = this.imageList1;
            this.btnThongKe.Location = new System.Drawing.Point(23, 48);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(94, 71);
            this.btnThongKe.TabIndex = 10;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // grpTTTV
            // 
            this.grpTTTV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTTTV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpTTTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpTTTV.Controls.Add(this.radThongKeNhapSach);
            this.grpTTTV.Controls.Add(this.radThongKeMuonSach);
            this.grpTTTV.Controls.Add(this.radThongKeSach);
            this.grpTTTV.Controls.Add(this.radHoaDonBan);
            this.grpTTTV.Controls.Add(this.radThongKeNhanVien);
            this.grpTTTV.Controls.Add(this.radThongKeKhachHang);
            this.grpTTTV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTTV.ForeColor = System.Drawing.Color.Blue;
            this.grpTTTV.Location = new System.Drawing.Point(19, 19);
            this.grpTTTV.Margin = new System.Windows.Forms.Padding(2);
            this.grpTTTV.Name = "grpTTTV";
            this.grpTTTV.Padding = new System.Windows.Forms.Padding(2);
            this.grpTTTV.Size = new System.Drawing.Size(318, 263);
            this.grpTTTV.TabIndex = 14;
            this.grpTTTV.TabStop = false;
            this.grpTTTV.Text = "Thông tin";
            // 
            // radThongKeNhapSach
            // 
            this.radThongKeNhapSach.AutoSize = true;
            this.radThongKeNhapSach.Location = new System.Drawing.Point(41, 186);
            this.radThongKeNhapSach.Margin = new System.Windows.Forms.Padding(2);
            this.radThongKeNhapSach.Name = "radThongKeNhapSach";
            this.radThongKeNhapSach.Size = new System.Drawing.Size(153, 20);
            this.radThongKeNhapSach.TabIndex = 5;
            this.radThongKeNhapSach.TabStop = true;
            this.radThongKeNhapSach.Text = "Thống kê nhập sách";
            this.radThongKeNhapSach.UseVisualStyleBackColor = true;
            // 
            // radThongKeMuonSach
            // 
            this.radThongKeMuonSach.AutoSize = true;
            this.radThongKeMuonSach.Location = new System.Drawing.Point(41, 149);
            this.radThongKeMuonSach.Margin = new System.Windows.Forms.Padding(2);
            this.radThongKeMuonSach.Name = "radThongKeMuonSach";
            this.radThongKeMuonSach.Size = new System.Drawing.Size(159, 20);
            this.radThongKeMuonSach.TabIndex = 4;
            this.radThongKeMuonSach.TabStop = true;
            this.radThongKeMuonSach.Text = "Thống kê mượn sách";
            this.radThongKeMuonSach.UseVisualStyleBackColor = true;
            // 
            // radThongKeSach
            // 
            this.radThongKeSach.AutoSize = true;
            this.radThongKeSach.Location = new System.Drawing.Point(41, 222);
            this.radThongKeSach.Margin = new System.Windows.Forms.Padding(2);
            this.radThongKeSach.Name = "radThongKeSach";
            this.radThongKeSach.Size = new System.Drawing.Size(117, 20);
            this.radThongKeSach.TabIndex = 3;
            this.radThongKeSach.TabStop = true;
            this.radThongKeSach.Text = "Thống kê sách";
            this.radThongKeSach.UseVisualStyleBackColor = true;
            // 
            // radHoaDonBan
            // 
            this.radHoaDonBan.AutoSize = true;
            this.radHoaDonBan.Location = new System.Drawing.Point(41, 113);
            this.radHoaDonBan.Margin = new System.Windows.Forms.Padding(2);
            this.radHoaDonBan.Name = "radHoaDonBan";
            this.radHoaDonBan.Size = new System.Drawing.Size(149, 20);
            this.radHoaDonBan.TabIndex = 2;
            this.radHoaDonBan.TabStop = true;
            this.radHoaDonBan.Text = "Thống kê mua sách";
            this.radHoaDonBan.UseVisualStyleBackColor = true;
            // 
            // radThongKeNhanVien
            // 
            this.radThongKeNhanVien.AutoSize = true;
            this.radThongKeNhanVien.Location = new System.Drawing.Point(41, 77);
            this.radThongKeNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.radThongKeNhanVien.Name = "radThongKeNhanVien";
            this.radThongKeNhanVien.Size = new System.Drawing.Size(151, 20);
            this.radThongKeNhanVien.TabIndex = 1;
            this.radThongKeNhanVien.TabStop = true;
            this.radThongKeNhanVien.Text = "Thống kê nhân viên";
            this.radThongKeNhanVien.UseVisualStyleBackColor = true;
            // 
            // radThongKeKhachHang
            // 
            this.radThongKeKhachHang.AutoSize = true;
            this.radThongKeKhachHang.Location = new System.Drawing.Point(41, 38);
            this.radThongKeKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.radThongKeKhachHang.Name = "radThongKeKhachHang";
            this.radThongKeKhachHang.Size = new System.Drawing.Size(162, 20);
            this.radThongKeKhachHang.TabIndex = 0;
            this.radThongKeKhachHang.TabStop = true;
            this.radThongKeKhachHang.Text = "Thống kê khách hàng";
            this.radThongKeKhachHang.UseVisualStyleBackColor = true;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpChucNang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpChucNang.Controls.Add(this.btnQuayLai);
            this.grpChucNang.Controls.Add(this.btnThongKe);
            this.grpChucNang.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChucNang.ForeColor = System.Drawing.Color.Teal;
            this.grpChucNang.Location = new System.Drawing.Point(352, 19);
            this.grpChucNang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpChucNang.Size = new System.Drawing.Size(144, 263);
            this.grpChucNang.TabIndex = 15;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức Năng";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(521, 295);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpTTTV);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.grpTTTV.ResumeLayout(false);
            this.grpTTTV.PerformLayout();
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox grpTTTV;
        private System.Windows.Forms.RadioButton radThongKeMuonSach;
        private System.Windows.Forms.RadioButton radThongKeSach;
        private System.Windows.Forms.RadioButton radHoaDonBan;
        private System.Windows.Forms.RadioButton radThongKeNhanVien;
        private System.Windows.Forms.RadioButton radThongKeKhachHang;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.RadioButton radThongKeNhapSach;
    }
}