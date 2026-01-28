using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ThuVienSachDAO
{
    public class ChiTietHoaDonDAO
    {
        SqlConnection conn;
        SqlDataReader dr;
        List<ChiTietHoaDonDTO> dsCTHD;
        ChiTietHoaDonDTO cthd;
        public List<ChiTietHoaDonDTO> LayDSCTHD()
        {
            dsCTHD = new List<ChiTietHoaDonDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = "select CTHD.MaSach,TenSach,DonGia,CTHD.SoLuong from CTHoaDon CTHD, Sach S where CTHD.TrangThai = 0 and CTHD.MaSach = S.MaSach";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                cthd = new ChiTietHoaDonDTO();
                cthd.MaSach = dr["MaSach"].ToString();
                cthd.TenSach = dr["TenSach"].ToString();
                cthd.SoLuong = int.Parse(dr["SoLuong"].ToString());
                cthd.DonGia = float.Parse(dr["DonGia"].ToString());
                cthd.ThanhTien = cthd.SoLuong * cthd.DonGia;
                dsCTHD.Add(cthd);
            }
            dr.Close();
            conn.Close();
            return dsCTHD;
        }
        public int ThemCTHD(ChiTietHoaDonDTO cthd)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string them = $"insert into CTHoaDon values(0,'{cthd.MaSach}','{cthd.SoLuong}','{cthd.DonGia}',0)";
            SuaSL("-", cthd);
            int kq = DataProvider.Execute(them, conn);
            conn.Close();
            return kq;
        }
        public int XoaCTHD(ChiTietHoaDonDTO cthd)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string xoa = $"delete from CTHoaDon where MaSach = '{cthd.MaSach}' and TrangThai = 0";
            SuaSL("+", cthd);
            int kq = DataProvider.Execute(xoa, conn);
            conn.Close();
            return kq;
        }
        public int LuuCTHD(ChiTietHoaDonDTO cthd)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string luu = $"update CTHoaDon set MaHD = '{cthd.MaHD}',TrangThai = 1 where TrangThai = 0";
            int kq = DataProvider.Execute(luu, conn);
            conn.Close();
            return kq;
        }
        public bool KiemTraTonTai(ChiTietHoaDonDTO cthd)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string select = $"select * from CTHoaDon where TrangThai = 0 and MaSach = '{cthd.MaSach}'";
            dr = DataProvider.Read(select, conn);
            bool kq = dr.HasRows;
            conn.Close();
            return kq;
        }
        private void SuaSL(string sua,ChiTietHoaDonDTO cthd)
        {
            string suaSL = $"update Sach set SoLuong = SoLuong {sua} {cthd.SoLuong} where MaSach = '{cthd.MaSach}'";
            DataProvider.Execute(suaSL, conn);
        }
        public int TangCTHD(ChiTietHoaDonDTO cthd)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string tang = $"update CTHoaDon set SoLuong = SoLuong + {cthd.SoLuong} where MaSach = '{cthd.MaSach}' and TrangThai = 0";
            SuaSL("-",cthd);
            int kq = DataProvider.Execute(tang, conn);
            conn.Close();
            return kq;
        }
        public List<ChiTietHoaDonDTO> TimCTHD(string MaHD)
        {
            dsCTHD = new List<ChiTietHoaDonDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = $"select CTHD.MaSach,TenSach,DonGia,CTHD.SoLuong from CTHoaDon CTHD, Sach S where MaHD = '{MaHD}' and CTHD.MaSach = S.MaSach";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                cthd = new ChiTietHoaDonDTO();
                cthd.MaSach = dr["MaSach"].ToString();
                cthd.TenSach = dr["TenSach"].ToString();
                cthd.SoLuong = int.Parse(dr["SoLuong"].ToString());
                cthd.DonGia = float.Parse(dr["DonGia"].ToString());
                cthd.ThanhTien = cthd.SoLuong * cthd.DonGia;
                dsCTHD.Add(cthd);
            }
            dr.Close();
            conn.Close();
            return dsCTHD;
        }
    }
}
