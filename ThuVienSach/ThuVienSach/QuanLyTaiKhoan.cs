using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using ThuVienSachBUS;

namespace ThuVienSach
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        NhanVienBUS NV = new NhanVienBUS();
        List<NhanVienDTO> dsNV;
        NhanVienDTO nv;

        ChucVuBUS CV = new ChucVuBUS();
        List<ChucVuDTO> dsCV;
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDSCV();
            dgvNhanVien.AutoGenerateColumns = false;
            LoadDSNV();
        }

        private void LoadDSNV()
        {
            dsNV = NV.LayDSNV();
            dgvNhanVien.DataSource = dsNV;
            dgvNhanVien.ClearSelection();
        }

        private void LoadDSCV()
        {
            dsCV = CV.LayDSCV();

            cbChucVu.DataSource = dsCV;
            cbChucVu.ValueMember = "MaCV";
            cbChucVu.DisplayMember = "TenCV";

            colChucVu.DataSource = dsCV;
            colChucVu.ValueMember = "MaCV";
            colChucVu.DisplayMember = "TenCV";
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                nv = dgvNhanVien.SelectedRows[0].DataBoundItem as NhanVienDTO;
                txtSDT.ReadOnly = true;
                txtUsername.ReadOnly = true;
            }
            else nv = null;
            HienThi();
        }

        private void HienThi()
        {
            if(nv != null)
            {
                txtMaNV.Text = nv.MaNV;
                cbChucVu.SelectedValue = nv.MaCV;
                txtTenNV.Text = nv.TenNV;
                if (nv.GioiTinh == "Nam") radNam.Checked = true; else radNu.Checked = true;
                txtDChi.Text = nv.DChi;
                txtSDT.Text = nv.SDT;
                txtLuong.Text = nv.Luong.ToString();
                txtUsername.Text = nv.UserName;
                txtPassword.Text = nv.PassWord;
            }
            else
            {
                txtMaNV.Clear();
                cbChucVu.SelectedIndex = 0;
                txtTenNV.Clear();
                radNam.Checked = true;
                dtpNgaySinh.Value = DateTime.Now;
                txtDChi.Clear();
                txtSDT.Clear();
                txtLuong.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtSDT.ReadOnly = false;
                txtUsername.ReadOnly = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckTxt())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSDT.Text.Length < 9)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Thêm nhân viên: '{nv.TenNV}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNV();
                return;
            }
            MessageBox.Show("Thêm nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            nv = null;
        }

        private bool ThemNV()
        {
            int kq = NV.Them(nv);
            return kq > 0;
        }

        private void LayNV()
        {
            nv = new NhanVienDTO();
            nv.MaNV = txtMaNV.Text;
            nv.MaCV = cbChucVu.SelectedValue.ToString();
            nv.TenNV = txtTenNV.Text;
            nv.GioiTinh = radNam.Checked == true ? "Nam" : "Nữ";
            nv.DChi = txtDChi.Text;
            nv.SDT = txtSDT.Text;
            nv.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
            nv.Luong = float.Parse(txtLuong.Text);
            nv.UserName = txtUsername.Text;
            nv.PassWord = txtPassword.Text;
        }

        private bool CheckTxt()
        {
            if (NV.TxtError(cbChucVu.SelectedValue.ToString(), txtTenNV.Text, txtDChi.Text, txtSDT.Text, txtLuong.Text, txtUsername.Text, txtPassword.Text))
            {
                return false;
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (nv == null)
            {
                MessageBox.Show("Vui lòng chọn để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!CheckTxt())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                LayNV();
                if (SuaNV())
                {
                    MessageBox.Show($"Đã sửa thành viên số: '{nv.MaNV}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSNV();
                    return;
                }
                MessageBox.Show("Sửa thành viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nv = null;
            }
        }

        private bool SuaNV()
        {
            int kq = NV.Sua(nv);
            return kq > 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nv == null)
            {
                MessageBox.Show("Vui lòng chọn để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (XoaNV())
                {
                    MessageBox.Show($"Đã xóa thành viên: '{nv.TenNV}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSNV();
                    return;
                }
                MessageBox.Show("Xóa thành viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool XoaNV()
        {
            int kq = NV.Xoa(nv);
            return kq > 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dsNV = NV.TimKiem(txtTenNV.Text,txtDChi.Text,txtSDT.Text,txtUsername.Text);
            dgvNhanVien.DataSource = dsNV;
            dgvNhanVien.ClearSelection();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSNV();
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            QuanLyChucVu quanLyChucVu = new QuanLyChucVu();
            quanLyChucVu.ShowDialog();
            LoadDSNV();
            LoadDSCV();
            cbChucVu.SelectedIndex = cbChucVu.Items.Count - 1;
        }
    }
}
