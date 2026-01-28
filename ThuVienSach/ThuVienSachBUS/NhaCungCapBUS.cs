using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVienSachDAO;

namespace ThuVienSachBUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAO NCC = new NhaCungCapDAO();
        public List<NhaCungCapDTO> LayDSNCC()
        {
            return NCC.LayDSNCC();
        }
        public bool TxtError(string TenNcc, string DChi, string SDT)
        {
            if (string.IsNullOrWhiteSpace(TenNcc) || string.IsNullOrWhiteSpace(DChi) || string.IsNullOrWhiteSpace(SDT))
            {
                return true;
            }
            return false;
        }
        public int Them(NhaCungCapDTO Them)
        {
            return NCC.ThemNCC(Them);
        }
        public int Xoa(NhaCungCapDTO Xoa)
        {
            return NCC.XoaNCC(Xoa);
        }
        public int Sua(NhaCungCapDTO Sua)
        {
            return NCC.SuaNCC(Sua);
        }
        public bool KiemTra(NhaCungCapDTO KiemTra)
        {
            return NCC.KiemTraSDT(KiemTra);

        }
        public List<NhaCungCapDTO> TimKiem(string TenNCC,string DiaChi,string SDT)
        {
            return NCC.TimKiemNCC(TenNCC,DiaChi,SDT);
        }
    }
}