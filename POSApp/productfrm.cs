using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace POSapp
{
    public partial class productfrm : Form
    {
        public productfrm()
        {
            InitializeComponent();

            items i = new items();
            i.loaditem("loaditemsp");
            cBoxitem.DataSource= i.dt;

            cBoxitem.DisplayMember = "name-item";
            cBoxitem.ValueMember = "id";
            cBoxitem.SelectedIndex  =-1;
            //cBoxitem.Text.  ="dsfds";
            procucts prd = new procucts();
            txtid.Text= prd.maxid("maxidprod").ToString();
            prd.loaditem("loadvwproduct");
            dgvproduct.DataSource = prd.dt;
            dgvproduct.Columns[0].HeaderText = "الرقم";
            dgvproduct.Columns[1].HeaderText = "الكود";
            dgvproduct.Columns[2].HeaderText = "اسم المنتج";
            dgvproduct.Columns[3].HeaderText = "سعر الشراء";
            dgvproduct.Columns[4].HeaderText = "سعرالبيع";
            dgvproduct.Columns[5].HeaderText = "الربح";
            dgvproduct.Columns[6].HeaderText = "الكمية";
            dgvproduct.Columns[7].HeaderText = "الصورة";

            //dgvproduct.Columns[7].Frozen = true;
            //((DataGridViewImageColumn)dgvproduct.Columns[7]= DataGridViewImageCellLayout.Stretch;
            //((DataGridViewImageColumn)dgvproduct.Columns[7]).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvproduct.Columns[8].HeaderText = "الصنف";

            pictureBox1.Image = null;



            btndlete.Enabled = false;
            btnupdate.Enabled = false;

        }

        private void productfrm_Load(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            cleartxt();
            procucts prd = new procucts();
            txtid.Text = prd.maxid("maxidprod").ToString();
            btnadd.Enabled = true;
            btndlete.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
           // oFD.Filter = "Image |*.jpg ; *.prg; *.jpeg";
            if (oFD.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(oFD.FileName);
            }
           
            ;
        }

        private void cBoxitem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //procucts prd = new procucts();
            //txtcode.Text = cBoxitem.SelectedValue.ToString();

            //txtqty.Text = prd.numofproductinstore(cBoxitem.SelectedIndex).ToString();
        }

        private void txtseal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtreph.Text = (Convert.ToDouble(txtseal.Text) - Convert.ToDouble(txtbuyprice.Text)).ToString();
            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void txtreph_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtreph.Text)<=0)
                {
                    txtreph.BackColor = Color.Red;
                }
                else
                {
                    txtreph.BackColor = Color.Yellow;
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        public void cleartxt()
        {
            txtcode.Text = "";
            txtname.Text = "";
            txtbuyprice.Text = "";
            txtseal.Text = "";
            txtreph.Text = "";
            txtqty.Text = "";
            cBoxitem.SelectedIndex = -1;

            pictureBox1.Image= null;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txtcode.Text == "")
            {
                MessageBox.Show("ادخل كود المنتج");
                return;
            }
            else if (txtname.Text == "")
            {
                MessageBox.Show("ادخل اسم المنتج");
                return;
            }
            else if (txtbuyprice.Text == "")
            {
                MessageBox.Show("ادخل سعر الشراء المنتج");
                return;
            }
            else if (txtseal.Text == "")
            {
                MessageBox.Show("ادخل سعر البيع المنتج");
                return;
            }
            else if (txtqty.Text == "")
            {
                MessageBox.Show("ادخل كمية المنتج");
                return;
            }
            else if (cBoxitem.SelectedIndex == -1)
            {
                MessageBox.Show("ادخل اسم الصنف");
                return;
            }
            else
            {
                procucts prd = new procucts();
                if (pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    int id = Convert.ToInt32(txtid.Text);
                    string code = txtcode.Text;
                    string name = txtname.Text;
                    double pricebuy = Convert.ToDouble(txtbuyprice.Text);
                    double priceselas = Convert.ToDouble(txtseal.Text);
                    double priceern = Convert.ToDouble(txtreph.Text);
                    double qty = Convert.ToDouble(txtqty.Text);
                    // byte img = Convert.ToDouble(txtqty.Text);
                    int item = Convert.ToInt32(cBoxitem.SelectedValue);

                    procucts pdc = new procucts();

                    pdc.addproduct(id, code, name, pricebuy, priceselas, priceern, qty, img, item);
                    cleartxt();
                    txtid.Text = pdc.maxid("maxidprod").ToString();
                    prd.loaditem("loadvwproduct");
                    dgvproduct.DataSource = prd.dt;
                }

                else
                {

                    int id = Convert.ToInt32(txtid.Text);
                    string code = txtcode.Text;
                    string name = txtname.Text;
                    double pricebuy = Convert.ToDouble(txtbuyprice.Text);
                    double priceselas = Convert.ToDouble(txtseal.Text);
                    double priceern = Convert.ToDouble(txtreph.Text);
                    double qty = Convert.ToDouble(txtqty.Text);
                    // byte img = Convert.ToDouble(txtqty.Text);
                    
                    int item = Convert.ToInt32(cBoxitem.SelectedValue);

                    procucts pdc = new procucts();

                    pdc.addproductnoimg(id, code, name, pricebuy, priceselas, priceern, qty,  item);
                    cleartxt();
                    txtid.Text = pdc.maxid("maxidprod").ToString();
                    prd.loaditem("loadvwproduct");
                    dgvproduct.DataSource = prd.dt;
                }

            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvproduct_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dgvproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvproduct_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text = dgvproduct.CurrentRow.Cells[0].Value.ToString().Trim();
            txtcode.Text = dgvproduct.CurrentRow.Cells[1].Value.ToString().Trim();
            txtname.Text = dgvproduct.CurrentRow.Cells[2].Value.ToString().Trim();
            txtbuyprice.Text = dgvproduct.CurrentRow.Cells[3].Value.ToString().Trim();
            txtseal.Text = dgvproduct.CurrentRow.Cells[4].Value.ToString().Trim();
            txtreph.Text = dgvproduct.CurrentRow.Cells[5].Value.ToString().Trim();
            txtqty.Text = dgvproduct.CurrentRow.Cells[6].Value.ToString().Trim();
            // pictureBox1.InitialImage =Convert.ToByte( dgvproduct.CurrentRow.Cells[6]);
            cBoxitem.Text = dgvproduct.CurrentRow.Cells[8].Value.ToString();
            //string nameitem = dgvproduct.CurrentRow.Cells[8].Value.ToString();
            try
            {
                procucts prd = new procucts();

                byte[] img = (byte[])prd.prodimg(dgvproduct.CurrentRow.Cells[1].Value.ToString()).Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);

            }
            catch (Exception)
            {

                pictureBox1.Image =null;
            }
           
            //cBoxitem.SelectedValue = prd.getid(nameitem);
            btnadd.Enabled = false;
            btndlete.Enabled = true;
            btnupdate.Enabled = true;
        }

        private void btndlete_Click(object sender, EventArgs e)
        {
            procucts prd = new procucts();

            prd.deletproduct(txtcode.Text);
            cleartxt();
            
            txtid.Text = prd.maxid("maxidprod").ToString();
            prd.loaditem("loadvwproduct");
            dgvproduct.DataSource = prd.dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            procucts prd = new procucts();


            if (txtcode.Text == "")
            {
                MessageBox.Show("ادخل كود المنتج");
                return;
            }
            else if (txtname.Text == "")
            {
                MessageBox.Show("ادخل اسم المنتج");
                return;
            }
            else if (txtbuyprice.Text == "")
            {
                MessageBox.Show("ادخل سعر الشراء المنتج");
                return;
            }
            else if (txtseal.Text == "")
            {
                MessageBox.Show("ادخل سعر البيع المنتج");
                return;
            }
            else if (txtqty.Text == "")
            {
                MessageBox.Show("ادخل كمية المنتج");
                return;
            }
            else if (cBoxitem.SelectedIndex == -1)
            {
                MessageBox.Show("ادخل اسم الصنف");
                return;
            }
            else
            {

                int id = Convert.ToInt32(txtid.Text);
                string code = txtcode.Text;
                string name = txtname.Text;
                double pricebuy = Convert.ToDouble(txtbuyprice.Text);
                double priceselas = Convert.ToDouble(txtseal.Text);
                double priceern = Convert.ToDouble(txtreph.Text);
                double qty = Convert.ToDouble(txtqty.Text);
                // byte img = Convert.ToDouble(txtqty.Text);

                int item = Convert.ToInt32(cBoxitem.SelectedValue);
                if (pictureBox1.Image == null)
                {
                    prd.updatproductnoimg(id, code, name, pricebuy, priceselas, priceern, qty, item);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    prd.updateproductwithimg(id, code, name, pricebuy, priceselas, priceern, qty, img, item);
                }
            }
            prd.loaditem("loadvwproduct");
            dgvproduct.DataSource = prd.dt;
            txtid.Text = prd.maxid("maxidprod").ToString();
            cleartxt();
            btnadd.Enabled = true;
            btndlete.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void btndeletimg_Click(object sender, EventArgs e)
        {
            procucts prd = new procucts();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
                prd.deletimg(txtcode.Text);
                prd.loaditem("loadvwproduct");
                dgvproduct.DataSource = prd.dt;
            }
            else
            {
                return;
            }
            
        }
    }
}
