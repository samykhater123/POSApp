using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace POSapp
{
    class settingspro
    {
      public static  SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SH8J5TV\SQLEXPRESS;Initial Catalog=sales_app;Integrated Security=True");
        
    }
}
