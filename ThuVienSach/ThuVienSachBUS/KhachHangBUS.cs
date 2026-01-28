using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ThuVienSachDAO;

namespace ThuVienSachBUS
{
    public class KhachHangBUS
    {
        KhachHangDAO KH = new KhachHangDAO();
        public List<KhachHangDTO> LayDSKH()
        {
            return KH.LayDSKH();
        }
        public bool TxtError(string HoTen, string DiaChi, string Email, string SDT)
        {
            if(string.IsNullOrWhiteSpace(HoTen) || string.IsNullOrWhiteSpace(DiaChi) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(SDT))
            {
                return true;
            }
            return false;
        }
        public int Them(KhachHangDTO Them)
        {
            return KH.ThemKH(Them);
        }
        public int Xoa(KhachHangDTO Xoa)
        {
            return KH.XoaKH(Xoa);
        }
        public int Sua(KhachHangDTO Sua)
        {
            return KH.SuaKH(Sua);
        }
        public bool KiemTra(KhachHangDTO KiemTra)
        {
            return KH.KiemTraSDT(KiemTra);
        }
        public List<KhachHangDTO> TimKiem(string Ten,string DiaChi,string email,string sdt)
        {
            return KH.TimKiemKH(Ten,DiaChi,email,sdt);
        }
        public bool KiemTraEmail(string Email)
        {
            if(!Email.Contains("@") || !Email.Contains("."))
            {
                return false;
            }
            return true;
        }

        public bool TonTaiKH(string MaKH)
        {
            return KH.TonTaiKH(MaKH);
        }
    }
}
