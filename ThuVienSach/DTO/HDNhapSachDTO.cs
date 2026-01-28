using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HDNhapSachDTO
    {
        public string MaNS { get; set; }
        public string MaSach { get; set; }
        public string MaNCC { get; set; }
        public DateTime NgayLap { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float TongTien { get; set; }

    }
}
