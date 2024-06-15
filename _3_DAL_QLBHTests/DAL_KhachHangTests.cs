using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_DAL_QLBH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBH;

namespace _3_DAL_QLBH.Tests
{
    [TestClass()]
    public class DAL_KhachHangTests
    {
        private DAL_KhachHang insertKH;

        [TestInitialize]
        public void Setup()
        {
            insertKH = new DAL_KhachHang();
        }

        [TestMethod()]
        public void InsertKhachHang_ThatBai()
        {
            DTO_KhachHang kh = new DTO_KhachHang();

            kh.dienThoai = "";
            kh.tenKhach = "ABBC";
            kh.Phai = "Nam";
            kh.diaChi = "HCM";
            kh.MaNV = "NV001";

            bool ketqua = insertKH.insertKH(kh);
            Assert.IsFalse(ketqua, "Thêm khách hàng thất bại: thiếu email");
        }
    }
}