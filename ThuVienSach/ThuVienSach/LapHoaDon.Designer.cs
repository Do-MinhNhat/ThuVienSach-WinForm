namespace ThuVienSach
{
    partial class LapHoaDon
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
            System.Windows.Forms.ColumnHeader MaSach;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapHoaDon));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.grpTTTV = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSL = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.rdMuon = new System.Windows.Forms.RadioButton();
            this.rdMua = new System.Windows.Forms.RadioButton();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDChi = new System.Windows.Forms.Label();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvSach = new System.Windows.Forms.ListView();
            this.TenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HinhAnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            MaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpChucNang.SuspendLayout();
            this.grpTTTV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // MaSach
            // 
            MaSach.Text = "Mã sách";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "quaylai.jpg");
            this.imageList1.Images.SetKeyName(1, "doanhthu.png");
            this.imageList1.Images.SetKeyName(2, "lammoi.jpg");
            this.imageList1.Images.SetKeyName(3, "them.jpg");
            this.imageList1.Images.SetKeyName(4, "timkiem.jpg");
            this.imageList1.Images.SetKeyName(5, "dangky.jpg");
            this.imageList1.Images.SetKeyName(6, "xoa.png");
            this.imageList1.Images.SetKeyName(7, "sua.png");
            this.imageList1.Images.SetKeyName(8, "thongke.png");
            this.imageList1.Images.SetKeyName(9, "thanhtoan.png");
            // 
            // grpChucNang
            // 
            this.grpChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChucNang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpChucNang.Controls.Add(this.btnInHD);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnLamMoi);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnLuuHD);
            this.grpChucNang.Controls.Add(this.btnQuayLai);
            this.grpChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChucNang.ForeColor = System.Drawing.Color.Teal;
            this.grpChucNang.Location = new System.Drawing.Point(748, 12);
            this.grpChucNang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpChucNang.Size = new System.Drawing.Size(245, 301);
            this.grpChucNang.TabIndex = 11;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức Năng";
            // 
            // btnInHD
            // 
            this.btnInHD.BackColor = System.Drawing.Color.White;
            this.btnInHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.ForeColor = System.Drawing.Color.Teal;
            this.btnInHD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInHD.ImageKey = "thanhtoan.png";
            this.btnInHD.ImageList = this.imageList1;
            this.btnInHD.Location = new System.Drawing.Point(131, 32);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(94, 66);
            this.btnInHD.TabIndex = 8;
            this.btnInHD.Text = "In Hóa Đơn";
            this.btnInHD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInHD.UseVisualStyleBackColor = false;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Teal;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.ImageKey = "xoa.png";
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(7, 124);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 66);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Teal;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLamMoi.ImageKey = "lammoi.jpg";
            this.btnLamMoi.ImageList = this.imageList1;
            this.btnLamMoi.Location = new System.Drawing.Point(131, 123);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 66);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Teal;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.ImageKey = "them.jpg";
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(7, 32);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 66);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.BackColor = System.Drawing.Color.White;
            this.btnLuuHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHD.ForeColor = System.Drawing.Color.Teal;
            this.btnLuuHD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuuHD.ImageIndex = 1;
            this.btnLuuHD.ImageList = this.imageList1;
            this.btnLuuHD.Location = new System.Drawing.Point(131, 218);
            this.btnLuuHD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(94, 66);
            this.btnLuuHD.TabIndex = 4;
            this.btnLuuHD.Text = "Lưu";
            this.btnLuuHD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuuHD.UseVisualStyleBackColor = false;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.White;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.Teal;
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuayLai.ImageKey = "quaylai.jpg";
            this.btnQuayLai.ImageList = this.imageList1;
            this.btnQuayLai.Location = new System.Drawing.Point(7, 219);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(94, 66);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // grpTTTV
            // 
            this.grpTTTV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTTTV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpTTTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpTTTV.Controls.Add(this.label5);
            this.grpTTTV.Controls.Add(this.txtDonGia);
            this.grpTTTV.Controls.Add(this.dtpHanTra);
            this.grpTTTV.Controls.Add(this.dtpNgayMuon);
            this.grpTTTV.Controls.Add(this.label2);
            this.grpTTTV.Controls.Add(this.txtThanhTien);
            this.grpTTTV.Controls.Add(this.label4);
            this.grpTTTV.Controls.Add(this.nudSL);
            this.grpTTTV.Controls.Add(this.label3);
            this.grpTTTV.Controls.Add(this.txtMaSach);
            this.grpTTTV.Controls.Add(this.label1);
            this.grpTTTV.Controls.Add(this.dtpNgayLapHD);
            this.grpTTTV.Controls.Add(this.rdMuon);
            this.grpTTTV.Controls.Add(this.rdMua);
            this.grpTTTV.Controls.Add(this.txtMaNV);
            this.grpTTTV.Controls.Add(this.txtMaKH);
            this.grpTTTV.Controls.Add(this.lblGioiTinh);
            this.grpTTTV.Controls.Add(this.lblNgaySinh);
            this.grpTTTV.Controls.Add(this.lblSDT);
            this.grpTTTV.Controls.Add(this.lblDChi);
            this.grpTTTV.Controls.Add(this.lblHoVaTen);
            this.grpTTTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTTV.ForeColor = System.Drawing.Color.Blue;
            this.grpTTTV.Location = new System.Drawing.Point(319, 12);
            this.grpTTTV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpTTTV.Name = "grpTTTV";
            this.grpTTTV.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpTTTV.Size = new System.Drawing.Size(406, 301);
            this.grpTTTV.TabIndex = 10;
            this.grpTTTV.TabStop = false;
            this.grpTTTV.Text = "Thông tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(54, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(131, 117);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(216, 26);
            this.txtDonGia.TabIndex = 32;
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTra.Location = new System.Drawing.Point(130, 238);
            this.dtpHanTra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(216, 22);
            this.dtpHanTra.TabIndex = 31;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(130, 206);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(216, 22);
            this.dtpNgayMuon.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(263, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "SL:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(130, 265);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(216, 26);
            this.txtThanhTien.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(42, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Thành tiền:";
            // 
            // nudSL
            // 
            this.nudSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSL.Location = new System.Drawing.Point(300, 85);
            this.nudSL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudSL.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSL.Name = "nudSL";
            this.nudSL.Size = new System.Drawing.Size(47, 26);
            this.nudSL.TabIndex = 26;
            this.nudSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(64, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Hạn trả:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(131, 85);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(124, 26);
            this.txtMaSach.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(54, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã sách:";
            // 
            // dtpNgayLapHD
            // 
            this.dtpNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLapHD.Location = new System.Drawing.Point(130, 174);
            this.dtpNgayLapHD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpNgayLapHD.Name = "dtpNgayLapHD";
            this.dtpNgayLapHD.Size = new System.Drawing.Size(216, 22);
            this.dtpNgayLapHD.TabIndex = 19;
            // 
            // rdMuon
            // 
            this.rdMuon.AutoSize = true;
            this.rdMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMuon.ForeColor = System.Drawing.Color.Blue;
            this.rdMuon.Location = new System.Drawing.Point(226, 149);
            this.rdMuon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdMuon.Name = "rdMuon";
            this.rdMuon.Size = new System.Drawing.Size(62, 20);
            this.rdMuon.TabIndex = 15;
            this.rdMuon.Text = "Mượn";
            this.rdMuon.UseVisualStyleBackColor = true;
            // 
            // rdMua
            // 
            this.rdMua.AutoSize = true;
            this.rdMua.Checked = true;
            this.rdMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMua.ForeColor = System.Drawing.Color.Blue;
            this.rdMua.Location = new System.Drawing.Point(131, 149);
            this.rdMua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdMua.Name = "rdMua";
            this.rdMua.Size = new System.Drawing.Size(54, 20);
            this.rdMua.TabIndex = 14;
            this.rdMua.TabStop = true;
            this.rdMua.Text = "Mua";
            this.rdMua.UseVisualStyleBackColor = true;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(131, 53);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(216, 26);
            this.txtMaNV.TabIndex = 13;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(131, 19);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(216, 26);
            this.txtMaKH.TabIndex = 11;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Blue;
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 151);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(105, 16);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Loại Hóa Đơn:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Blue;
            this.lblNgaySinh.Location = new System.Drawing.Point(47, 179);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(78, 16);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "Ngày Lập:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.Blue;
            this.lblSDT.Location = new System.Drawing.Point(36, 211);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(89, 16);
            this.lblSDT.TabIndex = 3;
            this.lblSDT.Text = "Ngày mượn:";
            // 
            // lblDChi
            // 
            this.lblDChi.AutoSize = true;
            this.lblDChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDChi.ForeColor = System.Drawing.Color.Blue;
            this.lblDChi.Location = new System.Drawing.Point(66, 58);
            this.lblDChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDChi.Name = "lblDChi";
            this.lblDChi.Size = new System.Drawing.Size(57, 16);
            this.lblDChi.TabIndex = 2;
            this.lblDChi.Text = "Mã NV:";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoVaTen.ForeColor = System.Drawing.Color.Blue;
            this.lblHoVaTen.Location = new System.Drawing.Point(67, 24);
            this.lblHoVaTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(56, 16);
            this.lblHoVaTen.TabIndex = 1;
            this.lblHoVaTen.Text = "Mã KH:";
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToAddRows = false;
            this.dgvChiTietHoaDon.AllowUserToDeleteRows = false;
            this.dgvChiTietHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colDonGia,
            this.colSoLuong,
            this.colThanhTien});
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(319, 320);
            this.dgvChiTietHoaDon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvChiTietHoaDon.MultiSelect = false;
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.ReadOnly = true;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(674, 243);
            this.dgvChiTietHoaDon.TabIndex = 9;
            this.dgvChiTietHoaDon.SelectionChanged += new System.EventHandler(this.dgvChiTietHoaDon_SelectionChanged);
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.FillWeight = 103.1871F;
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "TenSach";
            this.colTenSach.HeaderText = "Tên sách";
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // lvSach
            // 
            this.lvSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenSach,
            this.HinhAnh,
            MaSach,
            this.DonGia,
            this.SoLuong});
            this.lvSach.FullRowSelect = true;
            this.lvSach.HideSelection = false;
            this.lvSach.LargeImageList = this.imageList2;
            this.lvSach.Location = new System.Drawing.Point(13, 44);
            this.lvSach.Name = "lvSach";
            this.lvSach.Size = new System.Drawing.Size(298, 519);
            this.lvSach.TabIndex = 12;
            this.lvSach.UseCompatibleStateImageBehavior = false;
            this.lvSach.SelectedIndexChanged += new System.EventHandler(this.lvSach_SelectedIndexChanged);
            this.lvSach.DoubleClick += new System.EventHandler(this.lvSach_DoubleClick);
            // 
            // TenSach
            // 
            this.TenSach.Text = "Tên sách";
            // 
            // HinhAnh
            // 
            this.HinhAnh.Text = "Hình sách";
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(60, 100);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(13, 12);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(242, 26);
            this.txtTenSach.TabIndex = 32;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Teal;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimKiem.ImageKey = "(none)";
            this.btnTimKiem.ImageList = this.imageList1;
            this.btnTimKiem.Location = new System.Drawing.Point(263, 12);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(45, 26);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // LapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1006, 575);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.lvSach);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grpTTTV);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LapHoaDon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LapHoaDon_FormClosed);
            this.Load += new System.EventHandler(this.LapHoaDon_Load);
            this.grpChucNang.ResumeLayout(false);
            this.grpTTTV.ResumeLayout(false);
            this.grpTTTV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.GroupBox grpTTTV;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHD;
        private System.Windows.Forms.RadioButton rdMuon;
        private System.Windows.Forms.RadioButton rdMua;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDChi;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.NumericUpDown nudSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.ColumnHeader TenSach;
        private System.Windows.Forms.ColumnHeader HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ListView lvSach;
    }
}