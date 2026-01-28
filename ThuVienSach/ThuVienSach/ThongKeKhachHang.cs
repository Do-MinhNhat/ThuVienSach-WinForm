using DTO;
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

namespace ThuVienSach
{
    public partial class ThongKeKhachHang : Form
    {
        public ThongKeKhachHang()
        {
            InitializeComponent();
        }
        private void ThongKeKhachHang_Load(object sender, EventArgs e)
        {
            KhachHangBUS khBus = new KhachHangBUS();
            List<KhachHangDTO> dsKH = khBus.LayDSKH();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThuVienSach.ThongKeKhachHang.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ThongKeKhachHang", dsKH));
            this.reportViewer1.RefreshReport();
        }
    }
}
