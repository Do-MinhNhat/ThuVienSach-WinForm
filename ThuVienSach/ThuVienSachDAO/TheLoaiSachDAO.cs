using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ThuVienSachDAO
{
    public class TheLoaiSachDAO
    {
        List<TheLoaiSachDTO> dsTLS;
        SqlConnection conn;
        SqlDataReader dr;
        TheLoaiSachDTO tls;
        public List<TheLoaiSachDTO> LayDSTLS()
        {
            dsTLS = new List<TheLoaiSachDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = "select * from TheLoaiSach where TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                tls = new TheLoaiSachDTO();
                tls.MaTL = dr["MaTL"].ToString();
                tls.TenTL = dr["TenTL"].ToString();
                dsTLS.Add(tls);
            }
            dr.Close();
            conn.Close();
            return dsTLS;
        }
        public int ThemTLS(TheLoaiSachDTO tls)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string them = $"insert into TheLoaiSach values(N'{tls.TenTL}',1)";
            int kq = DataProvider.Execute(them, conn);
            conn.Close();
            return kq;
        }
        public int XoaTLS(TheLoaiSachDTO tls)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string xoa = $"update TheLoaiSach set TrangThai = 0 where MaTL = '{tls.MaTL}'";
            string xoaSach = $"update Sach set TrangThai = 0 where MaTL = '{tls.MaTL}'";
            DataProvider.Execute(xoaSach, conn);
            int kq = DataProvider.Execute(xoa, conn);
            conn.Close();
            return kq;
        }
        public int SuaTLS(TheLoaiSachDTO tls)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string sua = $"update TheLoaiSach set TenTL = N'{tls.TenTL}' where MaTL = '{tls.MaTL}'";
            int kq = DataProvider.Execute(sua,conn);
            conn.Close();
            return kq;
        }
        public List<TheLoaiSachDTO> TimKiemTLS(string TenTL)
        {
            dsTLS = new List<TheLoaiSachDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string tim = $"select * from TheLoaiSach where TenTL like N'%{TenTL}%' and TrangThai = 1";
            dr = DataProvider.Read(tim,conn);
            while (dr.Read())
            {
                tls = new TheLoaiSachDTO();
                tls.MaTL = dr["MaTL"].ToString();
                tls.TenTL = dr["TenTL"].ToString();
                dsTLS.Add(tls);
            }
            dr.Close();
            conn.Close();
            return dsTLS;
        }
    }
}
