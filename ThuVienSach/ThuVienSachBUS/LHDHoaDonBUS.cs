using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ThuVienSachDAO;

namespace ThuVienSachBUS
{
    public class LHDHoaDonBUS
    {
        LHDHoaDonDAO LHDHD = new LHDHoaDonDAO();
        public List<LHDHoaDonDTO> LayDSLHDHD(int TrangThai)
        {
            return LHDHD.LayDSLHDHD(TrangThai);
        }
        public int ThemMua(LHDHoaDonDTO Them)
        {
            return LHDHD.ThemLHDHDMua(Them);
        }

        public int ThemMuon(LHDHoaDonDTO Them)
        {
            return LHDHD.ThemLHDHDMuon(Them);
        }
        public int CapNhat(LHDHoaDonDTO CapNhat)
        {
            return LHDHD.CapNhatLHDHD(CapNhat);
        }
        public int TraSach(LHDHoaDonDTO TraSach)
        {
            return LHDHD.TraSach(TraSach);
        }
        public List<LHDHoaDonDTO> TimKiem(string MaKH,int TrangThai,string MaHD)
        {
            return LHDHD.TimKiem(MaKH,TrangThai,MaHD);
        }
    }
}
