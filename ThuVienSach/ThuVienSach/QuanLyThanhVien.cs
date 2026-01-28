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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ThuVienSach
{
    public partial class QuanLyThanhVien : Form
    {
        public QuanLyThanhVien()
        {
            InitializeComponent();
        }
        KhachHangBUS KH = new KhachHangBUS();
        List<KhachHangDTO> dsKH;
        KhachHangDTO kh;
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckTxt())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (txtSDT.Text.Length < 9)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!KH.KiemTraEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LayKH();
            if (KH.KiemTra(kh))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ThemKH())
            {
                MessageBox.Show($"Thêm thành viên: '{kh.TenKH}' thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDSKH();
                return;
            }
            MessageBox.Show("Thêm thành viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            kh = null;
        }

        private void LayKH()
        {
            kh = new KhachHangDTO();
            kh.MaKH = txtMaSo.Text;
            kh.TenKH = txtTenKH.Text;
            kh.DChi = txtDChi.Text;
            kh.GioiTinh = radNam.Checked == true ? "Nam" : "Nữ";
            kh.NgaySinh = dtpNgaySinh.Value;
            kh.NgayLapThe = dtpNgayLapThe.Value;
            kh.Email = txtEmail.Text;
            kh.SDT = txtSDT.Text;
        }

        private bool ThemKH()
        {
            int kq = KH.Them(kh);
            return kq > 0;
        }

        private bool CheckTxt()
        {
            if (KH.TxtError(txtTenKH.Text, txtDChi.Text, txtEmail.Text, txtSDT.Text))
            {
                return false;
            }
            return true;
        }

        private void QuanLyThanhVien_Load(object sender, EventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = false;
            LoadDSKH();
        }

        private void LoadDSKH()
        {
            dsKH = KH.LayDSKH();
            dgvKhachHang.DataSource = dsKH;
            dgvKhachHang.ClearSelection();
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                kh = dgvKhachHang.SelectedRows[0].DataBoundItem as KhachHangDTO;
                txtSDT.ReadOnly = true;
            }
            else kh = null;
            HienThi();
        }

        private void HienThi()
        {
            if (kh != null)
            {
                txtMaSo.Text = kh.MaKH;
                txtTenKH.Text = kh.TenKH;
                txtDChi.Text = kh.DChi;
                if(kh.GioiTinh == "Nam") radNam.Checked = true; else radNu.Checked = true;
                dtpNgayLapThe.Value = kh.NgayLapThe;
                dtpNgaySinh.Value = kh.NgaySinh;
                txtEmail.Text = kh.Email;
                txtSDT.Text = kh.SDT;
            }
            else {
                txtMaSo.Clear();
                txtTenKH.Clear();
                txtDChi.Clear();
                radNam.Checked = true;
                dtpNgayLapThe.Value = DateTime.Now;
                dtpNgaySinh.Value = DateTime.Now;
                txtEmail.Clear();
                txtSDT.Clear();
                txtSDT.ReadOnly = false;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSKH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(kh == null)
            {
                MessageBox.Show("Vui lòng chọn để xóa!","Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                if (XoaKH())
                {
                    MessageBox.Show($"Đã xóa thành viên: '{kh.TenKH}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSKH();
                    return;
                }
                MessageBox.Show("Xóa thành viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool XoaKH()
        {
            int kq = KH.Xoa(kh);
            return kq > 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (kh == null)
            {
                MessageBox.Show("Vui lòng chọn để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!CheckTxt())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KH.KiemTraEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                LayKH();
                if (SuaKH())
                {
                    MessageBox.Show($"Đã sửa thành viên số: '{kh.MaKH}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSKH();
                    return;
                }
                MessageBox.Show("Sửa thành viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kh = null;
            }
        }

        private bool SuaKH()
        {
            int kq = KH.Sua(kh);
            return kq > 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dsKH = KH.TimKiem(txtTenKH.Text,txtDChi.Text,txtEmail.Text,txtSDT.Text);
            dgvKhachHang.DataSource = dsKH;
            dgvKhachHang.ClearSelection();
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
