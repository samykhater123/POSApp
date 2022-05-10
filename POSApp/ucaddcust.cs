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
    public partial class ucaddcust : UserControl
    {
        public ucaddcust()
        {
            InitializeComponent();
            txtcustname.Focus();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            customer c = new customer();

            if (txtcustname.Text == "")
            {
                MessageBox.Show("ادخل اسم العميل");
                return;
            }
            else if (txtcustphone.Text == "")
            {
                MessageBox.Show("ادخل تلفون العميل");
                return;
            }
            else if (txtcustaddress.Text == "")
            {
                MessageBox.Show("ادخل عنوان العميل");
                return;
            }

            string name = txtcustname.Text;
            string phone = txtcustphone.Text;
            string address = txtcustaddress.Text;
            string email = "";
            string note = "";

            
            c.addcustomer(phone, name, address, email, note);
           
            
            this.Visible = false;
            
        }

        private void ucaddcust_Load(object sender, EventArgs e)
        {

            txtcustphone.Clear();
            txtcustphone.Paste();
            txtcustname.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
