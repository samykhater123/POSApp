using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSapp
{
    class ServicesPos
    {
        public DataTable dt = new DataTable();

        public void loaditem(string spname)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spname;
            settingspro.con.Open();

            dt.Load(cmd.ExecuteReader());
            settingspro.con.Close();
        }

        int max;

        public int maxid(string spname)
        {


            SqlCommand sql = new SqlCommand();
            sql.Connection = settingspro.con;
            sql.CommandType = CommandType.StoredProcedure;
            sql.CommandText = spname;
            settingspro.con.Open();
            if (string.IsNullOrEmpty(sql.ExecuteScalar().ToString()))
            {
               
                max = 0;
            }
            else
            {
                max = Convert.ToInt32(sql.ExecuteScalar());
            }
            settingspro.con.Close();
            return max + 1;
        }

        int idc;
       public int getid(string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getidforcomposp" ;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar,50).Value =name;
            settingspro.con.Open();
            idc=Convert.ToInt32( cmd.ExecuteScalar());
            settingspro.con.Close();
            return idc;
        }
    }
}
