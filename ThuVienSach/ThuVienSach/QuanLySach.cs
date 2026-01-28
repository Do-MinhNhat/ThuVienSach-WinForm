using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DTO;
using ThuVienSachBUS;

namespace ThuVienSach
{
    public partial class QuanLySach : Form
    {
        public QuanLySach()
        {
            InitializeComponent();
        }
        SachBUS S = new SachBUS();
        List<SachDTO> dsS;
        SachDTO s;

        TacGiaBUS TG = new TacGiaBUS();
        List<TacGiaDTO> dsTG;

        TheLoaiSachBUS TLS = new TheLoaiSachBUS();
        List<TheLoaiSachDTO> dsTLS;

        NhaCungCapBUS NCC = new NhaCungCapBUS();
        List<NhaCungCapDTO> dsNCC;

        HDNhapSachBUS HDNS = new HDNhapSachBUS();
        HDNhapSachDTO hdns;

        OpenFileDialog ofd = new OpenFileDialog();

        string HinhSach = @"..\..\..\..\HinhSach\";

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            LoadDSNCC();
            LoadDSTG();
            LoadDSTL();
            dgvSach.AutoGenerateColumns = false;
            LoadDSS();
        }

        private void LoadDSNCC()
        {
            dsNCC = NCC.LayDSNCC();
            cbNhaCungCap.DataSource = dsNCC;
            cbNhaCungCap.ValueMember = "MaNCC";
            cbNhaCungCap.DisplayMember = "TenNCC";

            colNCC.DataSource = dsNCC;
            colNCC.ValueMember = "MaNCC";
            colNCC.DisplayMember = "TenNCC";
        }

        private void LoadDSTL()
        {
            dsTLS = TLS.LayDSTLS();
            cbTheLoai.DataSource = dsTLS;
            cbTheLoai.ValueMember = "MaTL";
            cbTheLoai.DisplayMember = "TenTL";

            colMaTheLoai.DataSource = dsTLS;
            colMaTheLoai.ValueMember = "MaTL";
            colMaTheLoai.DisplayMember = "TenTL";
        }

        private void LoadDSTG()
        {
            dsTG = TG.LayDSTG();
            cbTacGia.DataSource = dsTG;
            cbTacGia.ValueMember = "MaTG";
            cbTacGia.DisplayMember = "TenTG";

            colMaTacGia.DataSource = dsTG;
            colMaTacGia.ValueMember = "MaTG";
            colMaTacGia.DisplayMember = "TenTG";

        }

