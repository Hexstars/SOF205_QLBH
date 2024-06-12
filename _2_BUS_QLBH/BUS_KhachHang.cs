using _3_DAL_QLBH;
using DTO_QLBH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QLBH
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKH = new DAL_KhachHang();
        public DataTable getKhachHang()
        {
            return dalKH.getKhachHang();
        }
        public bool InsertKH(DTO_KhachHang kh)
        {
            return dalKH.insertKH(kh);
        }
        public bool UpdateKH(DTO_KhachHang kh)
        {
            return dalKH.updateKH(kh);
        }
        public bool DeleteKH(string sdt)
        {
            return dalKH.deleteKH(sdt);
        }
        public DataTable SearchKH(string name)
        {
            return dalKH.searchKH(name);
        }
    }
}
