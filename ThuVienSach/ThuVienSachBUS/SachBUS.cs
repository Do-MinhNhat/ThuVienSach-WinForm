using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ThuVienSachDAO;

namespace ThuVienSachBUS
{
    public class SachBUS
    {
        SachDAO S = new SachDAO();
        public List<SachDTO> LayDSS()
        {
            return S.LayDSS();
        }
        public bool TxtError(string TenSach, string NhaXB, string GiaBan, string SoLuong, string MoTa,string FileName)
        {
            if (string.IsNullOrWhiteSpace(TenSach) || string.IsNullOrWhiteSpace(NhaXB) || string.IsNullOrWhiteSpace(GiaBan) || string.IsNullOrWhiteSpace(SoLuong) || string.IsNullOrWhiteSpace(MoTa) || string.IsNullOrWhiteSpace(FileName))
                return true;
            return false;
        }
        public int Them(SachDTO Them)
        {
            return S.ThemS(Them);
        }
        public int Xoa(SachDTO Xoa)
        {
            return S.XoaS(Xoa);
        }
        public int Sua(SachDTO Sua)
        {
            return S.SuaS(Sua);
        }
        public List<SachDTO> TimKiem(string TimKiem)
        {
            return S.TimKiemS(TimKiem);
        }
        public bool KiemTra(SachDTO KiemTra)
        {
            return S.KiemTraS(KiemTra);
        }

        public string LayMaSachMAX()
        {
            return S.LayMaSachMAX();
        }
    }
}
