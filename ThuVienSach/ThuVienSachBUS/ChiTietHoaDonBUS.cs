using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ThuVienSachDAO;

namespace ThuVienSachBUS
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAO CTHD = new ChiTietHoaDonDAO();
        public List<ChiTietHoaDonDTO> LayDSCTHD()
        {
            return CTHD.LayDSCTHD();
        }
        public int Them(ChiTietHoaDonDTO Them)
        {
            return CTHD.ThemCTHD(Them);
        }
        public int Xoa(ChiTietHoaDonDTO Xoa)
        {
            return CTHD.XoaCTHD(Xoa);
        }
        public int Luu(ChiTietHoaDonDTO Luu)
        {
            return CTHD.LuuCTHD(Luu);
        }
        public bool KiemTraTonTai(ChiTietHoaDonDTO KiemTra)
        {
            return CTHD.KiemTraTonTai(KiemTra);
        }
        public int Tang(ChiTietHoaDonDTO Tang)
        {
            return CTHD.TangCTHD(Tang);
        }
        public List<ChiTietHoaDonDTO> Tim(string MaHD)
        {
            return CTHD.TimCTHD(MaHD);
        }
    }
}
