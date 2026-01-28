using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVienSachBUS;

namespace ThuVienSach
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        NhanVienBUS NV = new NhanVienBUS();
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            LapHoaDon laphoadon = new LapHoaDon();
            Hide();
            laphoadon.ShowDialog();
            Show();
        }

        private void btnQuanLyThanhVien_Click(object sender, EventArgs e)
        {
            QuanLyThanhVien quanlythanhvien = new QuanLyThanhVien();
            Hide();
            quanlythanhvien.ShowDialog();
            Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dlg;
            dlg = MessageBox.Show("Bạn có muốn đăng xuất không? ", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
               Close();
            }
        }

        private void btnQuanLyMuonTraSach_Click(object sender, EventArgs e)
        {
            QuanLyMuonTraSach quanlymuontrasach = new QuanLyMuonTraSach();
            Hide();
            quanlymuontrasach.ShowDialog();
            Show();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            lblNguoiDung.Text = NV.LayTenNVDN() + " #" + NV.LayMaNVDN();
        }
    }
}
