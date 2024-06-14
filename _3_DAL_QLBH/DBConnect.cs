using DTO_QLBH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DAL_QLBH
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("server=CHIBAO\\SQLEXPRESS; database=QLBH; integrated security=true");
        
    }
}
