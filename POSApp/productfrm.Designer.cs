
namespace POSapp
{
    partial class productfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndlete = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuyprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtseal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtreph = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cBoxitem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.btndeletimg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(428, 266);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 35);
            this.btnupdate.TabIndex = 16;
            this.btnupdate.Text = "تعديل";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndlete
            // 
            this.btndlete.Location = new System.Drawing.Point(230, 266);
            this.btndlete.Name = "btndlete";
            this.btndlete.Size = new System.Drawing.Size(75, 35);
            this.btndlete.TabIndex = 15;
            this.btndlete.Text = "حذف";
            this.btndlete.UseVisualStyleBackColor = true;
            this.btndlete.Click += new System.EventHandler(this.btndlete_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(11, 266);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 35);
            this.btnrefresh.TabIndex = 14;
            this.btnrefresh.Text = "تحديث";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(518, 93);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(331, 29);
            this.txtname.TabIndex = 13;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(868, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "اسم المنتج";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(518, 9);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(331, 29);
            this.txtid.TabIndex = 11;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(869, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "رقم المنتج";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(647, 266);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 35);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "اضافة";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(518, 50);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(331, 29);
            this.txtcode.TabIndex = 18;
            this.txtcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(868, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "الكود";
            // 
            // txtbuyprice
            // 
            this.txtbuyprice.Location = new System.Drawing.Point(518, 131);
            this.txtbuyprice.Name = "txtbuyprice";
            this.txtbuyprice.Size = new System.Drawing.Size(331, 29);
            this.txtbuyprice.TabIndex = 20;
            this.txtbuyprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbuyprice.TextChanged += new System.EventHandler(this.txtseal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(868, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "سعر الشراء";
            // 
            // txtseal
            // 
            this.txtseal.Location = new System.Drawing.Point(518, 171);
            this.txtseal.Name = "txtseal";
            this.txtseal.Size = new System.Drawing.Size(331, 29);
            this.txtseal.TabIndex = 22;
            this.txtseal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtseal.TextChanged += new System.EventHandler(this.txtseal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(868, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "سعر البيع";
            // 
            // txtreph
            // 
            this.txtreph.Location = new System.Drawing.Point(11, 180);
            this.txtreph.Name = "txtreph";
            this.txtreph.ReadOnly = true;
            this.txtreph.Size = new System.Drawing.Size(329, 29);
            this.txtreph.TabIndex = 24;
            this.txtreph.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtreph.TextChanged += new System.EventHandler(this.txtreph_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "الربح";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(11, 215);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(329, 29);
            this.txtqty.TabIndex = 26;
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "الكمية المخزنة";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "الصورة";
            // 
            // cBoxitem
            // 
            this.cBoxitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxitem.FormattingEnabled = true;
            this.cBoxitem.Location = new System.Drawing.Point(518, 212);
            this.cBoxitem.Name = "cBoxitem";
            this.cBoxitem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cBoxitem.Size = new System.Drawing.Size(331, 29);
            this.cBoxitem.TabIndex = 29;
            this.cBoxitem.SelectionChangeCommitted += new System.EventHandler(this.cBoxitem_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(868, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "الصنف";
            // 
            // dgvproduct
            // 
            this.dgvproduct.AllowUserToAddRows = false;
            this.dgvproduct.AllowUserToDeleteRows = false;
            this.dgvproduct.AllowUserToOrderColumns = true;
            this.dgvproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Location = new System.Drawing.Point(12, 307);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.ReadOnly = true;
            this.dgvproduct.RowTemplate.Height = 25;
            this.dgvproduct.Size = new System.Drawing.Size(939, 221);
            this.dgvproduct.TabIndex = 31;
            this.dgvproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduct_CellContentClick);
            this.dgvproduct.DoubleClick += new System.EventHandler(this.dgvproduct_DoubleClick);
            this.dgvproduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvproduct_MouseClick);
            // 
            // oFD
            // 
            this.oFD.FileName = "openFileDailog1";
            // 
            // btndeletimg
            // 
            this.btndeletimg.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndeletimg.Location = new System.Drawing.Point(340, 134);
            this.btndeletimg.Name = "btndeletimg";
            this.btndeletimg.Size = new System.Drawing.Size(46, 41);
            this.btndeletimg.TabIndex = 32;
            this.btndeletimg.Text = "x";
            this.btndeletimg.UseVisualStyleBackColor = true;
            this.btndeletimg.Click += new System.EventHandler(this.btndeletimg_Click);
            // 
            // productfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(963, 540);
            this.Controls.Add(this.btndeletimg);
            this.Controls.Add(this.dgvproduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cBoxitem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtreph);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtseal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbuyprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndlete);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "productfrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المنتجات";
            this.Load += new System.EventHandler(this.productfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndlete;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbuyprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtseal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtreph;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBoxitem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.OpenFileDialog oFD;
        private System.Windows.Forms.Button btndeletimg;
    }
}