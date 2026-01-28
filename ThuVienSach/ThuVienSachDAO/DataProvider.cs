using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienSachDAO
{
    public static class DataProvider
    {
        static string connStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=ThuVienSach;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public static SqlConnection Connect()
        {
            return new SqlConnection(connStr);
        }
        public static SqlDataReader Read(string comm, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(comm, conn);
            return com.ExecuteReader();
        }
        public static int Execute(string comm, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(comm, conn);
            return com.ExecuteNonQuery();
        }
        public static string MaNV;
        public static string TenNV;
    }
}
