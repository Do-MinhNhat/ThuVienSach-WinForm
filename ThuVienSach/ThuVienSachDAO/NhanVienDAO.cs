using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ThuVienSachDAO
{
    public class NhanVienDAO
    {
        List<NhanVienDTO> dsNV;
        SqlConnection conn;
        SqlDataReader dr;
        NhanVienDTO nv;
        public List<NhanVienDTO> LayDSNV()
        {
            dsNV = new List<NhanVienDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = "select * from NhanVien where TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                nv = new NhanVienDTO();
                nv.MaNV = dr["MaNV"].ToString();
                nv.MaCV = dr["MaCV"].ToString();
                nv.TenNV = dr["TenNV"].ToString();
                nv.GioiTinh = dr["GioiTinh"].ToString();
                nv.DChi = dr["DChi"].ToString();
                nv.SDT = dr["SDT"].ToString();
                nv.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                nv.Luong = float.Parse(dr["Luong"].ToString());
                nv.UserName = dr["UserName"].ToString();
                nv.PassWord = dr["PassWord"].ToString();
                dsNV.Add(nv);
            }
            dr.Close();
            conn.Close();
            return dsNV;
        }
        public int ThemNV(NhanVienDTO nv)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string them = $"insert into NhanVien values ('{nv.MaCV}',N'{nv.TenNV}',N'{nv.GioiTinh}',N'{nv.DChi}','{nv.SDT}',1,Cast('{nv.NgaySinh:yyyy-MM-dd}' as Date),'{nv.Luong}','{nv.UserName}','{nv.PassWord}')";
            int kq = DataProvider.Execute(them, conn);
            conn.Close();
            return kq;
        }
        public int XoaNV(NhanVienDTO nv)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string xoa = $"update NhanVien set TrangThai = 0 where MaNV = '{nv.MaNV}'";
            int kq = DataProvider.Execute(xoa, conn);
            conn.Close();
            return kq;
        }
        public int SuaNV(NhanVienDTO nv)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string sua = $"update NhanVien set MaCV = '{nv.MaCV}',TenNV = N'{nv.TenNV}',GioiTinh = N'{nv.GioiTinh}',DChi = N'{nv.DChi}',SDT = '{nv.SDT}',NgaySinh = Cast('{nv.NgaySinh:yyyy-MM-dd}' as Date),Luong = '{nv.Luong}',UserName = '{nv.UserName}',PassWord = '{nv.PassWord}' where MaNV = '{nv.MaNV}'";
            int kq = DataProvider.Execute(sua, conn);
            conn.Close();
            return kq;
        }
        public bool KiemTraSDT(NhanVienDTO nv)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string kiem = $"select * from NhanVien where SDT = '{nv.SDT}' and TrangThai = 1";
            dr = DataProvider.Read(kiem, conn);
            bool kq = dr.HasRows;
            dr.Close();
            conn.Close();
            return kq;
        }
        public bool KiemTraUser(NhanVienDTO nv)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string kiem = $"select * from NhanVien where UserName = '{nv.UserName}' and TrangThai = 1";
            dr = DataProvider.Read(kiem, conn);
            bool kq = dr.HasRows;
            dr.Close();
            conn.Close();
            return kq;
        }
        public List<NhanVienDTO> TimKiemNV(string TenNV,string DiaChi,string SDT,string Username)
        {
            dsNV = new List<NhanVienDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = $"select * from NhanVien where TrangThai = 1 and TenNV like N'%{TenNV}%' and DChi like N'%{DiaChi}%' and SDT like '%{SDT}%' and UserName like '%{Username}%'";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                nv = new NhanVienDTO();
                nv.MaNV = dr["MaNV"].ToString();
                nv.MaCV = dr["MaCV"].ToString();
                nv.TenNV = dr["TenNV"].ToString();
                nv.GioiTinh = dr["GioiTinh"].ToString();
                nv.DChi = dr["DChi"].ToString();
                nv.SDT = dr["SDT"].ToString();
                nv.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                nv.Luong = float.Parse(dr["Luong"].ToString());
                nv.UserName = dr["UserName"].ToString();
                nv.PassWord = dr["PassWord"].ToString();
                dsNV.Add(nv);
            }
            dr.Close();
            conn.Close();
            return dsNV;
        }
        public Dictionary<string,string> LayTTDN()
        {
            Dictionary<string, string> users = new Dictionary<string,string>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = "select MaNV,UserName,PassWord from NhanVien where TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                DataProvider.MaNV = dr["MaNV"].ToString();
                string tk = dr["UserName"].ToString();
                string mk = dr["PassWord"].ToString();
                users[tk] = mk;
            }
            dr.Close();
            conn.Close();
            return users;
        }
        public int LayTTCV(string TK)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string select = $"select * from NhanVien where UserName = '{TK}' and TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            int kq = 0;
            while (dr.Read())
            {
                kq = int.Parse(dr["MaCV"].ToString());
                DataProvider.MaNV = dr["MaNV"].ToString();
                DataProvider.TenNV = dr["TenNV"].ToString();
            }
            dr.Close();
            conn.Close();
            return kq;
        }

        public bool TonTaiNV(string MaNV)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string select = $"select * from NhanVien where MaNV = '{MaNV}' and TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            bool kq = dr.HasRows;
            dr.Close();
            conn.Close();
            return kq;
        }
    }
}
