using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DAL_QLBH
{
    public class DAL_ThongKe: DBConnect
    {
        public DataTable SanPhamNhap()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeSanPham";
                cmd.Connection = conn;
                DataTable dtTK = new DataTable();
                dtTK.Load(cmd.ExecuteReader());
                return dtTK;
            }
            finally { conn.Close(); }
        }
        public DataTable SanPhamTonKho()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeTonKho";
                cmd.Connection = conn;
                DataTable dtTK = new DataTable();
                dtTK.Load(cmd.ExecuteReader());
                return dtTK;
            }
            finally { conn.Close(); }
        }
    }
}
