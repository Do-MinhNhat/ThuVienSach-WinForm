namespace ThuVienSach
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblXacMinhMatKhau = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.grpDangKiTK = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpDangKiTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoVaTen.ForeColor = System.Drawing.Color.Blue;
            this.txtHoVaTen.Location = new System.Drawing.Point(106, 116);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(186, 22);
            this.txtHoVaTen.TabIndex = 1;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.Blue;
            this.lblTaiKhoan.Location = new System.Drawing.Point(25, 119);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(71, 16);
            this.lblTaiKhoan.TabIndex = 2;
            this.lblTaiKhoan.Text = "Họ và tên:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.Blue;
            this.lblMatKhau.Location = new System.Drawing.Point(25, 203);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(55, 16);
            this.lblMatKhau.TabIndex = 3;
            this.lblMatKhau.Text = "Địa chỉ:";
            // 
            // lblXacMinhMatKhau
            // 
            this.lblXacMinhMatKhau.AutoSize = true;
            this.lblXacMinhMatKhau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXacMinhMatKhau.ForeColor = System.Drawing.Color.Blue;
            this.lblXacMinhMatKhau.Location = new System.Drawing.Point(25, 175);
            this.lblXacMinhMatKhau.Name = "lblXacMinhMatKhau";
            this.lblXacMinhMatKhau.Size = new System.Drawing.Size(36, 16);
            this.lblXacMinhMatKhau.TabIndex = 4;
            this.lblXacMinhMatKhau.Text = "SDT:";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.Blue;
            this.txtSDT.Location = new System.Drawing.Point(106, 172);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(186, 22);
            this.txtSDT.TabIndex = 6;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.White;
            this.btnDangKy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.Blue;
            this.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDangKy.ImageKey = "dangky.jpg";
            this.btnDangKy.ImageList = this.imageList1;
            this.btnDangKy.Location = new System.Drawing.Point(28, 270);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(88, 77);
            this.btnDangKy.TabIndex = 7;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dangky.jpg");
            this.imageList1.Images.SetKeyName(1, "logout.png");
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Blue;
            this.txtDiaChi.Location = new System.Drawing.Point(106, 200);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(186, 22);
            this.txtDiaChi.TabIndex = 9;
            // 
            // grpDangKiTK
            // 
            this.grpDangKiTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpDangKiTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpDangKiTK.Controls.Add(this.label1);
            this.grpDangKiTK.Controls.Add(this.txtXacNhan);
            this.grpDangKiTK.Controls.Add(this.dtpNgaySinh);
            this.grpDangKiTK.Controls.Add(this.lblNgaySinh);
            this.grpDangKiTK.Controls.Add(this.rdNu);
            this.grpDangKiTK.Controls.Add(this.rdNam);
            this.grpDangKiTK.Controls.Add(this.btnQuayLai);
            this.grpDangKiTK.Controls.Add(this.label3);
            this.grpDangKiTK.Controls.Add(this.label4);
            this.grpDangKiTK.Controls.Add(this.lblTaiKhoan);
            this.grpDangKiTK.Controls.Add(this.btnDangKy);
            this.grpDangKiTK.Controls.Add(this.txtDiaChi);
            this.grpDangKiTK.Controls.Add(this.label2);
            this.grpDangKiTK.Controls.Add(this.txtUsername);
            this.grpDangKiTK.Controls.Add(this.txtHoVaTen);
            this.grpDangKiTK.Controls.Add(this.lblXacMinhMatKhau);
            this.grpDangKiTK.Controls.Add(this.txtSDT);
            this.grpDangKiTK.Controls.Add(this.txtPassword);
            this.grpDangKiTK.Controls.Add(this.lblMatKhau);
            this.grpDangKiTK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDangKiTK.ForeColor = System.Drawing.Color.Teal;
            this.grpDangKiTK.Location = new System.Drawing.Point(55, 77);
            this.grpDangKiTK.Name = "grpDangKiTK";
            this.grpDangKiTK.Size = new System.Drawing.Size(311, 353);
            this.grpDangKiTK.TabIndex = 0;
            this.grpDangKiTK.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(29, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Xác nhận:";
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhan.ForeColor = System.Drawing.Color.Blue;
            this.txtXacNhan.Location = new System.Drawing.Point(106, 88);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.Size = new System.Drawing.Size(186, 22);
            this.txtXacNhan.TabIndex = 22;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(106, 228);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(186, 22);
            this.dtpNgaySinh.TabIndex = 21;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Blue;
            this.lblNgaySinh.Location = new System.Drawing.Point(26, 228);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(76, 16);
            this.lblNgaySinh.TabIndex = 20;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.ForeColor = System.Drawing.Color.Blue;
            this.rdNu.Location = new System.Drawing.Point(182, 147);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(43, 20);
            this.rdNu.TabIndex = 14;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.ForeColor = System.Drawing.Color.Blue;
            this.rdNam.Location = new System.Drawing.Point(106, 147);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(54, 20);
            this.rdNam.TabIndex = 13;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.White;
            this.btnQuayLai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.Blue;
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuayLai.ImageKey = "logout.png";
            this.btnQuayLai.ImageList = this.imageList1;
            this.btnQuayLai.Location = new System.Drawing.Point(204, 270);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(88, 77);
            this.btnQuayLai.TabIndex = 10;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(25, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(26, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Blue;
            this.txtUsername.Location = new System.Drawing.Point(106, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(186, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Blue;
            this.txtPassword.Location = new System.Drawing.Point(106, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(-2, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(433, 46);
            this.label5.TabIndex = 2;
            this.label5.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(420, 442);
            this.Controls.Add(this.grpDangKiTK);
            this.Controls.Add(this.label5);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKy";
            this.grpDangKiTK.ResumeLayout(false);
            this.grpDangKiTK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblXacMinhMatKhau;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.GroupBox grpDangKiTK;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXacNhan;
    }
}