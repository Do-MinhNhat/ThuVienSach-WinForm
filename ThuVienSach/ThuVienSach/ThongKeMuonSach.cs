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
    public partial class ThongKeMuonSach : Form
    {
        public ThongKeMuonSach()
        {
            InitializeComponent();
        }

        private void ThongKeMuonTra_Load(object sender, EventArgs e)
        {
            LHDHoaDonBUS lhdBus = new LHDHoaDonBUS();
            List<LHDHoaDonDTO> dsLHD = lhdBus.LayDSLHDHD(TrangThai:1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThuVienSach.ThongKeMuonSach.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("TKMS", dsLHD));
            this.reportViewer1.RefreshReport();
        }
    }
}
