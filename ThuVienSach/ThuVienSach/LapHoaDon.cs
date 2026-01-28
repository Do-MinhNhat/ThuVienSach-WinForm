using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using ThuVienSachBUS;

namespace ThuVienSach
{
    public partial class LapHoaDon : Form
    {
        public LapHoaDon()
        {
            InitializeComponent();
        }
        NhanVienBUS NV = new NhanVienBUS();

        SachBUS S = new SachBUS();
        List<SachDTO> dsS;
        SachDTO s;

        ChiTietHoaDonBUS CTHD = new ChiTietHoaDonBUS();
        List<ChiTietHoaDonDTO> dsCTHD;
        ChiTietHoaDonDTO cthd;

        HoaDonBUS HD = new HoaDonBUS();
        HoaDonDTO hd;

        LHDHoaDonBUS LHDHD = new LHDHoaDonBUS();
        LHDHoaDonDTO lhdhd;

        KhachHangBUS KH = new KhachHangBUS();

        float ThanhTien = 0;

        bool isLuu = false;
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LapHoaDon_Load(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.AutoGenerateColumns = false;
            LoadDSSP();
            txtMaNV.Text = NV.LayMaNVDN();
            LoadDSCTHD();
        }

        private void LoadDSSP()
        {
            lvSach.Clear();
            dsS = S.LayDSS();
            foreach (var sach in dsS)
            {
                ListViewItem item = new ListViewItem(sach.TenSach);
                item.SubItems.Add(sach.HinhAnh);
                item.SubItems.Add(sach.MaSach);
                item.SubItems.Add(sach.GiaBan.ToString());
                item.SubItems.Add(sach.SoLuong.ToString());
                Image image = Image.FromFile(@"..\..\..\..\HinhSach\" + sach.HinhAnh);
                imageList2.Images.Add(image);
                item.ImageIndex = imageList2.Images.Count - 1;
                lvSach.Items.Add(item);
            }
        }

        private void lvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSach.SelectedItems.Count > 0)
            {
                s = new SachDTO();
                ListViewItem item = lvSach.SelectedItems[0];
                s.TenSach = item.SubItems[0].Text;
                s.MaSach = item.SubItems[2].Text;
                s.GiaBan = float.Parse(item.SubItems[3].Text);
                s.SoLuong = int.Parse(item.SubItems[4].Text);
                nudSL.Maximum = decimal.Parse(item.SubItems[4].Text);
                if (nudSL.Maximum == 0)
                {
                    MessageBox.Show("Sản phẩm đã hết hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    s = null;
                    return;
                }
            }
            else s = null;
            HienThi();
        }

