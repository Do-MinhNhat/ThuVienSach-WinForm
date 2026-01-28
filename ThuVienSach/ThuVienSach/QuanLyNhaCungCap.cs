using DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ThuVienSach
{
    public partial class QuanLyNhaCungCap : Form
    {
        public QuanLyNhaCungCap()
        {
            InitializeComponent();
        }
        NhaCungCapBUS NCC = new NhaCungCapBUS();
        List<NhaCungCapDTO> dsNCC;
        NhaCungCapDTO ncc;
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
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
            LayNCC();
            if (NCC.KiemTra(ncc))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ThemNCC())
            {
                MessageBox.Show($"Thêm nhà cung cấp: '{ncc.TenNCC}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNCC();
                return;
            }
            MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ncc = null;
        }
        private void LayNCC()
        {
            ncc = new NhaCungCapDTO();
            ncc.MaNCC = txtMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            ncc.DChi = txtDiaChi.Text;
            ncc.SDT = txtSDT.Text;
        }

        private bool ThemNCC()
        {
            int kq = NCC.Them(ncc);
            return kq > 0;
        }

        private bool CheckTxt()
        {
            if (NCC.TxtError(txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text))
            {
                return false;
            }
            return true;
        }

        private void QuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCungCap.AutoGenerateColumns = false;
            LoadDSNCC();
        }
        private void LoadDSNCC()
        {
            dsNCC = NCC.LayDSNCC();
            dgvNhaCungCap.DataSource = dsNCC;
            dgvNhaCungCap.ClearSelection();
        }
        private void dgvNhaCungCap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.SelectedRows.Count > 0)
            {
                ncc = dgvNhaCungCap.SelectedRows[0].DataBoundItem as NhaCungCapDTO;
                txtSDT.ReadOnly = true;
            }
            else ncc = null;
            HienThi();
        }
        private void HienThi()
        {
            if (ncc != null)
            {
                txtMaNCC.Text = ncc.MaNCC;
                txtTenNCC.Text = ncc.TenNCC;
                txtDiaChi.Text = ncc.DChi;
                txtSDT.Text = ncc.SDT;
            }
            else
            {
                txtMaNCC.Clear();
                txtTenNCC.Clear();
                txtDiaChi.Clear();
                txtSDT.Clear();
                txtSDT.ReadOnly = false;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSNCC();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ncc == null)
            {
                MessageBox.Show("Vui lòng chọn để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (XoaNCC())
                {
                    MessageBox.Show($"Đã xóa: '{ncc.TenNCC}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSNCC();
                    return;
                }
                MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool XoaNCC()
        {
            int kq = NCC.Xoa(ncc);
            return kq > 0;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dsNCC = NCC.TimKiem(txtTenNCC.Text,txtDiaChi.Text,txtSDT.Text);
            dgvNhaCungCap.DataSource = dsNCC;
            dgvNhaCungCap.ClearSelection();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ncc == null)
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
                LayNCC();
                if (SuaNCC())
                {
                    MessageBox.Show($"Đã sửa nhà cung cấp số: '{ncc.MaNCC}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSNCC();
                    return;
                }
                MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ncc = null;
            }
        }

        private bool SuaNCC()
        {
            int kq = NCC.Sua(ncc);
            return kq > 0;
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
