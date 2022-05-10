using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace POSapp
{
    class procucts:ServicesPos
    {
       



        public void addproduct(int id,string code,string name,double pricebuy,double priceselas,double priceern,double qty,byte [] img,int itemid)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "addproductsp";
            cmd.Parameters.Add("@id",SqlDbType.Int).Value=id;
            cmd.Parameters.Add("@code",SqlDbType.NVarChar,50).Value=code;
            cmd.Parameters.Add("@name",SqlDbType.NVarChar,50).Value=name;
            cmd.Parameters.Add("@pricebuy", SqlDbType.Decimal).Value=pricebuy;
            cmd.Parameters.Add("@priceselas", SqlDbType.Decimal).Value=priceselas;
            cmd.Parameters.Add("@priceern", SqlDbType.Decimal).Value=priceern;
            cmd.Parameters.Add("@qty", SqlDbType.Decimal).Value=qty;
            cmd.Parameters.Add("@img", SqlDbType.Image).Value=img;
            cmd.Parameters.Add("@itemid", SqlDbType.Int).Value=itemid;

            settingspro.con.Open();
            cmd.ExecuteNonQuery();
            settingspro.con.Close();
            MessageBox.Show("تم الحفظ بنجاح");
        }


        public void addproductnoimg(int id, string code, string name, double pricebuy, double priceselas, double priceern, double qty, int itemid)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "addproductsp0";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@code", SqlDbType.NVarChar, 50).Value = code;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
            cmd.Parameters.Add("@pricebuy", SqlDbType.Decimal).Value = pricebuy;
            cmd.Parameters.Add("@priceselas", SqlDbType.Decimal).Value = priceselas;
            cmd.Parameters.Add("@priceern", SqlDbType.Decimal).Value = priceern;
            cmd.Parameters.Add("@qty", SqlDbType.Decimal).Value = qty;
            
            cmd.Parameters.Add("@itemid", SqlDbType.Int).Value = itemid;

            settingspro.con.Open();
            cmd.ExecuteNonQuery();
            settingspro.con.Close();
            MessageBox.Show("تم الحفظ بنجاح");
        }

        public void updatproductnoimg(int id, string code, string name, double pricebuy, double priceselas, double priceern, double qty, int itemid)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateproductnoimgsp";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@code", SqlDbType.NVarChar, 50).Value = code;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
            cmd.Parameters.Add("@pricebuy", SqlDbType.Decimal).Value = pricebuy;
            cmd.Parameters.Add("@priceselas", SqlDbType.Decimal).Value = priceselas;
            cmd.Parameters.Add("@priceern", SqlDbType.Decimal).Value = priceern;
            cmd.Parameters.Add("@qty", SqlDbType.Decimal).Value = qty;

            cmd.Parameters.Add("@itemid", SqlDbType.Int).Value = itemid;

            settingspro.con.Open();
            cmd.ExecuteNonQuery();
            settingspro.con.Close();
            MessageBox.Show("تم التعديل بنجاح");
        }

        public void updateproductwithimg(int id, string code, string name, double pricebuy, double priceselas, double priceern, double qty, byte[] img, int itemid)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateproductwithimgsp";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@code", SqlDbType.NVarChar, 50).Value = code;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
            cmd.Parameters.Add("@pricebuy", SqlDbType.Decimal).Value = pricebuy;
            cmd.Parameters.Add("@priceselas", SqlDbType.Decimal).Value = priceselas;
            cmd.Parameters.Add("@priceern", SqlDbType.Decimal).Value = priceern;
            cmd.Parameters.Add("@qty", SqlDbType.Decimal).Value = qty;
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = img;
            cmd.Parameters.Add("@itemid", SqlDbType.Int).Value = itemid;

            settingspro.con.Open();
            cmd.ExecuteNonQuery();
            settingspro.con.Close();
            MessageBox.Show("تم التعديل بنجاح");
        }
        //int countprod;
        //public int numofproductinstore(int itemid)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = settingspro.con;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select COUNT(id) from tbl_product where iditem="+itemid;
        //    settingspro.con.Open();
        //    countprod=Convert.ToInt32( cmd.ExecuteScalar());
        //    settingspro.con.Close();
        //    return countprod;
        //}

        public void deletproduct(string code)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tbl_product where code='" + code + "'";

            settingspro.con.Open();
            cmd.ExecuteNonQuery();
            settingspro.con.Close();
            MessageBox.Show("تم الحذف");
        }

        public void deletimg(string code)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  tbl_product set  img=NULL where code='" + code+"'";

            settingspro.con.Open();
            cmd.ExecuteNonQuery();
            settingspro.con.Close();
            MessageBox.Show("تم الحذف");
        }

        public DataTable prodimg(string code)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = settingspro.con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateproductsp";
            cmd.Parameters.Add("@code", SqlDbType.NVarChar, 50).Value = code;
            settingspro.con.Open();
            dt.Load(cmd.ExecuteReader());
            settingspro.con.Close();

            return dt;
        }
    }
}
