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
    public partial class QuanLyTacGia : Form
    {
        public QuanLyTacGia()
        {
            InitializeComponent();
        }
        TacGiaBUS TG = new TacGiaBUS();
        List<TacGiaDTO> dsTG;
        TacGiaDTO tg;
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuanLyTacGia_Load(object sender, EventArgs e)
        {
            dgvTacGia.AutoGenerateColumns = false;
            LoadDSTG();
        }

        private void LoadDSTG()
        {
            dsTG = TG.LayDSTG();
            dgvTacGia.DataSource = dsTG;
            dgvTacGia.ClearSelection();
        }

        private void dgvTacGia_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count > 0)
            {
                tg = dgvTacGia.SelectedRows[0].DataBoundItem as TacGiaDTO;
            }
            else tg = null;
            HienThi();
        }

        private void HienThi()
        {
            if (tg != null)
            {
                txtMaTacGia.Text = tg.MaTG;
                txtTenTacGia.Text = tg.TenTG;
            }
            else
            {
                txtMaTacGia.Clear();
                txtTenTacGia.Clear();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckTxt())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LayTG();
            if (ThemTG())
            {
                MessageBox.Show($"Thêm tác giả: '{tg.TenTG}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSTG();
                return;
            }
            MessageBox.Show("Thêm tác giả không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tg = null;
        }

        private bool ThemTG()
        {
            int kq = TG.Them(tg);
            return kq > 0;
        }

        private void LayTG()
        {
            tg = new TacGiaDTO();
            tg.MaTG = txtMaTacGia.Text;
            tg.TenTG = txtTenTacGia.Text;
        }

        private bool CheckTxt()
        {
            if (TG.TxtError(txtTenTacGia.Text))
            {
                return false;
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tg == null)
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
                LayTG();
                if (SuaTG())
                {
                    MessageBox.Show($"Đã sửa tác giả số: '{tg.MaTG}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSTG();
                    return;
                }
                MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tg = null;
            }
        }

        private bool SuaTG()
        {
            int kq = TG.Sua(tg);
            return kq > 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tg == null)
            {
                MessageBox.Show("Vui lòng chọn để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (XoaTG())
                {
                    MessageBox.Show($"Đã xóa tác giả: '{tg.TenTG}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSTG();
                    return;
                }
                MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool XoaTG()
        {
            int kq = TG.Xoa(tg);
            return kq > 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dsTG = TG.TimKiem(txtTenTacGia.Text);
            dgvTacGia.DataSource = dsTG;
            dgvTacGia.ClearSelection();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSTG();
        }
    }
}
