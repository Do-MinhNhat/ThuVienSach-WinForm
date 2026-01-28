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
    public partial class QuanLyTheLoaiSach : Form
    {
        public QuanLyTheLoaiSach()
        {
            InitializeComponent();
        }
        TheLoaiSachBUS TLS = new TheLoaiSachBUS();
        List<TheLoaiSachDTO> dsTLS;
        TheLoaiSachDTO tls;
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuanLyTheLoaiSach_Load(object sender, EventArgs e)
        {
            dgvTheLoai.AutoGenerateColumns = false;
            LoadDSTLS();
        }

        private void LoadDSTLS()
        {
            dsTLS = TLS.LayDSTLS();
            dgvTheLoai.DataSource = dsTLS;
            dgvTheLoai.ClearSelection();
        }

        private void dgvTheLoai_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count > 0)
            {
                tls = dgvTheLoai.SelectedRows[0].DataBoundItem as TheLoaiSachDTO;
            }
            else tls = null;
            HienThi();
        }

        private void HienThi()
        {
            if(tls != null)
            {
                txtMaTheLoai.Text = tls.MaTL;
                txtTenTheLoai.Text = tls.TenTL;
            }
            else
            {
                txtMaTheLoai.Clear();
                txtTenTheLoai.Clear();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckTxt())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LayTLS();
            if (ThemTLS())
            {
                MessageBox.Show($"Thêm thể loại sách: '{tls.TenTL}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSTLS();
                return;
            }
            MessageBox.Show("Thêm thể loại sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tls = null;
        }

        private bool ThemTLS()
        {
            int kq = TLS.Them(tls);
            return kq > 0;
        }

        private void LayTLS()
        {
            tls = new TheLoaiSachDTO();
            tls.MaTL = txtMaTheLoai.Text;
            tls.TenTL = txtTenTheLoai.Text;
        }

        private bool CheckTxt()
        {
            if (TLS.TxtError(txtTenTheLoai.Text))
            {
                return false;
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(tls == null)
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
            if(dr == DialogResult.Yes)
            {
                LayTLS();
                if (SuaTLS())
                {
                    MessageBox.Show($"Đã sửa thể loại số: '{tls.MaTL}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSTLS();
                    return;
                }
                MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tls = null;
            }
        }

        private bool SuaTLS()
        {
            int kq = TLS.Sua(tls);
            return kq > 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tls == null)
            {
                MessageBox.Show("Vui lòng chọn để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (XoaTLS())
                {
                    MessageBox.Show($"Đã xóa thể loại: '{tls.TenTL}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSTLS();
                    return;
                }
                MessageBox.Show("Xóa không thành công!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool XoaTLS()
        {
            int kq = TLS.Xoa(tls);
            return kq > 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dsTLS = TLS.TimKiem(txtTenTheLoai.Text);
            dgvTheLoai.DataSource = dsTLS;
            dgvTheLoai.ClearSelection();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSTLS();
        }
    }
}
