using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienSachDAO
{
    public class KhachHangDAO
    {
        List<KhachHangDTO> dsKH;
        SqlConnection conn;
        SqlDataReader dr;
        KhachHangDTO kh;
        public List<KhachHangDTO> LayDSKH()
        {
            dsKH = new List<KhachHangDTO> ();
            conn = DataProvider.Connect();
            conn.Open ();
            string select = "select * from KhachHang where TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                kh = new KhachHangDTO();
                kh.MaKH = dr["MaKH"].ToString();
                kh.TenKH = dr["TenKH"].ToString ();
                kh.DChi = dr["DChi"].ToString() ;
                kh.SDT = dr["SDT"].ToString();
                kh.Email = dr["Email"].ToString () ;
                kh.NgayLapThe = DateTime.Parse(dr["NgayLapThe"].ToString());
                kh.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                kh.GioiTinh = dr["GioiTinh"].ToString().ToString() ;
                dsKH.Add(kh);
            }
            dr.Close();
            conn.Close ();
            return dsKH;
        }
        public int ThemKH(KhachHangDTO kh)
        {
            conn = DataProvider.Connect();
            conn.Open ();
            string them = $"insert into KhachHang values (N'{kh.TenKH}',N'{kh.DChi}','{kh.SDT}','{kh.Email}',1,Cast('{kh.NgayLapThe:yyyy-MM-dd}' as Date),Cast('{kh.NgaySinh:yyyy-MM-dd}' as Date),N'{kh.GioiTinh}')";
            int kq = DataProvider.Execute(them,conn);
            conn.Close();
            return kq;
        }
        public int XoaKH(KhachHangDTO kh)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string xoa = $"update KhachHang set TrangThai = 0 where MaKH = '{kh.MaKH}'";
            int kq = DataProvider.Execute(xoa, conn);
            conn.Close();
            return kq;
        }
        public int SuaKH(KhachHangDTO kh)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string sua = $"update KhachHang set TenKH = N'{kh.TenKH}',DChi = N'{kh.DChi}',Email = '{kh.Email}',NgayLapThe = Cast('{kh.NgayLapThe:yyyy-MM-dd}' as Date),NgaySinh = Cast('{kh.NgaySinh:yyyy-MM-dd}' as Date),GioiTinh = N'{kh.GioiTinh}' where MaKH = '{kh.MaKH}'";
            int kq = DataProvider.Execute(sua, conn);
            conn.Close();
            return kq;
        }
        public bool KiemTraSDT(KhachHangDTO kh)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string select = $"select * from KhachHang where SDT = '{kh.SDT}' and TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            bool kq = dr.HasRows;
            dr.Close();
            conn.Close();
            return kq;
        }
        public List<KhachHangDTO> TimKiemKH(string TenKH,string DiaChi, string Email, string SDT)
        {
            dsKH = new List<KhachHangDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string tim = $"select * from KhachHang where TenKH like N'%{TenKH}%' and DChi like N'%{DiaChi}%' and Email like '%{Email}%' and SDT like '%{SDT}%' and TrangThai = 1";
            dr = DataProvider.Read(tim, conn);
            while (dr.Read())
            {
                kh = new KhachHangDTO();
                kh.MaKH = dr["MaKH"].ToString();
                kh.TenKH = dr["TenKH"].ToString();
                kh.DChi = dr["DChi"].ToString();
                kh.SDT = dr["SDT"].ToString();
                kh.Email = dr["Email"].ToString();
                kh.NgayLapThe = DateTime.Parse(dr["NgayLapThe"].ToString());
                kh.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                kh.GioiTinh = dr["GioiTinh"].ToString().ToString();
                dsKH.Add(kh);
            }
            dr.Close();
            conn.Close();
            return dsKH;
        }
        public bool TonTaiKH(string MaKH)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string select = $"select * from KhachHang where MaKH = '{MaKH}' and TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            bool kq = dr.HasRows;
            dr.Close();
            conn.Close();
            return kq;
        }
    }
}
