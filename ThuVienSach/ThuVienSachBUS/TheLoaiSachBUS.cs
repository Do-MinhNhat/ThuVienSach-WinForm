using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ThuVienSachDAO;

namespace ThuVienSachBUS
{
    public class TheLoaiSachBUS
    {
        TheLoaiSachDAO TLS = new TheLoaiSachDAO();
        public List<TheLoaiSachDTO> LayDSTLS()
        {
            return TLS.LayDSTLS();
        }
        public bool TxtError(string TenTL)
        {
            if (string.IsNullOrWhiteSpace(TenTL))
            {
                return true;
            }
            return false;
        }
        public int Them(TheLoaiSachDTO Them)
        {
            return TLS.ThemTLS(Them);
        }
        public int Xoa(TheLoaiSachDTO Xoa)
        {
            return TLS.XoaTLS(Xoa);
        }
        public int Sua(TheLoaiSachDTO Sua)
        {
            return TLS.SuaTLS(Sua);
        }
        public List<TheLoaiSachDTO> TimKiem(string Tim)
        {
            return TLS.TimKiemTLS(Tim);
        }
    }
}
