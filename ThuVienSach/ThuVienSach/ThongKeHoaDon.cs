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
    public partial class ThongKeHoaDon : Form
    {
        public ThongKeHoaDon()
        {
            InitializeComponent();
        }

        private void ThongKeHoaDon_Load(object sender, EventArgs e)
        {
            HoaDonBUS hdBus = new HoaDonBUS();
            List<HoaDonDTO> dsHD = hdBus.LayDSHD(MaLHD:1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThuVienSach.ThongKeHoaDon.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("TKHD", dsHD));
            this.reportViewer1.RefreshReport();
        }
    }
}
