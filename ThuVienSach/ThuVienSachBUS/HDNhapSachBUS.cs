using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ThuVienSachDAO;

namespace ThuVienSachBUS
{
    public class HDNhapSachBUS
    {
        HDNhapSachDAO HDNS = new HDNhapSachDAO();
        public List<HDNhapSachDTO> LayDSHDNS()
        {
            return HDNS.LayDSHDNS();
        }
        public int NhapSach(HDNhapSachDTO NhapSach)
        {
            return HDNS.ThemHDNS(NhapSach);
        }
    }
}
