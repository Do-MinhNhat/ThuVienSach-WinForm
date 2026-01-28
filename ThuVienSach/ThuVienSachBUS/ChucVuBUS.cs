using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ThuVienSachDAO;

namespace ThuVienSachBUS
{
    public class ChucVuBUS
    {
        ChucVuDAO CV = new ChucVuDAO();
        public List<ChucVuDTO> LayDSCV()
        {
            return CV.LayDSCV();
        }
        public bool TxtError(string TenCV)
        {
            if(string.IsNullOrWhiteSpace(TenCV))
            {
                return true;
            }
            return false;
        }
        public int Them(ChucVuDTO Them)
        {
            return CV.ThemCV(Them);
        }
        public int Xoa(ChucVuDTO Xoa)
        {
            return CV.XoaCV(Xoa);
        }
        public int Sua(ChucVuDTO Sua)
        {
            return CV.SuaCV(Sua);
        }
        public List<ChucVuDTO> TimKiem(string TimKiem)
        {
            return CV.TimKiemCV(TimKiem);
        }
    }
}
