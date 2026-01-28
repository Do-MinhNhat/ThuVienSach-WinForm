using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using ThuVienSachBUS;

namespace ThuVienSach
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        NhanVienBUS NV = new NhanVienBUS();
        NhanVienDTO nv;
        public bool KiemTraTK(string taikhoan)
        {
            return Regex.IsMatch(taikhoan, "^[a-zA-Z0-9]{6,24}$");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraTK(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản đúng định dạng!\nÍt nhất là 6 ký tự và tối đa là 30\nTài khoản không được có ký tự đặc biệt", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text.Length < 5 || txtPassword.Text.Length > 24)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu với độ dài từ 6-24 ký tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtXacNhan.Text != txtPassword.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LayNV();
            if (NV.KiemTraSDT(nv))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (NV.KiemTraUser(nv))
            {
                MessageBox.Show("Username đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ThemNV())
            {
                MessageBox.Show($"Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Đăng ký không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ThemNV()
        {
            int kq = NV.Them(nv);
            return kq > 0;
        }

        private void LayNV()
        {
            nv = new NhanVienDTO();
            nv.MaCV = "3";
            nv.TenNV = txtHoVaTen.Text;
            nv.GioiTinh = rdNam.Checked == true ? "Nam" : "Nữ";
            nv.DChi = txtDiaChi.Text;
            nv.SDT = txtSDT.Text;
            nv.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
            nv.Luong = 0;
            nv.UserName = txtUsername.Text;
            nv.PassWord = txtPassword.Text;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtSDT.Text.Length > 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
