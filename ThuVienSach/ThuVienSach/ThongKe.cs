using Microsoft.Reporting.WinForms;
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
using DTO;
namespace ThuVienSach
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(radThongKeKhachHang.Checked)
            {
                ThongKeKhachHang tkkh = new ThongKeKhachHang();
                tkkh.ShowDialog();
            }
            else if(radThongKeNhanVien.Checked)
            {
                ThongKeNhanVien tknv = new ThongKeNhanVien();
                tknv.ShowDialog();
            }
            else if(radHoaDonBan.Checked) 
            {
                ThongKeHoaDon tkhd = new ThongKeHoaDon();
                tkhd.ShowDialog();
            }
            else if(radThongKeSach.Checked)
            {
                ThongKeSach tks = new ThongKeSach();
                tks.ShowDialog();
            }
            else if(radThongKeMuonSach.Checked) 
            {
                ThongKeMuonSach tkmt = new ThongKeMuonSach();
                tkmt.ShowDialog();
            }
            else if (radThongKeNhapSach.Checked)
            {
                ThongKeNhapSach tkns = new ThongKeNhapSach();
                tkns.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục để thống kê", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
