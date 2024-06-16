using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBH;

namespace _3_DAL_QLBH
{
    public class DAL_NhanVien: DBConnect
    {
        public bool NhanVienDangNhap(DTO_NhanVien nhanVien)
        {
            try
            {
                conn.Open();
                string sql = $"select * from nhanvien where email = @Email and matkhau = @matkhau";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Email", nhanVien.EmailNV);
                cmd.Parameters.AddWithValue("@matkhau", nhanVien.MatKhau);

                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            finally { conn.Close(); }
            return false;
        }
        public bool NhanVienQuenMK(string email)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "QuenMatKhau";
                cmd.Parameters.AddWithValue("@email", email);

                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return false;
        }
        public DataTable LayMK(string email) 
        {
            try
            {
                //Kết nối 
                conn.Open();
                string sql = $"select matkhau from nhanvien where email = @Email";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Email", email);


                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());
                return dtNhanVien;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool UpdateMK(string email, string matkhau)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateMatKhau";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@matkhau", matkhau);
                if (Convert.ToInt16(cmd.ExecuteNonQuery()) > 0)
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
        public DataTable VaiTroNV(string email) 
        {
            try
            {
                //Kết nối 
                conn.Open();
                string sql = $"select vaitro from nhanvien where email = @Email";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());
                return dtNhanVien;
            }

            finally
            {
                conn.Close();
            }
        }
        public DataTable layMaNhanVien()
        {
            try
            {
                //Kết nối 
                conn.Open();
                string sql = "select manv from nhanvien";
                SqlCommand cmd = new SqlCommand(sql, conn);

                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());
                return dtNhanVien;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool kiemTraEmail(string email)
        {
            try
            {
                conn.Open();

                // Sử dụng truy vấn với tham số để tránh SQL injection
                string sql = "SELECT COUNT(email) FROM nhanvien WHERE email = @Email";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Email", email);

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
        public DataTable getNhanVien()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachNV";
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
        public bool insertNV(DTO_NhanVien nv)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertNV";
                cmd.Parameters.AddWithValue("@email", nv.emailNV);
                cmd.Parameters.AddWithValue("@tennv", nv.tenNV);
                cmd.Parameters.AddWithValue("@diachi", nv.diaChi);
                cmd.Parameters.AddWithValue("@vaitro", nv.vaiTro);
                cmd.Parameters.AddWithValue("@tinhtrang", nv.tinhTrang);
                cmd.Parameters.AddWithValue("@matkhau", nv.matKhau);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { conn.Close(); }
            return false;
        }
        //Sửa nhân viên
        public bool updateNV(DTO_NhanVien nv, string ma)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateNV";
                cmd.Parameters.AddWithValue("@manv", ma);
                cmd.Parameters.AddWithValue("@email", nv.emailNV);
                cmd.Parameters.AddWithValue("@tennv", nv.tenNV);
                cmd.Parameters.AddWithValue("@diachi", nv.diaChi);
                cmd.Parameters.AddWithValue("@vaitro", nv.vaiTro);
                cmd.Parameters.AddWithValue("@tinhtrang", nv.tinhTrang);
                cmd.Parameters.AddWithValue("@matkhau", nv.matKhau);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.Close(); }
            return false;
        }

        //Xóa nhân viên
        public bool deleteNV(string ma, out string errorMessage)
        {
            errorMessage = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteNV";
                cmd.Parameters.AddWithValue("@manv", ma);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {
                errorMessage = ex.Message;
            }
            finally { conn.Close(); }
            return false;
        }

        //Tìm kiếm nhân viên

        public DataTable searchNV(string name)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchNV";
                cmd.Parameters.AddWithValue("@tennv", name);
                cmd.Connection = conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cmd.ExecuteReader());
                return dtNV;
            }
            finally {conn.Close(); }
        }
    }
    
}
