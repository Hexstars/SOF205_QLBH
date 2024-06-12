using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class DTO_NhanVien
    {
        public string maNV { get; set; }
        public string emailNV { get; set; }
        public string tenNV { get; set; }
        public string diaChi { get; set; }
        public int vaiTro { get; set; }
        public int tinhTrang { get; set; }
        public string matKhau { get; set; }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string EmailNV
        {
            get { return emailNV; }
            set { emailNV = value; }
        }
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public int VaiTro
        {
            get { return vaiTro; }
            set { vaiTro = value; }
        }
        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public DTO_NhanVien(string emailNV, string tenNV, string diaChi, int vaiTro, int tinhTrang, string matKhau)
        {
            this.maNV = MaNV;
            this.emailNV = emailNV;
            this.tenNV = tenNV;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.tinhTrang = tinhTrang;
            this.matKhau = matKhau;
        }
        public DTO_NhanVien() { }
    }
}
