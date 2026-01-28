using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVienSachBUS;

namespace ThuVienSach
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        NhanVienBUS NV = new NhanVienBUS();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!KiemTraDN())
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (NV.LayTTCV(txtTaiKhoan.Text))
            {
                case 1:
                    QuanLy quanLy = new QuanLy();
                    Hide();
                    quanLy.ShowDialog();
                    Show();
                    ; break;
                case 2:
                    NhanVien nhanVien = new NhanVien();
                    Hide();
                    nhanVien.ShowDialog();
                    Show();
                    ; break;
                default: MessageBox.Show("Nhân viên chưa được đăng ký chức vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
        }

        private bool KiemTraDN()
        {
            if (NV.KiemTraDN(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                return true;
            }
            return false;
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHienMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = ('\0');
            }
            else
            {
                txtMatKhau.PasswordChar = ('*');
            }
        }
        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            DangKy dangky = new DangKy();
            this.Hide();
            dangky.ShowDialog();
            Show();
        }
    }
}
