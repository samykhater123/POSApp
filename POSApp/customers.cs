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
    public partial class customers : Form
    {
        public customers()
        {
            InitializeComponent();
            btndlete.Enabled = false;
            btnupdate.Enabled = false;
            customer c = new customer();
            c.loaditem("loadcust");
            dgvproduct.DataSource = c.dt;

            dgvproduct.Columns[0].HeaderText = "الرقم";
            dgvproduct.Columns[1].HeaderText = "التلفون";
            dgvproduct.Columns[2].HeaderText = "الاسم ";
            dgvproduct.Columns[3].HeaderText = "العنوان";
            dgvproduct.Columns[4].HeaderText = "الايميل";
            dgvproduct.Columns[5].HeaderText = "ملاحظات";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customers_Load(object sender, EventArgs e)
        {

        }

        public void clear()
        {
             txtname.Text="";
             txtphone.Text="";
             txtaddres.Text="";
             txtemail.Text="";
             txtnote.Text="";
             txtsearch.Text="";

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            customer c = new customer();

            if (txtname.Text=="")
            {
                MessageBox.Show("ادخل اسم العميل");
                return;
            }else if(txtphone.Text==""){
                MessageBox.Show("ادخل تلفون العميل");
                return;
            }
            else if (txtaddres.Text == "")
            {
                MessageBox.Show("ادخل عنوان العميل");
                return;
            }

            string name = txtname.Text;
            string phone = txtphone.Text;
            string address = txtaddres.Text;
            string email = txtemail.Text;
            string note = txtnote.Text;
            c.addcustomer(phone,name,address,email,note);
            clear();
            c.loaditem("loadcust");
            dgvproduct.DataSource = c.dt;
        }


        private void dgvproduct_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            txtphone.Text = dgvproduct.CurrentRow.Cells[1].Value.ToString().Trim();
            txtname.Text = dgvproduct.CurrentRow.Cells[2].Value.ToString().Trim();
            txtaddres.Text = dgvproduct.CurrentRow.Cells[3].Value.ToString().Trim();
            txtemail.Text = dgvproduct.CurrentRow.Cells[4].Value.ToString().Trim();
            txtnote.Text = dgvproduct.CurrentRow.Cells[5].Value.ToString().Trim();

            btndlete.Enabled = true;
            btnupdate.Enabled = true;
            btnadd.Enabled = false;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.loaditem("loadcust");
            dgvproduct.DataSource = c.dt;
            btndlete.Enabled = false;
            btnupdate.Enabled = false;
            btnadd.Enabled = true;
            clear();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            string name = txtname.Text;
            string phone = txtphone.Text;
            string address = txtaddres.Text;
            string email = txtemail.Text;
            string note = txtnote.Text;
            c.updatecustomer(phone, name, address, email, note);

            c.loaditem("loadcust");
            dgvproduct.DataSource = c.dt;
            btndlete.Enabled = false;
            btnupdate.Enabled = false;
            clear();
        }

        private void btndlete_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.deletcust(txtphone.Text);
            c.loaditem("loadcust");
            dgvproduct.DataSource = c.dt;
            btndlete.Enabled = false;
            btnupdate.Enabled = false;
            btnadd.Enabled = true;
            clear();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.searchcust(txtsearch.Text);
            dgvproduct.DataSource = c.dt2;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            customer c = new customer();
            c.searchcust(txtsearch.Text);
            dgvproduct.DataSource = c.dt2;
        }

        private void txtphone_Validating(object sender, CancelEventArgs e)
        {
            customer c = new customer();
            DataTable dtl = new DataTable();
            dtl= c.checkphonepk(txtphone.Text);

            if (dtl.Rows.Count>0)
            {
                MessageBox.Show("رقم الهاتف موجود من قبل");
                txtphone.Text = "";
                txtphone.Select();
            }
          
        }
    }
}
