using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ThuVienSachDAO;

namespace ThuVienSachBUS
{
    public class NhanVienBUS
    {
        NhanVienDAO NV = new NhanVienDAO();
        public List<NhanVienDTO> LayDSNV()
        {
            return NV.LayDSNV();
        }
        public bool TxtError(string MaCV, string TenNV, string DChi, string SDT, string Luong, string UserName, string Password)
        {
            if (string.IsNullOrWhiteSpace(MaCV) || string.IsNullOrWhiteSpace(TenNV) || string.IsNullOrWhiteSpace(DChi) || string.IsNullOrWhiteSpace(SDT) || string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {
                return true;
            }
            return false;
        }
        public int Them(NhanVienDTO Them)
        {
            return NV.ThemNV(Them);
        }
        public int Xoa(NhanVienDTO Xoa)
        {
            return NV.XoaNV(Xoa);
        }
        public int Sua(NhanVienDTO Sua)
        {
            return NV.SuaNV(Sua);
        }
        public bool KiemTraSDT(NhanVienDTO KiemTra)
        {
            return NV.KiemTraSDT(KiemTra);
        }
        public bool KiemTraUser(NhanVienDTO KiemTra)
        {
            return NV.KiemTraUser(KiemTra);
        }
        public List<NhanVienDTO> TimKiem(string Ten,string DiaChi,string SDT,string Username)
        {
            return NV.TimKiemNV(Ten,DiaChi,SDT,Username);
        }
        public Dictionary<string,string> LayTTDN()
        {
            return NV.LayTTDN();
        }
        public bool KiemTraDN(string tk,string mk)
        {
            if (LayTTDN().ContainsKey(tk) && LayTTDN()[tk] == mk)
            {
                return true;
            }
            return false;
        }
        public int LayTTCV(string TK)
        {
            return NV.LayTTCV(TK);
        }
        public string LayMaNVDN()
        {
            return DataProvider.MaNV;
        }
        public string LayTenNVDN()
        {
            return DataProvider.TenNV;
        }

        public bool TonTaiNV(string MaNV)
        {
            return NV.TonTaiNV(MaNV);
        }
    }
}
