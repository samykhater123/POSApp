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
    public partial class itemfrm : Form
    {
        public itemfrm()
        {
            InitializeComponent();
            items i = new items();
            i.loaditem("loaditemsp");
            dGV.DataSource = i.dt;
            dGV.Columns[0].HeaderText = "رقم الصنف";
            dGV.Columns[1].HeaderText = "رقم الصنف";

            txtid.Text = i.maxid("getmaxid").ToString();
            txtname.Select();
            btnupdate.Enabled = false;
            btnadd.Enabled = true;
            btndlete.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void itemfrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("ادخل اسم الصنف");
                txtname.Select();
            }
            else
            {
                items item = new items();
                item.additem(txtid.Text, txtname.Text);
                items i = new items();
                i.loaditem("loaditemsp");
                dGV.DataSource = i.dt;
                txtid.Text = i.maxid("getmaxid").ToString();
                txtname.Text = "";
                txtname.Select();
            }
        }

        
        private void dGV_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.Text = dGV.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dGV.CurrentRow.Cells[1].Value.ToString();
            btnadd.Enabled = false;
            btnupdate.Enabled = true;
            btndlete.Enabled = true;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            items i = new items();
           
            txtid.Text = i.maxid("getmaxid").ToString();
            txtname.Text = "";
            btnadd.Enabled = true;
            btnupdate.Enabled = false;
            btndlete.Enabled = false;
        }

        private void btndlete_Click(object sender, EventArgs e)
        {
            items i = new items();

            if(MessageBox.Show("هل تريد حذف الصنف", dGV.CurrentRow.Cells[1].Value+ "  اسم الصنف ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                i.delete(txtid.Text);
                i.loaditem("loaditemsp");
                dGV.DataSource = i.dt;
                txtid.Text = i.maxid("getmaxid").ToString();
                txtname.Text = "";
                txtname.Select();
            }
            else
            {
                return;
            }
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            items i = new items();
            i.updateitem(txtid.Text,txtname.Text);
            i.loaditem("loaditemsp");
            dGV.DataSource = i.dt;
            txtid.Text = i.maxid("getmaxid").ToString();
            txtname.Text = "";
            txtname.Select();
            
        }
    }
}
