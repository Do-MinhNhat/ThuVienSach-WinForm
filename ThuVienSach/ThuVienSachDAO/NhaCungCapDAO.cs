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
    public class NhaCungCapDAO
    {
        List<NhaCungCapDTO> dsNCC;
        SqlConnection conn;
        SqlDataReader dr;
        NhaCungCapDTO ncc;
        public List<NhaCungCapDTO> LayDSNCC()
        {
            dsNCC = new List<NhaCungCapDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string select = "select * from NCC where TrangThai = 1";
            SqlDataReader dr = DataProvider.Read(select, conn);
            while (dr.Read())
            {
                ncc = new NhaCungCapDTO();
                ncc.MaNCC = dr["MaNCC"].ToString();
                ncc.TenNCC = dr["TenNCC"].ToString();
                ncc.DChi = dr["DChi"].ToString();
                ncc.SDT = dr["SDT"].ToString();
                dsNCC.Add(ncc);
            }
            dr.Close();
            conn.Close();
            return dsNCC;
        }
        public int ThemNCC(NhaCungCapDTO ncc)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string them = $"insert into NCC values (N'{ncc.TenNCC}',N'{ncc.DChi}','{ncc.SDT}',1)";
            int kq = DataProvider.Execute(them, conn);
            conn.Close();
            return kq;
        }
        public int XoaNCC(NhaCungCapDTO ncc)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string xoa = $"update NCC set TrangThai = 0 where MaNCC = '{ncc.MaNCC}'";
            string xoaSach = $"update Sach set TrangThai = 0 where MaNCC = '{ncc.MaNCC}'";
            DataProvider.Execute(xoaSach, conn);
            int kq = DataProvider.Execute(xoa, conn);
            conn.Close();
            return kq;
        }
        public int SuaNCC(NhaCungCapDTO ncc)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string sua = $"update NCC set TenNCC = N'{ncc.TenNCC}',DChi = N'{ncc.DChi}' where MaNCC = '{ncc.MaNCC}'";
            int kq = DataProvider.Execute(sua, conn);
            conn.Close();
            return kq;
        }
        public bool KiemTraSDT(NhaCungCapDTO ncc)
        {
            conn = DataProvider.Connect();
            conn.Open();
            string select = $"select * from NCC where SDT = '{ncc.SDT}' and TrangThai = 1";
            dr = DataProvider.Read(select, conn);
            bool kq = dr.HasRows;
            dr.Close();
            conn.Close();
            return kq;
        }

        public List<NhaCungCapDTO> TimKiemNCC(string TenNCC,string DiaChi,string sdt)
        {
            dsNCC = new List<NhaCungCapDTO>();
            conn = DataProvider.Connect();
            conn.Open();
            string tim = $"select * from NCC where TenNCC like N'%{TenNCC}%' and DChi like N'%{DiaChi}%' and SDT like '%{sdt}%' and TrangThai = 1";
            dr = DataProvider.Read(tim, conn);
            while (dr.Read())
            {
                ncc = new NhaCungCapDTO();
                ncc.MaNCC = dr["MaNCC"].ToString();
                ncc.TenNCC = dr["TenNCC"].ToString();
                ncc.DChi = dr["DChi"].ToString();
                ncc.SDT = dr["SDT"].ToString();
                dsNCC.Add(ncc);
            }
            dr.Close();
            conn.Close();
            return dsNCC;
        }
    }
}
