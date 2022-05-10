using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POSapp
{
   public class users
    {
        public static string username;
        public static string admin;
        public DataTable dtuser = new DataTable();
        public bool login(string user,string pass)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loginsp";
            cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = pass;
            settingspro.con.Open();
            dtuser.Load(cmd.ExecuteReader());

            if (dtuser.Rows.Count>0)
            {
                MessageBox.Show("hello  "+dtuser.Rows[0][3]);
                username = dtuser.Rows[0][3].ToString();
                admin = dtuser.Rows[0][5].ToString();
                settingspro.con.Close();
                return true;
                
            }
            else
            {
                MessageBox.Show("login filed");

                settingspro.con.Close();
                return false;
               
            }
               
            
        }
    }
}
