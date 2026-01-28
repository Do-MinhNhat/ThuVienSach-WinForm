using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string MaCV {  get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public string DChi { get; set; }
        public string SDT {  get; set; }
        public bool TrangThai { get; set; }
        public DateTime NgaySinh { get; set; }
        public float Luong {  get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}
