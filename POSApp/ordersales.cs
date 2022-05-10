using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSapp
{
    class ordersales:ServicesPos
    {
       public DataTable dto = new DataTable();
        public void getprodbyparcode(string code)
    {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name,priceSelas from tbl_product where code='"+code+"'";
            
            settingspro.con.Open();
            dto.Load( cmd.ExecuteReader());
            settingspro.con.Close();

        }
    }
}
