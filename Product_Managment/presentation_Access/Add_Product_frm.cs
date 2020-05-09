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

namespace Product_Managment.presentation_Access
{
    public partial class Add_Product_frm : Form
    {
        public string state = "add";
        Business_Access.Product_Class prd = new Business_Access.Product_Class();
        public Add_Product_frm()
        {
            InitializeComponent();
            categoty_cmb.DataSource =  prd.get_all_Category();
            categoty_cmb.DisplayMember = "Description_CAT";
            categoty_cmb.ValueMember = "ID_CAT";
            
        }

        

        private void Add_Product_frm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                try { 
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] image = ms.ToArray();

                prd.add_product(product_id_tb.Text, product_label_tb.Text, Convert.ToInt32(product_quntity_tb.Text), product_price_tb.Text, image, Convert.ToInt32(categoty_cmb.SelectedValue));

                MessageBox.Show("add Successfully", " Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Product_Management_frm.getmyform.dataGridView1.DataSource = prd.get_all_product();
            }

                 catch
                {
                    return;
                }
            }

            if (state == "update")
            {
                try {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] image = ms.ToArray();

                    prd.update_product(product_id_tb.Text, product_label_tb.Text, Convert.ToInt32(product_quntity_tb.Text), product_price_tb.Text, image, Convert.ToInt32(categoty_cmb.SelectedValue));

                    MessageBox.Show("Update Successfully", " Update Product Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Product_Management_frm.getmyform.dataGridView1.DataSource = prd.get_all_product();
                }
                catch
                {
                    return;
                }
            }

        }

        private void product_id_tb_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable dt = new DataTable();
                dt = prd.add_product_verfy(product_id_tb.Text);
                if (dt.Rows.Count > 0)
                {
                    label7.Text = " This Product Already Exist";
                    product_id_tb.Focus();
                    product_id_tb.SelectionStart = 0;
                    product_id_tb.SelectionLength = product_id_tb.TextLength;

                }
            }

        }

        

       
      

        private void cancel_bt_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image file |*.JPG;*.PNG;*.GIF;*.BMP;*.ICO";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);

            }
        }
    }
}
