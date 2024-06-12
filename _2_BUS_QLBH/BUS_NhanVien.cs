﻿using _3_DAL_QLBH;
using DTO_QLBH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;

namespace _2_BUS_QLBH
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNV = new DAL_NhanVien();

        public bool NhanVienDangNhap(DTO_NhanVien nhanVien)
        {
            return dalNV.NhanVienDangNhap(nhanVien);
        }
        public bool NhanVienQuenMK(string email)
        {
            return dalNV.NhanVienQuenMK(email);
        }
        public bool CapNhatMK(string email, string matkhau)
        {
            return dalNV.UpdateMK(email, matkhau);
        }
        public DataTable VaiTroNV(string email) 
        {
            return dalNV.VaiTroNV(email);
        }

        //xử lí md5
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encoding = new UTF8Encoding();
            //encrypt the given password string into Encrypted Data
            encrypt = md5.ComputeHash(encoding.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create new string by using encryted data
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
        public DataTable GetNhanVien()
        {
            return dalNV.getNhanVien();
        }
        public bool InsertNV(DTO_NhanVien nv)
        {
            return dalNV.insertNV(nv);
        }
        public bool UpdateNV(DTO_NhanVien nv, string ma)
        {
            return dalNV.updateNV(nv, ma);
        }
        public bool DeleteNV(string ma)
        {
            return dalNV.deleteNV(ma);
        }
        public DataTable SearchNV(string name)
        {
            return dalNV.searchNV(name);
        }
    }
}
