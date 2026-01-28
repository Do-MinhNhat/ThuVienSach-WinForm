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
    public partial class QuanLyMuonTraSach : Form
    {
        public QuanLyMuonTraSach()
        {
            InitializeComponent();
        }
        LHDHoaDonBUS LHDHD = new LHDHoaDonBUS();
        List<LHDHoaDonDTO> dsLHDHD;
        LHDHoaDonDTO lhdhd;

        HoaDonBUS HD = new HoaDonBUS();

        ChiTietHoaDonBUS CTHD = new ChiTietHoaDonBUS();
        List<ChiTietHoaDonDTO> dsCTHD;

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuanLyMuonTraSach_Load(object sender, EventArgs e)
        {
            dgvMuonTraSach.AutoGenerateColumns = false;
            LoadDSLHDHD(0);
        }

        private void LoadDSLHDHD(int TrangThai)
        {
            dsLHDHD = LHDHD.LayDSLHDHD(TrangThai);
            dgvMuonTraSach.DataSource = dsLHDHD;
            dgvMuonTraSach.ClearSelection();
        }

        private void dgvMuonTraSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMuonTraSach.SelectedRows.Count > 0)
            {
                lhdhd = dgvMuonTraSach.SelectedRows[0].DataBoundItem as LHDHoaDonDTO;
                txtMaKH.ReadOnly = true;
                txtMaHD.ReadOnly = true;
            }
            else lhdhd = null;
                HienThi();
        }

        private void HienThi()
        {
            if(lhdhd != null)
            {
                txtMaHD.Text = lhdhd.MaHD;
                txtMaKH.Text = lhdhd.MaKH;
                dtpNgayMuon.Value = lhdhd.NgayMuon;
                dtpHanTra.Value = lhdhd.HanTra;
                if (lhdhd.TrangThai == 1) rdDaTra.Checked = true; else rdChuaTra.Checked = true;
            }
            else
            {
                txtMaHD.Clear();
                txtMaKH.Clear();
                dtpNgayMuon.Value = DateTime.Now;
                dtpHanTra.Value = DateTime.Now;
                txtMaKH.ReadOnly = false;
                txtMaHD.ReadOnly = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lhdhd == null)
            {
                MessageBox.Show("Vui lòng chọn để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rdDaTra.Checked)
            {
                MessageBox.Show("Bạn không thể làm vậy!","Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LayLHDHD();
            if (CapNhatLHDHD())
            {
                DialogResult dr = MessageBox.Show($"Phí trả muộn là: {lhdhd.PhiTraMuon}\nXác nhận trả sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    LHDHD.TraSach(lhdhd);
                    HD.CapNhat(lhdhd.MaHD, lhdhd.PhiTraMuon);
                    LoadDSLHDHD(0);
                }
                else
                {
                    LoadDSLHDHD(0);
                }
            }
            else MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CapNhatLHDHD()
        {
            int kq = LHDHD.CapNhat(lhdhd);
            return kq > 0;
        }

        private void LayLHDHD()
        {
            lhdhd = new LHDHoaDonDTO();
            lhdhd.MaHD = txtMaHD.Text;
            lhdhd.NgayTra = dtpNgayTra.Value;
            TimeSpan ngay = lhdhd.NgayTra - dtpHanTra.Value;
            int SL = LayTongSLS();
            if(ngay.Days <= 0)
            lhdhd.PhiTraMuon = 0;
            else
            {
                lhdhd.PhiTraMuon = 10000 * ngay.Days * SL;
            }
        }

        private int LayTongSLS()
        {
            int kq = 0;
            dsCTHD = CTHD.Tim(lhdhd.MaHD);
            foreach (var sach in dsCTHD)
            {
                kq += sach.SoLuong;
            }
            return kq;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dsLHDHD = LHDHD.TimKiem(txtMaKH.Text,rdDaTra.Checked?1:0,txtMaHD.Text);
            dgvMuonTraSach.DataSource = dsLHDHD;
            dgvMuonTraSach.ClearSelection();
        }

        private void rdDaTra_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSLHDHD(rdDaTra.Checked ? 1 : 0);
        }

        private void btnXemCT_Click(object sender, EventArgs e)
        {
            if (lhdhd == null)
            {
                MessageBox.Show("Vui lòng chọn để xem", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(HD.Xem(lhdhd.MaHD), "Hóa đơn");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSLHDHD(rdDaTra.Checked?1:0);
        }
    }
}
