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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }
        NhanVienBUS NV = new NhanVienBUS();
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dlg;
            dlg = MessageBox.Show("Bạn có muốn đăng xuất không? ", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon quanlyhoadon = new QuanLyHoaDon();
            Hide();
            quanlyhoadon.ShowDialog();
            Show();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            QuanLySach quanlysach = new QuanLySach();
            Hide();
            quanlysach.ShowDialog();
            Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe thongke = new ThongKe();
            Hide();
            thongke.ShowDialog();
            Show();
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan quanlytaikhoan = new QuanLyTaiKhoan();
            Hide();
            quanlytaikhoan.ShowDialog();
            Show();
        }
        private void btnQuanLyThanhVien_Click(object sender, EventArgs e)
        {
            QuanLyThanhVien quanlythanhvien = new QuanLyThanhVien();
            Hide();
            quanlythanhvien.ShowDialog();
            Show();
        }
        private void btnQuanLyMuonTraSach_Click(object sender, EventArgs e)
        {
            QuanLyMuonTraSach quanlymuontrasach = new QuanLyMuonTraSach();
            Hide();
            quanlymuontrasach.ShowDialog();
            Show();
        }
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            LapHoaDon laphoadon = new LapHoaDon();
            Hide();
            laphoadon.ShowDialog();
            Show();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            lblNguoiDung.Text = NV.LayTenNVDN() + " #" + NV.LayMaNVDN();
        }
    }
}
