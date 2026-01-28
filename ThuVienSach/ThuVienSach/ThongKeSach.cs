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
    public partial class ThongKeSach : Form
    {
        public ThongKeSach()
        {
            InitializeComponent();
        }

        private void ThongKeSach_Load(object sender, EventArgs e)
        {

            SachBUS sachBus = new SachBUS();
            List<SachDTO> dsSach = sachBus.LayDSS();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThuVienSach.ThongKeSach.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("TKS", dsSach));
            this.reportViewer1.RefreshReport();
        }
    }
}
