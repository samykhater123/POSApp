using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSapp
{
    class customer:ServicesPos
    {
        public DataTable dt2 = new DataTable();
        public SqlDataReader dtcustreder;

        public string phone { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public void addcustomer( string phone, string name, string address, string email, string notes)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "addcustmer";
            
            cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = phone;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar, 50).Value = address;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = email;
            cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 50).Value = notes;
            

            settingspro.con.Open();
            cmd.ExecuteNonQuery();
            settingspro.con.Close();
            MessageBox.Show("تم الحفظ بنجاح");
        }


        public void updatecustomer(string phone, string name, string address, string email, string notes)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "udatecustmer";

            cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = phone;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar, 50).Value = address;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = email;
            cmd.Parameters.Add("@note", SqlDbType.NVarChar, 50).Value = notes;


            settingspro.con.Open();
            cmd.ExecuteNonQuery();
            settingspro.con.Close();
            MessageBox.Show("تم التعديل بنجاح");
        }

        public void deletcust(string phone)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tbl_Custuomers where phone='" + phone + "'";

            settingspro.con.Open();
            cmd.ExecuteNonQuery();
            settingspro.con.Close();
            MessageBox.Show("تم الحذف");
        }

       
        public void searchcust(string txt)
        {
             
             SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "serchforcust" ;
            cmd.Parameters.Add("@txt", SqlDbType.NVarChar, 50).Value = txt;

            settingspro.con.Open();
            dt2.Load(cmd.ExecuteReader());
            settingspro.con.Close();
            
        }

        public DataTable checkphonepk(string phone)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "chickphone";
            cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = phone;

            settingspro.con.Open();
            dt2.Load(cmd.ExecuteReader());
            settingspro.con.Close();
            return dt2;
        }
       
        public void getcustbyphone(string phone)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getcustbyphone";
            cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = phone;

            settingspro.con.Open();
            dtcustreder = cmd.ExecuteReader();
            dtcustreder.Read();


            if (dtcustreder.HasRows)
            {
                name = dtcustreder[2].ToString();
                address = dtcustreder[3].ToString();
            }
            else
            {
                name = "";
                address = "";
            }
            dtcustreder.Close();
            settingspro.con.Close();
            
        }
    }
}
