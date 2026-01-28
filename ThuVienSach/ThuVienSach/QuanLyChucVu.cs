using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using ThuVienSachBUS;

namespace ThuVienSach
{
    public partial class QuanLyChucVu : Form
    {
        public QuanLyChucVu()
        {
            InitializeComponent();
        }
        ChucVuBUS CV = new ChucVuBUS();
        List<ChucVuDTO> dsCV;
        ChucVuDTO cv;
        private void QuanLyChucVu_Load(object sender, EventArgs e)
        {
            dgvChucVu.AutoGenerateColumns = false;
            LoadDSCV();
        }

        private void LoadDSCV()
        {
            dsCV = CV.LayDSCV();
            dgvChucVu.DataSource = dsCV;
            dgvChucVu.ClearSelection();
        }

        private void dgvChucVu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChucVu.SelectedRows.Count > 0)
            {
                cv = dgvChucVu.SelectedRows[0].DataBoundItem as ChucVuDTO;
            }
            else cv = null;
            HienThi();
        }

        private void HienThi()
        {
            if (cv != null)
            {
                txtMaChucVu.Text = cv.MaCV;
                txtTenChucVu.Text = cv.TenCV;
            }
            else
            {
                txtMaChucVu.Clear();
                txtTenChucVu.Clear();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckTxt())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LayCV();
            if (ThemCV())
            {
                MessageBox.Show($"Thêm chức vụ: '{cv.TenCV}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSCV();
                return;
            }
            MessageBox.Show("Thêm chức vụ không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cv = null;
        }

        private bool ThemCV()
        {
            int kq = CV.Them(cv);
            return kq > 0;
        }

        private void LayCV()
        {
            cv = new ChucVuDTO();
            cv.MaCV = txtMaChucVu.Text;
            cv.TenCV = txtTenChucVu.Text;
        }

        private bool CheckTxt()
        {
            if (CV.TxtError(txtTenChucVu.Text))
            {
                return false;
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cv == null)
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
                LayCV();
                if (SuaCV())
                {
                    MessageBox.Show($"Đã sửa chức vụ số: '{cv.MaCV}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSCV();
                    return;
                }
                MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cv = null;
            }
        }

        private bool SuaCV()
        {
            int kq = CV.Sua(cv);
            return kq > 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cv == null)
            {
                MessageBox.Show("Vui lòng chọn để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (XoaCV())
                {
                    MessageBox.Show($"Đã xóa chức vụ: '{cv.TenCV}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSCV();
                    return;
                }
                MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool XoaCV()
        {
            int kq = CV.Xoa(cv);
            return kq > 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dsCV = CV.TimKiem(txtTenChucVu.Text);
            dgvChucVu.DataSource = dsCV;
            dgvChucVu.ClearSelection();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSCV();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
