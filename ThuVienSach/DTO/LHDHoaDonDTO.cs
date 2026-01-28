using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LHDHoaDonDTO
    {
        public string MaLHD {  get; set; }
        public string MaHD {  get; set; }
        public string MaKH {  get; set; }
        public DateTime NgayMuon {  get; set; }
        public DateTime HanTra {  get; set; }
        public DateTime NgayTra {  get; set; }
        public float PhiTraMuon { get; set; }
        public int TrangThai { get; set; }
    }
}
