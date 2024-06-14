using DTO_QLBH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DAL_QLBH
{
    public class DAL_KhachHang: DBConnect
    {


        public bool kiemTraSDT(string sdt)
        {
            try
            {
                conn.Open();

                // Sử dụng truy vấn với tham số để tránh SQL injection
                string sql = "SELECT COUNT(dienthoai) FROM khachhang WHERE dienthoai = @dienthoai";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@dienthoai", sdt);

                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {
                    return true;
                }
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        //Danh sách khách hàng
        public DataTable getKhachHang()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachKH";
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
        public bool insertKH(DTO_KhachHang kh)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertKH";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@dienthoai", kh.DienThoai);
                cmd.Parameters.AddWithValue("@tenkhach", kh.TenKhach);
                cmd.Parameters.AddWithValue("@diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@phai", kh.Phai);
                cmd.Parameters.AddWithValue("@manv", kh.MaNV);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { conn.Close(); }
            return false;
        }

        //Sửa khách hàng
        public bool updateKH(DTO_KhachHang kh)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateKH";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@dienthoai", kh.DienThoai);
                cmd.Parameters.AddWithValue("@tenkhach", kh.TenKhach);
                cmd.Parameters.AddWithValue("@diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@phai", kh.Phai);
                cmd.Parameters.AddWithValue("@manv", kh.MaNV);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { conn.Close(); }
            return false;
        }

        //Xóa khách hàng
        public bool deleteKH(string sdt)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteKH";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@dienthoai", sdt);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { conn.Close(); }
            return false;
        }

        //Tìm kiếm khách hàng
        public DataTable searchKH(string name)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchKH";
                cmd.Parameters.AddWithValue("@tenkhach", name);
                cmd.Connection = conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cmd.ExecuteReader());
                return dtNV;
            }
            finally {conn.Close(); }
        }
    }
}
