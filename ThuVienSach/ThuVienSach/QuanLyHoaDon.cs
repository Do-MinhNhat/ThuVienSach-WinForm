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
    public partial class QuanLyHoaDon : Form
    {
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }
        HoaDonBUS HD = new HoaDonBUS();
        List<HoaDonDTO> dsHD;
        HoaDonDTO hd;

        NhanVienBUS NV = new NhanVienBUS();
        KhachHangBUS KH = new KhachHangBUS();
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;
            LoadDSHD();
        }

        private void LoadDSHD()
        {
            dsHD = HD.LayDSHD(rdMua.Checked ? 1 : 2);
            dgvHoaDon.DataSource = dsHD;
            dgvHoaDon.ClearSelection();
        }

        private void rdMua_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSHD();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSHD();
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                hd = dgvHoaDon.SelectedRows[0].DataBoundItem as HoaDonDTO;
                txtMaHD.ReadOnly = true;
            }
            else hd = null;
            HienThi();
        }

        private void HienThi()
        {
            if(hd != null)
            {
                txtMaHD.Text = hd.MaHD;
                txtMaNV.Text = hd.MaNV;
                txtMaKH.Text = hd.MaKH;
                dtpNgayLapHD.Value = hd.NgayLap;
                txtTongTien.Text = hd.TongTien.ToString();
            }
            else
            {
                txtMaHD.Clear();
                txtMaNV.Clear();
                txtMaKH.Clear();
                dtpNgayLapHD.Value = DateTime.Now;
                txtTongTien.Clear();
                txtMaHD.ReadOnly = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(hd == null)
            {
                MessageBox.Show("Vui lòng chọn để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!CheckTxt())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!NV.TonTaiNV(txtMaNV.Text))
            {
                MessageBox.Show("Nhân viên không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KH.TonTaiKH(txtMaKH.Text))
            {
                MessageBox.Show("Khách hàng không tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Xác nhận sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes) 
            { 
                LayHD();
                if (SuaHD())
                {
                    MessageBox.Show("Sửa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSHD();
                    return;
                }
                MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SuaHD()
        {
            int kq = HD.Sua(hd);
            return kq > 0;
        }

        private void LayHD()
        {
            hd = new HoaDonDTO();
            hd.MaHD = txtMaHD.Text;
            hd.MaNV = txtMaNV.Text;
            hd.MaKH = txtMaKH.Text;
            hd.NgayLap = dtpNgayLapHD.Value;
            hd.TongTien = float.Parse(txtTongTien.Text);
        }

        private bool CheckTxt()
        {
            if (HD.TxtError(txtMaKH.Text, txtMaNV.Text))
            {
                return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(hd == null)
            {
                MessageBox.Show("Vui lòng chọn để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (XoaHD())
                {
                    MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSHD();
                    return;
                }
                MessageBox.Show("Xóa thất bại!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool XoaHD()
        {
            int kq = HD.Xoa(hd);
            return kq > 0;
        }

        private void btnXemCT_Click(object sender, EventArgs e)
        {
            if (hd == null)
            {
                MessageBox.Show("Vui lòng chọn để xem", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(HD.Xem(hd.MaHD), "Hóa đơn");
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            dsHD = HD.Tim(txtMaHD.Text, txtMaNV.Text, txtMaKH.Text,rdMua.Checked?1:2);
            dgvHoaDon.DataSource = dsHD;
            dgvHoaDon.ClearSelection();
        }
    }
}
