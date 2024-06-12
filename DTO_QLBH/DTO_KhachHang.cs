using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class DTO_KhachHang
    {
        public string dienThoai { get; set; }
        public string tenKhach {  get; set; }
        public string diaChi { get; set; }
        public string phai { get; set; }
        public string maNV {  get; set; }

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }
        public string TenKhach
        {
            get { return tenKhach; }
            set { tenKhach = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string Phai
        {
            get { return phai; }
            set { phai = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public DTO_KhachHang(string dienThoai, string tenKhach, string diaChi, string phai, string maNV)
        {
            this.dienThoai = dienThoai;
            this.tenKhach = tenKhach;
            this.diaChi = diaChi;
            this.phai = phai;
            this.maNV = maNV;
        }
        public DTO_KhachHang() { }
    }
}