        private void HienThi()
        {
            if (s != null)
            {
                txtMaSach.Text = s.MaSach;
                txtDonGia.Text = s.GiaBan.ToString();
            }
            else
            {
                txtMaSach.Clear();
                txtDonGia.Clear();
                nudSL.Minimum = 1;
                nudSL.Value = 1;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (s == null)
            {
                MessageBox.Show("Vui lòng chọn sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LayCTHD();
            if (CTHD.KiemTraTonTai(cthd))
            {
                if (!TangCTHD())
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cthd = null;
                    return;
                }
                ThanhTien += cthd.ThanhTien;
                txtThanhTien.Text = ThanhTien.ToString();
                LoadDSCTHD();
                LoadDSSP();
                s = null;
                HienThi();
                return;
            }
            if (ThemCTHD())
            {
                ThanhTien += cthd.ThanhTien;
                txtThanhTien.Text = ThanhTien.ToString();
                LoadDSCTHD();
                LoadDSSP();
                s = null;
                HienThi();
                return;
            }
            MessageBox.Show("Thêm chi tiết hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cthd = null;
        }

        private bool TangCTHD()
        {
            int kq = CTHD.Tang(cthd);
            return kq > 0;
        }

        private void LoadDSCTHD()
        {
            dsCTHD = CTHD.LayDSCTHD();
            dgvChiTietHoaDon.DataSource = dsCTHD;
            dgvChiTietHoaDon.ClearSelection();
        }

        private bool ThemCTHD()
        {
            int kq = CTHD.Them(cthd);
            return kq > 0;
        }

        private void LayCTHD()
        {
            cthd = new ChiTietHoaDonDTO();
            cthd.MaSach = txtMaSach.Text;
            cthd.TenSach = s.TenSach;
            cthd.SoLuong = int.Parse(nudSL.Value.ToString());
            cthd.DonGia = float.Parse(txtDonGia.Text);
            cthd.ThanhTien = cthd.SoLuong * cthd.DonGia;
        }

        private void dgvChiTietHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChiTietHoaDon.SelectedRows.Count > 0)
            {
                cthd = dgvChiTietHoaDon.SelectedRows[0].DataBoundItem as ChiTietHoaDonDTO;
            }
            else cthd = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cthd == null)
            {
                MessageBox.Show("Vui lòng chọn để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!XoaCTHD())
            {
                MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ThanhTien -= cthd.ThanhTien;
            txtThanhTien.Text = ThanhTien.ToString();
            LoadDSCTHD();
            LoadDSSP();

        }

        private bool XoaCTHD()
        {
            int kq = CTHD.Xoa(cthd);
            return kq > 0;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lvSach.SelectedIndices.Clear();
            txtTenSach.Clear();
            while (dgvChiTietHoaDon.Rows.Count > 0)
            {
                dgvChiTietHoaDon.Rows[0].Selected = true;
                cthd = dgvChiTietHoaDon.SelectedRows[0].DataBoundItem as ChiTietHoaDonDTO;
                btnXoa.PerformClick();
            }
            txtMaKH.Clear();
            rdMua.Checked = true;
            ThanhTien = 0;
            txtThanhTien.Clear();
            isLuu = false;
            LoadDSSP();
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            bool pass = false;
            if (rdMua.Checked && string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                txtMaKH.Text = "0";
                pass = true;
            }
            else if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KH.TonTaiKH(txtMaKH.Text) && !pass)
            {
                MessageBox.Show("Khách hàng không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvChiTietHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Xác nhận lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) {
                LayHD();
                cthd = new ChiTietHoaDonDTO();
                cthd.MaHD = ThemHD().ToString();
                if (cthd.MaHD == "0")
                {
                    MessageBox.Show("Thêm hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LayLHDHD();
                if(lhdhd.MaLHD == "1")
                {
                    if (!ThemLHDHDMua())
                    {
                        MessageBox.Show("Lưu hóa đơn MUA không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    txtMaKH.Clear();
                }
                else
                {
                    if(dtpHanTra.Value.Date <= dtpNgayMuon.Value)
                    {
                        MessageBox.Show("Hạn trả không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!THemLHDHDMuon())
                    {
                        MessageBox.Show("Lưu hóa đơn MƯỢN không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;     
                    }
                    txtMaKH.Clear();
                    dtpNgayLapHD.Value = DateTime.Now;
                    dtpNgayMuon.Value = DateTime.Now;
                    dtpHanTra.Value = DateTime.Now;
                }
                if (LuuCTHD())
                {
                    MessageBox.Show("Lưu chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ThanhTien = 0;
                    txtThanhTien.Clear();
                    LoadDSCTHD();
                    isLuu = true;
                    return;
                }
                MessageBox.Show("Lưu hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ThemLHDHDMua()
        {
            int kq = LHDHD.ThemMua(lhdhd);
            return kq > 0;
        }

        public bool THemLHDHDMuon()
        {
            int kq = LHDHD.ThemMuon(lhdhd);
            return kq > 0;
        }
        private void LayLHDHD()
        {
            lhdhd = new LHDHoaDonDTO();
            lhdhd.MaLHD = rdMua.Checked ? "1" : "2";
            lhdhd.MaHD = cthd.MaHD;
            lhdhd.NgayMuon = dtpNgayMuon.Value;
            lhdhd.HanTra = dtpHanTra.Value;
        }

        private int ThemHD()
        {
            int MaHD = HD.Them(hd);
            return MaHD;
        }

        private void LayHD()
        {
            hd = new HoaDonDTO();
            hd.MaKH = txtMaKH.Text;
            hd.MaNV = txtMaNV.Text;
            hd.NgayLap = DateTime.Parse(dtpNgayLapHD.Value.ToString());
            hd.TongTien = rdMua.Checked ? float.Parse(txtThanhTien.Text) : 0;
            hd.TrangThai = rdMua.Checked ? 1 : 0;
        }

        private bool LuuCTHD()
        {
            int kq = CTHD.Luu(cthd);
            return kq > 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lvSach.Clear();
            dsS = S.TimKiem(txtTenSach.Text);
            foreach (var sach in dsS)
            {
                ListViewItem item = new ListViewItem(sach.TenSach);
                item.SubItems.Add(sach.HinhAnh);
                item.SubItems.Add(sach.MaSach);
                item.SubItems.Add(sach.GiaBan.ToString());
                item.SubItems.Add(sach.SoLuong.ToString());
                Image image = Image.FromFile(@"..\..\..\..\HinhSach\" + sach.HinhAnh);
                imageList2.Images.Add(image);
                item.ImageIndex = imageList2.Images.Count - 1;
                lvSach.Items.Add(item);
            }
        }

        private void lvSach_DoubleClick(object sender, EventArgs e)
        {
            btnThem.PerformClick();
        }

        private void LapHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnLamMoi.PerformClick();
            ThanhTien = 0;
            txtThanhTien.Text = "";
            Close();
        }
        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (!isLuu)
            {
                MessageBox.Show("Hãy lưu hóa đơn để In!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string MaHD = HD.LayMaxMaHD();
            MessageBox.Show(HD.Xem(MaHD));
        }
    }
}
