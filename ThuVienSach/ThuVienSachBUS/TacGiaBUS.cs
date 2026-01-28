using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ThuVienSachDAO;

namespace ThuVienSachBUS
{
    public class TacGiaBUS
    {
        TacGiaDAO TG = new TacGiaDAO();
        public List<TacGiaDTO> LayDSTG()
        {
            return TG.LayDSTG();
        }
        public bool TxtError(string TenTG)
        {
            if (string.IsNullOrWhiteSpace(TenTG))
            {
                return true;
            }
            return false;
        }
        public int Them(TacGiaDTO Them)
        {
            return TG.ThemTG(Them);
        }
        public int Xoa(TacGiaDTO Xoa)
        {
            return TG.XoaTG(Xoa);
        }
        public int Sua(TacGiaDTO Sua)
        {
            return TG.SuaTG(Sua);
        }
        public List<TacGiaDTO> TimKiem(string Tim)
        {
            return TG.TimKiemTG(Tim);
        }
    }
}
