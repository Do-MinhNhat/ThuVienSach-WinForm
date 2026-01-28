using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ThuVienSachDAO
{
    public class ChucVuDAO
    {
        List<ChucVuDTO> dsCV;
        SqlConnection conn;
        SqlDataReader dr;
        ChucVuDTO cv;
        public List<ChucVuDTO> LayDSCV()
        {
            dsCV = new List<ChucVuDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = "select * from ChucVu where TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                cv = new ChucVuDTO();
                cv.MaCV = dr["MaCV"].ToString();
                cv.TenCV = dr["TenCV"].ToString();
                dsCV.Add(cv);
            }
            dr.Close();
            conn.Close();
            return dsCV;
        }
        public int ThemCV(ChucVuDTO cv)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string them = $"insert into ChucVu values(N'{cv.TenCV}',1)";
            int kq = DataProvider.Execute(them, conn);
            conn.Close();
            return kq;
        }
        public int XoaCV(ChucVuDTO cv)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string xoa = $"update ChucVu set TrangThai = 0 where MaCV = '{cv.MaCV}'";
            string xoaNV = $"update NhanVien set TrangThai = 0 where MaCV = '{cv.MaCV}'";
            DataProvider.Execute(xoaNV, conn);
            int kq = DataProvider.Execute(xoa, conn);
            conn.Close();
            return kq;
        }
        public int SuaCV(ChucVuDTO cv)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string sua = $"update ChucVu set TenCV = N'{cv.TenCV}' where MaCV = '{cv.MaCV}'";
            int kq = DataProvider.Execute(sua, conn);
            conn.Close();
            return kq;
        }
        public List<ChucVuDTO> TimKiemCV(string TenCV)
        {
            dsCV = new List<ChucVuDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string tim = $"select * from ChucVu where TenCV like N'%{TenCV}%' and TrangThai = 1";
            dr = DataProvider.Read(tim, conn);
            while (dr.Read())
            {
                cv = new ChucVuDTO();
                cv.MaCV = dr["MaCV"].ToString();
                cv.TenCV = dr["TenCV"].ToString();
                dsCV.Add(cv);
            }
            dr.Close();
            conn.Close();
            return dsCV;
        }
    }
}
