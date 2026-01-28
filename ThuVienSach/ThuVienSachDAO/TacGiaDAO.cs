using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ThuVienSachDAO
{
    public class TacGiaDAO
    {
        List<TacGiaDTO> dsTG;
        SqlConnection conn;
        SqlDataReader dr;
        TacGiaDTO tg;
        public List<TacGiaDTO> LayDSTG()
        {
            dsTG = new List<TacGiaDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = "select * from TacGia where TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                tg = new TacGiaDTO();
                tg.MaTG = dr["MaTG"].ToString();
                tg.TenTG = dr["TenTG"].ToString();
                dsTG.Add(tg);
            }
            dr.Close();
            conn.Close();
            return dsTG;
        }
        public int ThemTG(TacGiaDTO tg)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string them = $"insert into TacGia values(N'{tg.TenTG}',1)";
            int kq = DataProvider.Execute(them, conn);
            conn.Close();
            return kq;
        }
        public int XoaTG(TacGiaDTO tg)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string xoa = $"update TacGia set TrangThai = 0 where MaTG = '{tg.MaTG}'";
            string xoaSach = $"update Sach set TrangThai = 0 where MaTG = '{tg.MaTG}'";
            DataProvider.Execute(xoaSach, conn);
            int kq = DataProvider.Execute(xoa, conn);
            conn.Close();
            return kq;
        }
        public int SuaTG(TacGiaDTO tg)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string sua = $"update TacGia set TenTG = N'{tg.TenTG}' where MaTG = '{tg.MaTG}'";
            int kq = DataProvider.Execute(sua, conn);
            conn.Close();
            return kq;
        }
        public List<TacGiaDTO> TimKiemTG(string TenTG)
        {
            dsTG = new List<TacGiaDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string tim = $"select * from TacGia where TenTG like N'%{TenTG}%' and TrangThai = 1";
            dr = DataProvider.Read(tim, conn);
            while (dr.Read())
            {
                tg = new TacGiaDTO();
                tg.MaTG = dr["MaTG"].ToString();
                tg.TenTG = dr["TenTG"].ToString();
                dsTG.Add(tg);
            }
            dr.Close();
            conn.Close();
            return dsTG;
        }
    }
}
