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
  
    class items :ServicesPos
    {

        
        public void additem(string id,string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertitems";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;

            settingspro.con.Open();
            cmd.ExecuteNonQuery();
            settingspro.con.Close();
            MessageBox.Show("تم الحفظ بنجاح");
        }

        public void updateitem(string id,string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updteitem";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;

            settingspro.con.Open();
            cmd.ExecuteNonQuery();
            settingspro.con.Close();
            MessageBox.Show("تم التعديل بنجاح");
        }

        public void delete(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete  from tbl_items where id="+id;
            
            settingspro.con.Open();
            cmd.ExecuteNonQuery();
            settingspro.con.Close();
            MessageBox.Show("تم الحذف بنجاح");
        }
    }
}
