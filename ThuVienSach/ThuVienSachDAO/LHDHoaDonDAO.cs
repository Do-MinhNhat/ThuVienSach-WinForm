using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ThuVienSachDAO
{
    public class LHDHoaDonDAO
    {
        SqlConnection conn;
        SqlDataReader dr;
        List<LHDHoaDonDTO> dsLHDHD;
        LHDHoaDonDTO lhdhd;

        List<SachDTO> dsS;
        SachDTO s;
        public List<LHDHoaDonDTO> LayDSLHDHD(int TrangThai)
        {
            dsLHDHD = new List<LHDHoaDonDTO> ();
            conn = DataProvider.Connect();
            conn.Open ();
            string select = $"select LHDHD.*,MaKH,TrangThai,LHDHD.MaHD from LHD_HoaDon LHDHD, HoaDon HD where MaLHD = 2 and TrangThai = {TrangThai} and LHDHD.MaHD = HD.MaHD";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                lhdhd = new LHDHoaDonDTO();
                lhdhd.MaLHD = dr["MaLHD"].ToString();
                lhdhd.MaHD = dr["MaHD"].ToString();
                lhdhd.MaKH = dr["MaKH"].ToString();
                lhdhd.NgayMuon = DateTime.Parse(dr["NgayMuon"].ToString());
                lhdhd.HanTra = DateTime.Parse(dr["HanTra"].ToString());
                if(TrangThai == 1)
                {
                    lhdhd.NgayTra = DateTime.Parse(dr["NgayTra"].ToString());
                    lhdhd.PhiTraMuon = float.Parse(dr["PhiTraMuon"].ToString());
                }
                lhdhd.TrangThai = TrangThai;
                dsLHDHD.Add(lhdhd);
            }
            dr.Close();
            conn.Close();
            return dsLHDHD;
        }
        public int ThemLHDHDMuon(LHDHoaDonDTO lhdhd)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string Them = $"insert into LHD_HoaDon (MaLHD,MaHD,NgayMuon,HanTra) values('{lhdhd.MaLHD}','{lhdhd.MaHD}',Cast('{lhdhd.NgayMuon:yyyy-MM-dd}' as Date), Cast('{lhdhd.HanTra:yyyy-MM-dd}' as Date))";
            int kq = DataProvider.Execute(Them, conn);
            conn.Close();
            return kq;
        }
        public int ThemLHDHDMua(LHDHoaDonDTO lhdhd)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string Them = $"insert into LHD_HoaDon (MaLHD,MaHD) values('{lhdhd.MaLHD}','{lhdhd.MaHD}')";
            int kq = DataProvider.Execute(Them, conn);
            conn.Close();
            return kq;
        }
        public int  CapNhatLHDHD(LHDHoaDonDTO lhdhd)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string CapNhat = $"update LHD_HoaDon set NgayTra = Cast('{lhdhd.NgayTra:yyyy-MM-dd}' as Date), PhiTraMuon = '{lhdhd.PhiTraMuon}' where MaHD = '{lhdhd.MaHD}'";
            int kq = DataProvider.Execute(CapNhat, conn);
            conn.Close();
            return kq;
        }
        public int TraSach(LHDHoaDonDTO lhdhd)
        {
            dsS = new List<SachDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string Tra = $"update HoaDon set TrangThai = 1 where MaHD = '{lhdhd.MaHD}'";
            string select = $"select * from CTHoaDon where MaHD = '{lhdhd.MaHD}'";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                s = new SachDTO();
                s.MaSach = dr["MaSach"].ToString();
                s.SoLuong = int.Parse(dr["SoLuong"].ToString());
                dsS.Add(s);
            }
            dr.Close();
            foreach (var sach in dsS)
            {
                string TraSach = $"update Sach set SoLuong = SoLuong + '{sach.SoLuong}' where MaSach = '{sach.MaSach}'";
                DataProvider.Execute(TraSach, conn);
            }
            int kq = DataProvider.Execute(Tra, conn);
            conn.Close();
            return kq;
        }
        public List<LHDHoaDonDTO> TimKiem(string MaKH, int TrangThai, string MaHD)
        {
            dsLHDHD = new List<LHDHoaDonDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = $"select LHDHD.*,MaKH from LHD_HoaDon LHDHD, HoaDon HD where MaLHD = 2 and TrangThai = {TrangThai} and MaKH like '%{MaKH}%' and LHDHD.MaHD like '%{MaHD}%' and LHDHD.MaHD = HD.MaHD";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                lhdhd = new LHDHoaDonDTO();
                lhdhd.MaLHD = dr["MaLHD"].ToString();
                lhdhd.MaHD = dr["MaHD"].ToString();
                lhdhd.MaKH = dr["MaKH"].ToString();
                lhdhd.NgayMuon = DateTime.Parse(dr["NgayMuon"].ToString());
                lhdhd.HanTra = DateTime.Parse(dr["HanTra"].ToString());
                if (TrangThai == 1)
                {
                    lhdhd.NgayTra = DateTime.Parse(dr["NgayTra"].ToString());
                    lhdhd.PhiTraMuon = float.Parse(dr["PhiTraMuon"].ToString());
                }
                lhdhd.TrangThai = TrangThai;
                dsLHDHD.Add(lhdhd);
            }
            dr.Close();
            conn.Close();
            return dsLHDHD;
        }
    }
}
