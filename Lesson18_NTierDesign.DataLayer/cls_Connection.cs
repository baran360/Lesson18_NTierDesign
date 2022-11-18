using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_NTierDesign.DataLayer
{
    public class cls_Connection
    {
        public static SqlConnection Connect
        {
            get
            {
                SqlConnection sqlcon = new SqlConnection("server=DESKTOP-412PKJ8;database=NORTHWND;trusted_connection=true");
                return sqlcon;
            }
        }
    }
}
