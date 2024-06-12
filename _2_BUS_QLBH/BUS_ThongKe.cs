using _3_DAL_QLBH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QLBH
{
    public class BUS_ThongKe
    {
        DAL_ThongKe dalTK = new DAL_ThongKe();
        public DataTable SanPhamNhap()
        {
            return dalTK.SanPhamNhap();
        }
        public DataTable SanPhamTonKho()
        {
            return dalTK.SanPhamTonKho();
        }
    }
}
