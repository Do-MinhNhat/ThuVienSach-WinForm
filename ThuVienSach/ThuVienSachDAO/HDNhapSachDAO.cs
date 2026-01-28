using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ThuVienSachDAO
{
    public class HDNhapSachDAO
    {
        List<HDNhapSachDTO> dsHDNS;
        SqlConnection conn;
        SqlDataReader dr;
        HDNhapSachDTO hdns;
        public List<HDNhapSachDTO> LayDSHDNS()
        {
            dsHDNS = new List<HDNhapSachDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = "select * from HDNhapSach";
            dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                hdns = new HDNhapSachDTO();
                hdns.MaNS = dr["MaNS"].ToString();
                hdns.MaSach = dr["MaSach"].ToString();
                hdns.MaNCC = dr["MaNCC"].ToString();
                hdns.NgayLap = DateTime.Parse(dr["NgayLap"].ToString());
                hdns.SoLuong = int.Parse(dr["SoLuong"].ToString());
                hdns.DonGia = float.Parse(dr["DonGia"].ToString());
                hdns.TongTien = float.Parse(dr["TongTien"].ToString());
                dsHDNS.Add(hdns);
            }
            dr.Close();
            conn.Close();
            return dsHDNS;
        }
        public int ThemHDNS(HDNhapSachDTO hdns)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string them = $"insert into HDNhapSach values('{hdns.MaSach}','{hdns.MaNCC}',Cast('{hdns.NgayLap:yyyy-MM-dd}' as Date),'{hdns.SoLuong}','{hdns.DonGia}','{hdns.TongTien}')";
            int kq = DataProvider.Execute(them, conn);
            conn.Close();
            return kq;
        }
    }
}
