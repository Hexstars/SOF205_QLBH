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
    public class BUS_SanPham
    {
        DAL_SanPham dalSP = new DAL_SanPham();
        public DataTable GetSP()
        {
            return dalSP.getSanPham();
        }
        public bool InsertSP(DTO_SanPham sp)
        {
            return dalSP.InsertSP(sp);
        }
        public bool UpdateSP(DTO_SanPham sp)
        {
            return dalSP.UpdateSP(sp);
        }
        public bool DeleteSP(int maHang)
        {
            return dalSP.DeleteSP(maHang);
        }
        public DataTable SearchSP(string name)
        {
            return dalSP.searchSP(name);
        }

    }
}
