using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ThuVienSachDAO
{
    public class SachDAO
    {
        List<SachDTO> dsS;
        SqlConnection conn;
        SqlDataReader dr;
        SachDTO s;
        public List<SachDTO> LayDSS()
        {
            dsS = new List<SachDTO> ();
            conn = DataProvider.Connect();
            conn.Open();
            string select = "select * from Sach where TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                s = new SachDTO();
                s.MaSach = dr["MaSach"].ToString();
                s.TenSach = dr["TenSach"].ToString();
                s.MaTL = dr["MaTL"].ToString();
                s.MaTG = dr["MaTG"].ToString();
                s.MaNCC = dr["MaNCC"].ToString();
                s.NhaXB = dr["NhaXB"].ToString();
                s.GiaNhap = float.Parse(dr["GiaNhap"].ToString());
                s.GiaBan = (float)(s.GiaNhap * 1.1);
                s.SoLuong = int.Parse(dr["SoLuong"].ToString());
                s.MoTa = dr["MoTa"].ToString();
                s.HinhAnh = dr["HinhAnh"].ToString();
                dsS.Add(s);
            }
            dr.Close();
            conn.Close();
            return dsS;
        }
        public int ThemS(SachDTO s)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string them = $"insert into Sach values(N'{s.TenSach}','{s.MaTL}','{s.MaTG}','{s.MaNCC}',N'{s.NhaXB}','{s.GiaNhap}','{s.SoLuong}',N'{s.MoTa}','{s.HinhAnh}',1)";
            int kq = DataProvider.Execute(them, conn);
            conn.Close();
            return kq;
        }
        public int XoaS(SachDTO s)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string xoa = $"update Sach set TrangThai = 0 where MaSach = '{s.MaSach}'";
            int kq = DataProvider.Execute(xoa, conn);
            conn.Close();
            return kq;
        }
        public int SuaS(SachDTO s)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string sua = $"update Sach set TenSach = N'{s.TenSach}',MaTL = '{s.MaTL}',MaTG = '{s.MaTG}',MaNCC = '{s.MaNCC}',NhaXB = N'{s.NhaXB}',GiaNhap = '{s.GiaNhap}',SoLuong = '{s.SoLuong}',MoTa = N'{s.MoTa}',HinhAnh = '{s.HinhAnh}' where MaSach = '{s.MaSach}'";
            int kq = DataProvider.Execute(sua, conn);
            conn.Close();
            return kq;
        }

        public bool KiemTraS(SachDTO s)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string kiem = $"Select * from Sach where TenSach = N'{s.TenSach}' and TrangThai = 1";
            dr = DataProvider.Read(kiem, conn);
            bool kq = dr.HasRows;
            dr.Close();
            conn.Close();
            return kq;
        }
        public List<SachDTO> TimKiemS(string TenS)
        {
            dsS = new List<SachDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = $"select * from Sach where TenSach like N'%{TenS}%' and TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                s = new SachDTO();
                s.MaSach = dr["MaSach"].ToString();
                s.TenSach = dr["TenSach"].ToString();
                s.MaTL = dr["MaTL"].ToString();
                s.MaTG = dr["MaTG"].ToString();
                s.MaNCC = dr["MaNCC"].ToString();
                s.NhaXB = dr["NhaXB"].ToString();
                s.GiaNhap = float.Parse(dr["GiaNhap"].ToString());
                s.GiaBan = (float)(s.GiaNhap * 1.1);
                s.SoLuong = int.Parse(dr["SoLuong"].ToString());
                s.MoTa = dr["MoTa"].ToString();
                s.HinhAnh = dr["HinhAnh"].ToString();
                dsS.Add(s);
            }
            dr.Close();
            conn.Close();
            return dsS;
        }

        public string LayMaSachMAX()
        {
            string kq = "";
            conn = DataProvider.Connect();
            conn.Open();
            string select = "select MAX(MaSach) as MaSach from Sach where TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                kq = dr["MaSach"].ToString();
            }
            dr.Close();
            conn.Close();
            return kq;
        }
    }
}
