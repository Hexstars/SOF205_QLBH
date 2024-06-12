using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class DTO_SanPham
    {
        public int maHang { get; set; }
        public string tenHang { get; set; }
        public int soLuong { get; set; }
        public float donGiaNhap { get;set; }
        public float donGiaBan { get; set; }
        public string hinhAnh {  get; set; }
        public string ghiChu {  get; set; }
        public string maNV {  get; set; }

        public int MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }
        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public float DonGiaNhap
        {
            get { return donGiaNhap; }
            set { donGiaNhap = value; }
        }
        public float DonGiaBan
        {
            get { return donGiaBan; }
            set { donGiaBan = value; }
        }
        public string HinhAnh
        {
            get { return hinhAnh; }
            set { hinhAnh = value; }
        }
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public DTO_SanPham(string tenHang, int soLuong, float donGiaNhap, float donGiaBan, string hinhAnh, string ghiChu, string maNV)
        {
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGiaNhap = donGiaNhap;
            this.donGiaBan = donGiaBan;
            this.hinhAnh = hinhAnh;
            this.ghiChu = ghiChu;
            this.maNV = maNV;
        }
        public DTO_SanPham() { }
    }
}
