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
using Microsoft.Reporting.WinForms;
using ThuVienSachBUS;

namespace ThuVienSach
{
    public partial class ThongKeNhapSach : Form
    {
        public ThongKeNhapSach()
        {
            InitializeComponent();
        }

        private void ThongKeNhapSach_Load(object sender, EventArgs e)
        {
            HDNhapSachBUS nsBus = new HDNhapSachBUS();
            List<HDNhapSachDTO> dsNS = nsBus.LayDSHDNS();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThuVienSach.ThongKeNhapSach.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("TKNS", dsNS));
            this.reportViewer1.RefreshReport();
        }
    }
}
