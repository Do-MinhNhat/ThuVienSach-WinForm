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
    public partial class ThongKeNhanVien : Form
    {
        public ThongKeNhanVien()
        {
            InitializeComponent();
        }

        private void ThongKeNhanVien_Load(object sender, EventArgs e)
        {
            NhanVienBUS nvBus = new NhanVienBUS();
            List<NhanVienDTO> dsNV = nvBus.LayDSNV();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThuVienSach.ThongKeNhanVien.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("TKNV", dsNV));
            this.reportViewer1.RefreshReport();
        }
    }
}
