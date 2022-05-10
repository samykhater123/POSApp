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
    public partial class loginfrm : Form
    {
        public loginfrm()
        {
            InitializeComponent();
            txtuser.Select();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            users user = new users();

          bool res=  user.login(txtuser.Text, txtpass.Text);
            if(res==true)
            {
                var f = Application.OpenForms["Form1"] as Form1;
                f.btnstore.Enabled = true;
                f.btnmouard.Enabled = true;
                f.btnbuy.Enabled = true;
                f.btnsales.Enabled = true;
                f.btncust.Enabled = true;
                f.btnuse.Enabled = true;
                
                f.btnlogout.Enabled = true;
                f.btnlogin.Enabled = false;

                txtpass.Text = "";
                txtuser.Text = "";
                Close();
                
            }
            else {
                txtpass.Text = "";
                txtuser.Text = "";
            }
        }
    }
}
