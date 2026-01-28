using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ThuVienSachDAO;

namespace ThuVienSachBUS
{
    public class HoaDonBUS
    {
        HoaDonDAO HD = new HoaDonDAO();
        public List<HoaDonDTO> LayDSHD(int MaLHD)
        {
            return HD.LayDSHD(MaLHD);
        }

        public bool TxtError(string MaNV,string MaKH)
        {
            if(string.IsNullOrWhiteSpace(MaKH) || string.IsNullOrWhiteSpace(MaNV))
            {
                return true;
            }
            return false;
        }
        public int Them(HoaDonDTO Them)
        {
            return HD.ThemHD(Them);
        }
        public int Xoa(HoaDonDTO Xoa)
        {
            return HD.XoaHD(Xoa);
        }
        public int Sua(HoaDonDTO Sua)
        {
            return HD.SuaHD(Sua);
        }
        public string Xem(string MaHD)
        {
            return HD.XemChiTietHD(MaHD);
        }
        public List<HoaDonDTO> Tim(string MaHD,string MaNV,string MaKH,int MaLHD)
        {
            return HD.TimHD(MaHD,MaNV,MaKH,MaLHD);
        }
        public void CapNhat(string MaHD,float Money)
        {
            HD.CapNhatHD(MaHD,Money);
        }

        public string LayMaxMaHD()
        {
            return HD.LayMaxMaHD();
        }
    }
}