        private void LoadDSS()
        {
            dsS = S.LayDSS();
            dgvSach.DataSource = dsS;
            dgvSach.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckTxt())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LayS();
            if (S.KiemTra(s))
            {
                MessageBox.Show("Sách đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!LuuHinhAnh(false))
            {
                MessageBox.Show("Lưu hình ảnh thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Nhập thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (ThemS())
            {
                LayHDNS();
                hdns.MaSach = S.LayMaSachMAX();
                hdns.SoLuong = int.Parse(txtSoLuong.Text);
                hdns.TongTien = hdns.SoLuong * hdns.DonGia;
                if (!ThemHDNS())
                {
                    MessageBox.Show("Lỗi Database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hdns = null;
                    return;
                }
                MessageBox.Show($"Thêm sách: '{s.TenSach}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSS();
                return;
            }
            MessageBox.Show("Thêm sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            s = null;
        }

        private bool LuuHinhAnh(bool GhiDe)
        {
            if (!Directory.Exists(HinhSach))
            {
                Directory.CreateDirectory(HinhSach);
            }
            try
            {
                string ThuMucLuu = Path.Combine(HinhSach, Path.GetFileName(ofd.FileName));
                if (File.Exists(ThuMucLuu) && !GhiDe)
                {
                    DialogResult dr = MessageBox.Show("Hình ảnh đã tồn tại!\nBạn có muốn ghi đè?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        GhiDe = true;
                    }
                    else
                    {
                        return false;
                    }
                }
                File.Copy(ofd.FileName, ThuMucLuu, GhiDe);
                return true;
            }
            catch (IOException ex)
            {
                return false;
            }
        }

        private bool ThemS()
        {
            int kq = S.Them(s);
            return kq > 0;
        }

        private void LayS()
        {
            s = new SachDTO();
            s.MaSach = txtMaSach.Text;
            s.TenSach = txtTenSach.Text;
            s.MaTL = cbTheLoai.SelectedValue.ToString();
            s.MaTG = cbTacGia.SelectedValue.ToString();
            s.MaNCC = cbNhaCungCap.SelectedValue.ToString();
            s.NhaXB = txtNhaXuatBan.Text;
            s.GiaNhap = float.Parse(txtGiaNhap.Text);
            s.SoLuong = int.Parse(txtSoLuong.Text);
            s.MoTa = txtMoTa.Text;
            s.HinhAnh = Path.GetFileName(ofd.FileName);
        }

        private bool CheckTxt()
        {
            if (S.TxtError(txtTenSach.Text, txtNhaXuatBan.Text, txtGiaNhap.Text, txtSoLuong.Text, txtMoTa.Text, ofd.FileName))
            {
                return false;
            }
            return true;
        }

        private void pbHinhAnh_Click(object sender, EventArgs e)
        {
            ofd.Title = "Chọn ảnh";
            ofd.Filter = "Ảnh (*.png;*.jpg)|*.png;*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbHinhAnh.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void dgvSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSach.SelectedRows.Count > 0)
            {
                s = dgvSach.SelectedRows[0].DataBoundItem as SachDTO;
                ofd.FileName = s.HinhAnh;
            }
            else
            {
                s = null;
            }
            HienThi();
        }

        private void HienThi()
        {
            if(s != null)
            {
                txtMaSach.Text = s.MaSach;
                txtTenSach.Text = s.TenSach;
                cbTheLoai.SelectedValue = s.MaTL;
                cbTacGia.SelectedValue = s.MaTG;
                cbNhaCungCap.SelectedValue = s.MaNCC;
                txtNhaXuatBan.Text = s.NhaXB;
                txtGiaNhap.Text = s.GiaNhap.ToString();
                txtSoLuong.Text = s.SoLuong.ToString();
                txtMoTa.Text = s.MoTa;
                string HinhAnh = Path.Combine(HinhSach, s.HinhAnh);
                pbHinhAnh.Image = Image.FromFile(HinhAnh);
            }
            else
            {
                txtMaSach.Clear();
                txtTenSach.Clear();
                cbTheLoai.SelectedIndex = 0;
                cbTacGia.SelectedIndex = 0;
                cbNhaCungCap.SelectedIndex = 0;
                txtNhaXuatBan.Clear();
                txtGiaNhap.Clear();
                txtSoLuong.Clear();
                txtMoTa.Clear();
                pbHinhAnh.Image = null;
                ofd.FileName = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(s == null)
            {
                MessageBox.Show("Vui lòng chọn để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!CheckTxt())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!File.Exists(HinhSach + Path.GetFileName(ofd.FileName)))
            {
                LuuHinhAnh(false);
            }
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if(s.SoLuong < int.Parse(txtSoLuong.Text))
                {
                    LayHDNS();
                    if (!ThemHDNS())
                    {
                        MessageBox.Show("Lỗi Database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hdns = null;
                        return;
                    }
                    MessageBox.Show("Nhập thêm sách thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                LayS();
                if (SuaS())
                {
                    MessageBox.Show($"Đã sửa sách số: '{s.MaSach}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSS();
                    return;
                }
                MessageBox.Show("Sửa sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                s = null;
            }
        }

        private bool ThemHDNS()
        {
            int kq = HDNS.NhapSach(hdns);
            return kq > 0;
        }

        private void LayHDNS()
        {
            hdns = new HDNhapSachDTO();
            hdns.MaSach = txtMaSach.Text;
            hdns.MaNCC = cbNhaCungCap.SelectedValue.ToString();
            hdns.SoLuong = int.Parse(txtSoLuong.Text) - s.SoLuong;
            hdns.NgayLap = DateTime.Now;
            hdns.DonGia = float.Parse(txtGiaNhap.Text);
            hdns.TongTien = hdns.SoLuong * hdns.DonGia;
        }

        private bool SuaS()
        {
            int kq = S.Sua(s);
            return kq > 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(s == null)
            {
                MessageBox.Show("Vui lòng chọn để xóa!","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (XoaS())
                {
                    MessageBox.Show($"Đã xóa sách: '{s.TenSach}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSS();
                    return;
                }
                MessageBox.Show("Xóa sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool XoaS()
        {
            int kq = S.Xoa(s);
            return kq > 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dsS = S.TimKiem(txtTenSach.Text);
            dgvSach.DataSource = dsS;
            dgvSach.ClearSelection();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDSS();
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            QuanLyTheLoaiSach quanLyTheLoaiSach = new QuanLyTheLoaiSach();
            quanLyTheLoaiSach.ShowDialog();
            LoadDSS();
            LoadDSTL();
            cbTheLoai.SelectedIndex = cbTheLoai.Items.Count - 1;
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            QuanLyTacGia quanLyTacGia = new QuanLyTacGia();
            quanLyTacGia.ShowDialog();
            LoadDSS();
            LoadDSTG();
            cbTacGia.SelectedIndex = cbTacGia.Items.Count - 1; 
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            QuanLyNhaCungCap quanLyNhaCungCap = new QuanLyNhaCungCap();
            quanLyNhaCungCap.ShowDialog();
            LoadDSS();
            LoadDSNCC();
            cbNhaCungCap.SelectedIndex = cbNhaCungCap.Items.Count - 1;
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
