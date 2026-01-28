using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public int TrangThai { get; set; }
        public DateTime NgayLapThe { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
    }
}
