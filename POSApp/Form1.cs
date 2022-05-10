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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            controllistdesigin();
        }

        private void controllistdesigin()
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            btnstore.Enabled = false;
            btnmouard.Enabled = false;
            btnbuy.Enabled = false;
            btnsales.Enabled = false;
            btncust.Enabled = false;
            btnuse.Enabled = false;
            btnlogout.Enabled = false;
           // panel3.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panel3.Visible==true)
            {
                panel3.Visible = false;
            }
            if (panel4.Visible == true)
            {
                panel4.Visible = false;
            }
            if (panel6.Visible == true)
            {
                panel6.Visible = false;
            }
            if (panel7.Visible == true)
            {
                panel7.Visible = false;
            }
            if (panel8.Visible == true)
            {
                panel8.Visible = false;
            }
            if (panel9.Visible == true)
            {
                panel9.Visible = false;
            }
           
        }

        private void showsubmenu(Panel subminue)
        {
            if (subminue.Visible == false)
            {
                hidesubmenu();
                subminue.Visible = true;
            }
            else
            {
                subminue.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dddsd");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showsubmenu(panel3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnstore.Enabled = false;
            btnmouard.Enabled = false;
            btnbuy.Enabled = false;
            btnsales.Enabled = false;
            btncust.Enabled = false;
            btnuse.Enabled = false;
            btnlogin.Enabled = true;
            btnlogout.Enabled = false;
            hidesubmenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            showsubmenu(panel4);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            showsubmenu(panel5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginfrm log = new loginfrm();
            log.Show();
            hidesubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            itemfrm frm = new itemfrm();
            frm.Show();
            hidesubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            productfrm prod = new productfrm();
            prod.Show();
            hidesubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            showsubmenu(panel6);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            showsubmenu(panel7);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            showsubmenu(panel8);
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            showsubmenu(panel9);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            customers c = new customers();
            c.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            salesfrm fs = new salesfrm();
            fs.Show();
        }
    }
}
