namespace ThuVienSach
{
    partial class QuanLyMuonTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyMuonTraSach));
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnXemCT = new System.Windows.Forms.Button();
            this.grpThongTinSach = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdChuaTra = new System.Windows.Forms.RadioButton();
            this.rdDaTra = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhiTraMuon = new System.Windows.Forms.TextBox();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblPhiMuon = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblHanTra = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.dgvMuonTraSach = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhiTraMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpChucNang.SuspendLayout();
            this.grpThongTinSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTraSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.White;
            this.btnQuayLai.ForeColor = System.Drawing.Color.Teal;
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuayLai.ImageKey = "quaylai.jpg";
            this.btnQuayLai.ImageList = this.imageList1;
            this.btnQuayLai.Location = new System.Drawing.Point(9, 110);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(81, 66);
            this.btnQuayLai.TabIndex = 0;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lammoi.jpg");
            this.imageList1.Images.SetKeyName(1, "quaylai.jpg");
            this.imageList1.Images.SetKeyName(2, "sua.png");
            this.imageList1.Images.SetKeyName(3, "thoat.jpg");
            this.imageList1.Images.SetKeyName(4, "timkiem.jpg");
            this.imageList1.Images.SetKeyName(5, "dangky.jpg");
            this.imageList1.Images.SetKeyName(6, "thanhtoan.png");
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.ForeColor = System.Drawing.Color.Teal;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimKiem.ImageKey = "timkiem.jpg";
            this.btnTimKiem.ImageList = this.imageList1;
            this.btnTimKiem.Location = new System.Drawing.Point(9, 22);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(81, 66);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.White;
            this.btnCapNhat.ForeColor = System.Drawing.Color.Teal;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCapNhat.ImageKey = "thanhtoan.png";
            this.btnCapNhat.ImageList = this.imageList1;
            this.btnCapNhat.Location = new System.Drawing.Point(108, 22);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(81, 66);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Trả sách";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.ForeColor = System.Drawing.Color.Teal;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLamMoi.ImageKey = "lammoi.jpg";
            this.btnLamMoi.ImageList = this.imageList1;
            this.btnLamMoi.Location = new System.Drawing.Point(108, 110);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(81, 66);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpChucNang
            // 
            this.grpChucNang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpChucNang.Controls.Add(this.btnXemCT);
            this.grpChucNang.Controls.Add(this.btnTimKiem);
            this.grpChucNang.Controls.Add(this.btnCapNhat);
            this.grpChucNang.Controls.Add(this.btnQuayLai);
            this.grpChucNang.Controls.Add(this.btnLamMoi);
            this.grpChucNang.Location = new System.Drawing.Point(468, 12);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(196, 267);
            this.grpChucNang.TabIndex = 5;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức Năng";
            // 
            // btnXemCT
            // 
            this.btnXemCT.BackColor = System.Drawing.Color.White;
            this.btnXemCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCT.ForeColor = System.Drawing.Color.Teal;
            this.btnXemCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXemCT.ImageKey = "dangky.jpg";
            this.btnXemCT.ImageList = this.imageList1;
            this.btnXemCT.Location = new System.Drawing.Point(59, 195);
            this.btnXemCT.Name = "btnXemCT";
            this.btnXemCT.Size = new System.Drawing.Size(81, 66);
            this.btnXemCT.TabIndex = 10;
            this.btnXemCT.Text = "Chi tiết";
            this.btnXemCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXemCT.UseVisualStyleBackColor = false;
            this.btnXemCT.Click += new System.EventHandler(this.btnXemCT_Click);
            // 
            // grpThongTinSach
            // 
            this.grpThongTinSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpThongTinSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpThongTinSach.Controls.Add(this.txtMaKH);
            this.grpThongTinSach.Controls.Add(this.label2);
            this.grpThongTinSach.Controls.Add(this.rdChuaTra);
            this.grpThongTinSach.Controls.Add(this.rdDaTra);
            this.grpThongTinSach.Controls.Add(this.label1);
            this.grpThongTinSach.Controls.Add(this.txtPhiTraMuon);
            this.grpThongTinSach.Controls.Add(this.dtpHanTra);
            this.grpThongTinSach.Controls.Add(this.dtpNgayTra);
            this.grpThongTinSach.Controls.Add(this.dtpNgayMuon);
            this.grpThongTinSach.Controls.Add(this.txtMaHD);
            this.grpThongTinSach.Controls.Add(this.lblPhiMuon);
            this.grpThongTinSach.Controls.Add(this.lblNgayTra);
            this.grpThongTinSach.Controls.Add(this.lblHanTra);
            this.grpThongTinSach.Controls.Add(this.lblNgayMuon);
            this.grpThongTinSach.Controls.Add(this.lblMaHD);
            this.grpThongTinSach.Location = new System.Drawing.Point(12, 12);
            this.grpThongTinSach.Name = "grpThongTinSach";
            this.grpThongTinSach.Size = new System.Drawing.Size(439, 267);
            this.grpThongTinSach.TabIndex = 6;
            this.grpThongTinSach.TabStop = false;
            this.grpThongTinSach.Text = "Thông Tin Sách";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(126, 63);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(247, 26);
            this.txtMaKH.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(65, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã KH:";
            // 
            // rdChuaTra
            // 
            this.rdChuaTra.AutoSize = true;
            this.rdChuaTra.Checked = true;
            this.rdChuaTra.Location = new System.Drawing.Point(353, 239);
            this.rdChuaTra.Name = "rdChuaTra";
            this.rdChuaTra.Size = new System.Drawing.Size(80, 20);
            this.rdChuaTra.TabIndex = 13;
            this.rdChuaTra.TabStop = true;
            this.rdChuaTra.Text = "Chưa trả";
            this.rdChuaTra.UseVisualStyleBackColor = true;
            // 
            // rdDaTra
            // 
            this.rdDaTra.AutoSize = true;
            this.rdDaTra.Location = new System.Drawing.Point(249, 239);
            this.rdDaTra.Name = "rdDaTra";
            this.rdDaTra.Size = new System.Drawing.Size(63, 20);
            this.rdDaTra.TabIndex = 13;
            this.rdDaTra.Text = "Đã trả";
            this.rdDaTra.UseVisualStyleBackColor = true;
            this.rdDaTra.CheckedChanged += new System.EventHandler(this.rdDaTra_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(106, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Xem theo trạng thái:";
            // 
            // txtPhiTraMuon
            // 
            this.txtPhiTraMuon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhiTraMuon.Location = new System.Drawing.Point(126, 179);
            this.txtPhiTraMuon.Name = "txtPhiTraMuon";
            this.txtPhiTraMuon.ReadOnly = true;
            this.txtPhiTraMuon.Size = new System.Drawing.Size(247, 26);
            this.txtPhiTraMuon.TabIndex = 11;
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTra.Location = new System.Drawing.Point(126, 123);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(247, 22);
            this.dtpHanTra.TabIndex = 10;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(126, 151);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(247, 22);
            this.dtpNgayTra.TabIndex = 9;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(126, 95);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(247, 22);
            this.dtpNgayMuon.TabIndex = 8;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(126, 31);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(247, 26);
            this.txtMaHD.TabIndex = 7;
            // 
            // lblPhiMuon
            // 
            this.lblPhiMuon.AutoSize = true;
            this.lblPhiMuon.ForeColor = System.Drawing.Color.Blue;
            this.lblPhiMuon.Location = new System.Drawing.Point(24, 184);
            this.lblPhiMuon.Name = "lblPhiMuon";
            this.lblPhiMuon.Size = new System.Drawing.Size(93, 16);
            this.lblPhiMuon.TabIndex = 5;
            this.lblPhiMuon.Text = "Phí trả muộn:";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.ForeColor = System.Drawing.Color.Blue;
            this.lblNgayTra.Location = new System.Drawing.Point(53, 151);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(64, 16);
            this.lblNgayTra.TabIndex = 4;
            this.lblNgayTra.Text = "Ngày trả:";
            // 
            // lblHanTra
            // 
            this.lblHanTra.AutoSize = true;
            this.lblHanTra.ForeColor = System.Drawing.Color.Blue;
            this.lblHanTra.Location = new System.Drawing.Point(60, 123);
            this.lblHanTra.Name = "lblHanTra";
            this.lblHanTra.Size = new System.Drawing.Size(57, 16);
            this.lblHanTra.TabIndex = 3;
            this.lblHanTra.Text = "Hạn trả:";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.ForeColor = System.Drawing.Color.Blue;
            this.lblNgayMuon.Location = new System.Drawing.Point(32, 95);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(85, 16);
            this.lblNgayMuon.TabIndex = 2;
            this.lblNgayMuon.Text = "Ngày mượn:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.ForeColor = System.Drawing.Color.Blue;
            this.lblMaHD.Location = new System.Drawing.Point(65, 36);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(52, 16);
            this.lblMaHD.TabIndex = 1;
            this.lblMaHD.Text = "Mã HD:";
            // 
            // dgvMuonTraSach
            // 
            this.dgvMuonTraSach.AllowUserToAddRows = false;
            this.dgvMuonTraSach.AllowUserToDeleteRows = false;
            this.dgvMuonTraSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMuonTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuonTraSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colMaKH,
            this.colNgayMuon,
            this.colHanTra,
            this.colNgayTra,
            this.colPhiTraMuon});
            this.dgvMuonTraSach.Location = new System.Drawing.Point(12, 285);
            this.dgvMuonTraSach.Name = "dgvMuonTraSach";
            this.dgvMuonTraSach.ReadOnly = true;
            this.dgvMuonTraSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuonTraSach.Size = new System.Drawing.Size(652, 287);
            this.dgvMuonTraSach.TabIndex = 7;
            this.dgvMuonTraSach.SelectionChanged += new System.EventHandler(this.dgvMuonTraSach_SelectionChanged);
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHD";
            this.colMaHD.HeaderText = "Mã HD";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.ReadOnly = true;
            this.colMaHD.Width = 140;
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "MaKH";
            this.colMaKH.HeaderText = "Mã khách hàng";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.ReadOnly = true;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.DataPropertyName = "NgayMuon";
            this.colNgayMuon.HeaderText = "Ngày mượn";
            this.colNgayMuon.Name = "colNgayMuon";
            this.colNgayMuon.ReadOnly = true;
            this.colNgayMuon.Width = 140;
            // 
            // colHanTra
            // 
            this.colHanTra.DataPropertyName = "HanTra";
            this.colHanTra.HeaderText = "Hạn trả";
            this.colHanTra.Name = "colHanTra";
            this.colHanTra.ReadOnly = true;
            this.colHanTra.Width = 140;
            // 
            // colNgayTra
            // 
            this.colNgayTra.DataPropertyName = "NgayTra";
            this.colNgayTra.HeaderText = "Ngày trả";
            this.colNgayTra.Name = "colNgayTra";
            this.colNgayTra.ReadOnly = true;
            this.colNgayTra.Width = 150;
            // 
            // colPhiTraMuon
            // 
            this.colPhiTraMuon.DataPropertyName = "PhiTraMuon";
            this.colPhiTraMuon.HeaderText = "Phí trả muộn";
            this.colPhiTraMuon.Name = "colPhiTraMuon";
            this.colPhiTraMuon.ReadOnly = true;
            this.colPhiTraMuon.Width = 150;
            // 
            // QuanLyMuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(676, 584);
            this.Controls.Add(this.dgvMuonTraSach);
            this.Controls.Add(this.grpThongTinSach);
            this.Controls.Add(this.grpChucNang);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyMuonTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Mượn Trả Sách";
            this.Load += new System.EventHandler(this.QuanLyMuonTraSach_Load);
            this.grpChucNang.ResumeLayout(false);
            this.grpThongTinSach.ResumeLayout(false);
            this.grpThongTinSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTraSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.GroupBox grpThongTinSach;
        private System.Windows.Forms.DataGridView dgvMuonTraSach;
        private System.Windows.Forms.Label lblPhiMuon;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblHanTra;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.TextBox txtPhiTraMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdChuaTra;
        private System.Windows.Forms.RadioButton rdDaTra;
        private System.Windows.Forms.Button btnXemCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhiTraMuon;
    }
}