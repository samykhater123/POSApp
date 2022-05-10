using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSapp
{
    public partial class salesfrm : Form
    {
        int customertype = 1;


        public salesfrm()
        {
            InitializeComponent();
            ordersales ods = new ordersales();
            txtbillNo.Text= ods.maxid("maxidfroordesale").ToString().Trim();
            txtsaler.Text = users.username.Trim();
            
        }

        void calcamuontdiscunt()
        {
            double amount =Convert.ToDouble( txtprice.Text) *Convert.ToDouble( txtqty.Text);
            double discount= Convert.ToDouble(txtdiscount.Text) * amount/100;
            double totalamount = amount - discount;
            txttotal.Text = totalamount.ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            
            txtbilldate.Text = DateTime.Now.ToString();
        }

        private void salesfrm_Load(object sender, EventArgs e)
        {

        }

        private void radioBcach_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBcach.Checked==true)
            {
                customertype = 1;
            }
        }

        private void radioBagel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBagel.Checked == true)
            {
                customertype = 2;
            }
        }

        private void radioBmotabcy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBmotabcy.Checked == true)
            {
                customertype = 3;
            }
        }

        //private void txtphone_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode==Keys.Enter)
        //    {
        //        customer c = new customer();

        //        c.getcustbyphone(txtphone.Text);
        //        txtcustname.Text = c.name.Trim();
        //        txtcustaddress.Text = c.address.Trim();
        //    }
        //}

        private void txtsaler_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                customer c = new customer();

                c.getcustbyphone(txtphone.Text);
                txtcustname.Text = c.name.Trim();
                txtcustaddress.Text = c.address.Trim();

               


                if (txtcustname.Text =="")
                {
                   
                    txtphone.SelectAll();
                    txtphone.Copy();
                    ucaddcust1.txtcustphone.Clear();
                    ucaddcust1.txtcustphone.Paste();
                    ucaddcust1.Visible = true;

                }
                else
                {
                    ucaddcust1.Visible = false;
                }
            }
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucaddcust1_Load(object sender, EventArgs e)
        {

        }

        

        private void txtbarcode_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            calcamuontdiscunt();
        }

        private void txtqty_Enter(object sender, EventArgs e)
        {
            txtdiscount.Focus();
        }

        private void txtbarcode_Enter(object sender, EventArgs e)
        {
        }

        private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void txtbarcode_Leave(object sender, EventArgs e)
        {
            ordersales os = new ordersales();
            if (txtbarcode.Text == "")
            {
                return;
            }
            else
            {
                os.getprodbyparcode(txtbarcode.Text);
                txtproductname.Text = os.dto.Rows[0][0].ToString();
                txtprice.Text = os.dto.Rows[0][1].ToString();
                txtqty.Focus();
            }
        }
    }
}
