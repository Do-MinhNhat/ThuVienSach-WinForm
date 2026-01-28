using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ThuVienSachDAO
{
    public class HoaDonDAO
    {
        SqlConnection conn;
        SqlDataReader dr;
        List<HoaDonDTO> dsHD;
        HoaDonDTO hd;
        ChiTietHoaDonDAO CTHD = new ChiTietHoaDonDAO();
        List<ChiTietHoaDonDTO> dsCTHD;
        public List<HoaDonDTO> LayDSHD(int MaLHD)
        {
            dsHD = new List<HoaDonDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = $"select HD.* from HoaDon HD,LHD_HoaDon LHDHD where HD.MaHD = LHDHD.MaHD and MaLHD = {MaLHD}";
            dr = DataProvider.Read(select,conn);
            while(dr.Read())
            {
                hd = new HoaDonDTO();
                hd.MaHD = dr["MaHD"].ToString();
                hd.MaNV = dr["MaNV"].ToString();
                hd.MaKH = dr["MaKH"].ToString();
                hd.NgayLap = DateTime.Parse(dr["NgayLap"].ToString());
                hd.TongTien = float.Parse(dr["TongTien"].ToString());
                dsHD.Add(hd);
            }
            dr.Close();
            conn.Close();
            return dsHD;
        }
        public int ThemHD(HoaDonDTO hd)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string them = $"insert into HoaDon values('{hd.MaNV}','{hd.MaKH}',Cast('{hd.NgayLap:yyyy-MM-dd}' as Date),'{hd.TongTien}',{hd.TrangThai})";
            string select = $"select max(MaHD) as MaHD from HoaDon";
            int check = DataProvider.Execute(them,conn);
            int kq = 0;
            if (check > 0)
            {
                dr = DataProvider.Read(select, conn);
                while (dr.Read())
                {
                    kq = int.Parse(dr["MaHD"].ToString());
                }
            }
            dr.Close();
            conn.Close();
            return kq;
        }
        public int XoaHD(HoaDonDTO hd)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string xoa = $"Delete from HoaDon where MaHD = '{hd.MaHD}'";
            string xoaCTHD = $"Delete from CTHoaDon where MaHD = '{hd.MaHD}'";
            string xoaLHDHD = $"Delete from LHD_HoaDon where MaHD = '{hd.MaHD}'";
            DataProvider.Execute(xoaLHDHD, conn);
            DataProvider.Execute(xoaCTHD, conn);
            int kq = DataProvider.Execute(xoa,conn);
            conn.Close();
            return kq;
        }
        public int SuaHD(HoaDonDTO hd)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string sua = $"update HoaDon set MaNV = '{hd.MaNV}',MaKH = '{hd.MaKH}',NgayLap = Cast('{hd.NgayLap:yyyy-MM-dd}' as Date)";
            int kq = DataProvider.Execute(sua,conn);
            conn.Close();
            return kq;
        }
        public string LayCTHD(string MaHD)
        {
            string cthd = "-----------------------------------------------\n";
            dsCTHD = CTHD.TimCTHD(MaHD);
            foreach (var sach in dsCTHD)
            {
                cthd += $"Sách: {sach.TenSach} #{sach.MaSach}\nSố lượng: {sach.SoLuong}\tĐơn giá: {sach.DonGia}\nThành tiền: {sach.ThanhTien}";
                cthd += "\n-----------------------------------------------\n";
            }
            return cthd;
        }
        public string XemChiTietHD(string MaHD)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string select = $"select * from HoaDon HD, NhanVien NV, KhachHang KH where MaHD = {MaHD} and HD.MaNV = NV.MaNV and KH.MaKH = HD.MaKH";
            dr = DataProvider.Read(select, conn);
            string kq = "         ";
            while (dr.Read())
            {
                kq += $"** HÓA ĐƠN THƯ VIỆN SÁCH **\n\nMã hóa đơn: {dr["MaHD"]}\nNhân viên: {dr["TenNV"]} #{dr["MaNV"]}\nKhách hàng: {dr["TenKH"]} #{dr["MaKH"]}\n\n{LayCTHD(MaHD)}\nTổng tiền: {dr["TongTien"]}\nNgày lập: {dr["NgayLap"]:dd/MM/yyyy}";
            }
            dr.Close();
            conn.Close();
            return kq;
        }
        public List<HoaDonDTO> TimHD(string MaHD,string MaNV,string MaKH,int MaLHD)
        {
            dsHD = new List<HoaDonDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = $"select HD.* from HoaDon HD,LHD_HoaDon LHDHD where HD.MaHD = LHDHD.MaHD and MaLHD = '{MaLHD}' and HD.MaHD like '%{MaHD}%' and MaNV like '%{MaNV}%' and MaKH like '%{MaKH}%' and TongTien IS NOT  NULL";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                hd = new HoaDonDTO();
                hd.MaHD = dr["MaHD"].ToString();
                hd.MaNV = dr["MaNV"].ToString();
                hd.MaKH = dr["MaKH"].ToString();
                hd.NgayLap = DateTime.Parse(dr["NgayLap"].ToString());
                hd.TongTien = float.Parse(dr["TongTien"].ToString());
                dsHD.Add(hd);
            }
            dr.Close();
            conn.Close();
            return dsHD;
        }
        public void CapNhatHD(string MaHD,float Money)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string capnhat = $"update HoaDon set TongTien = '{Money}' where MaHD = '{MaHD}'";
            DataProvider.Execute(capnhat, conn);
            conn.Close();
        }

        public string LayMaxMaHD()
        {
            string kq = "";
            conn = DataProvider.Connect();
            conn.Open();
            string select = "select Max(MaHD) as MaHD from HoaDon";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                kq = dr["MaHD"].ToString();
            }
            dr.Close();
            conn.Close();
            return kq;
        }
    }
}
