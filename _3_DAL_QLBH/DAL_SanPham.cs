using DTO_QLBH;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DAL_QLBH
{
    public class DAL_SanPham: DBConnect
    {
        //Danh sách sp
        public DataTable getSanPham()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachSP";
                cmd.Connection = conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cmd.ExecuteReader());
                return dtNV;
            }
            finally
            {
                conn.Close();
            }
        }

        //Thêm khách hàng
        public bool InsertSP(DTO_SanPham sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertSP";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@tenhang", sp.TenHang);
                cmd.Parameters.AddWithValue("@soluong", sp.SoLuong);
                cmd.Parameters.AddWithValue("@dongianhap", sp.donGiaNhap);
                cmd.Parameters.AddWithValue("@dongiaban", sp.donGiaBan);
                cmd.Parameters.AddWithValue("@hinhanh", sp.HinhAnh);
                cmd.Parameters.AddWithValue("@ghichu", sp.GhiChu);
                cmd.Parameters.AddWithValue("@manv", sp.MaNV);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { conn.Close(); }
            return false;
        }

        //Sửa khách hàng
        public bool UpdateSP(DTO_SanPham sp, int maHang)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateSP";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@mahang", maHang);
                cmd.Parameters.AddWithValue("@tenhang", sp.TenHang);
                cmd.Parameters.AddWithValue("@soluong", sp.SoLuong);
                cmd.Parameters.AddWithValue("@dongianhap", sp.donGiaNhap);
                cmd.Parameters.AddWithValue("@dongiaban", sp.donGiaBan);
                cmd.Parameters.AddWithValue("@hinhanh", sp.HinhAnh);
                cmd.Parameters.AddWithValue("@ghichu", sp.GhiChu);
                cmd.Parameters.AddWithValue("@manv", sp.MaNV);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { conn.Close(); }
            return false;
        }

        //Xóa khách hàng
        public bool DeleteSP(int mahang)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteSP";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@mahang", mahang);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { conn.Close(); }
            return false;
        }

        //Tìm kiếm khách hàng
        public DataTable searchSP(string name)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchSP";
                cmd.Parameters.AddWithValue("@tenhang", name);
                cmd.Connection = conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cmd.ExecuteReader());
                return dtNV;
            }
            finally { conn.Close(); }
        }
    }
}
