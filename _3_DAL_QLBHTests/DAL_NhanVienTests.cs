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
    public class DAL_NhanVienTests: DBConnect
    {
        private DAL_NhanVien login;

        [TestInitialize]
        public void Setup()
        {
            login = new DAL_NhanVien();
        }


        [TestMethod()]
        public void NhanVienDangNhapTest01_001_ThatBai()
        {
            DTO_NhanVien nv = new DTO_NhanVien();

            nv.EmailNV = "";
            nv.MatKhau = "abcd1234";

            bool ketqua = login.NhanVienDangNhap(nv);
            Assert.IsFalse(ketqua, "Đăng nhập thất bại: thiếu email");
        }

        [TestMethod()]
        public void NhanVienDangNhapTest01_002_ThatBai()
        {
            DTO_NhanVien nv = new DTO_NhanVien();

            nv.EmailNV = "itzyhd2000@gmail.com";
            nv.MatKhau = "";

            bool ketqua = login.NhanVienDangNhap(nv);
            Assert.IsFalse(ketqua, "Đăng nhập thất bại: thiếu mật khẩu");
        }

        [TestMethod()]
        public void NhanVienDangNhapTest01_003_ThanhCong()
        {
            DTO_NhanVien nv = new DTO_NhanVien();

            nv.EmailNV = "itzyhd2000@gmail.com";
            nv.MatKhau = "196145663720616991136127245362061123820032";

            bool ketqua = login.NhanVienDangNhap(nv);
            Assert.IsTrue(ketqua , "Đăng nhập thất bại");
        }

        [TestMethod()]
        public void ThemNhanVienThanhCong()
        {
            DTO_NhanVien nv = new DTO_NhanVien();

            nv.emailNV = "bao@gmail.com";
            nv.TenNV = "bao";
            nv.matKhau = "196145663720616991136127245362061123820032";
            nv.vaiTro = 0;
            nv.tinhTrang = 1;
            nv.DiaChi = "HCM";

            bool ketQua = login.insertNV(nv);

            Assert.IsTrue(ketQua, "Thêm nhân viên thành công");
        }
        public void ThemNhanVienThatBai()
        {
            DTO_NhanVien nv = new DTO_NhanVien();

            nv.TenNV = "bao";
            nv.matKhau = "nhanvien";
            nv.vaiTro = 0;
            nv.tinhTrang = 1;
            nv.DiaChi = "HCM";

            bool ketQua = login.insertNV(nv);

            Assert.IsFalse(ketQua, "Thêm nhân viên thất bại: thiếu email");
        }
    }
}