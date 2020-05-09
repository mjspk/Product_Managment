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
    public partial class Customer_Management : Form
    {
        Business_Access.Customers_Class cc = new Business_Access.Customers_Class();
        int position;
        BindingManagerBase bmb;
        public Customer_Management()
        {
            InitializeComponent();
            DataTable dt = cc.get_all_customer();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            bmb = this.BindingContext[dt];
            label_position.Text = (bmb.Position + 1) + " / " + bmb.Count;
            try
            {
                pictureBox1.Image = null;
                firstname_bt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lastname_tb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tell_tb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                email_tb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                byte[] image = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }


        }

       
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            try {
                Business_Access.Customers_Class cc = new Business_Access.Customers_Class();
                byte[] image;

                if (pictureBox1.Image == null)
                {
                    string state = "no_image";

                    image = new byte[0];

                    cc.add_customer(firstname_bt.Text, lastname_tb.Text, tell_tb.Text, email_tb.Text, image, state);

                    MessageBox.Show("add Successfully", " Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                else if (pictureBox1.Image != null)
                {
                    string state = "with_image";
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    image = ms.ToArray();

                    cc.add_customer(firstname_bt.Text, lastname_tb.Text, tell_tb.Text, email_tb.Text, image, state);

                    MessageBox.Show("add Successfully", " Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dataGridView1.DataSource = cc.get_all_customer();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                

            }
            catch
            {
                return;
            }
            add_bt.Enabled = false;
            next_bt.Enabled = true;

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

        private void new_bt_Click(object sender, EventArgs e)
        {
            firstname_bt.Clear();
            lastname_tb.Clear();
            tell_tb.Clear();
            email_tb.Clear();
            pictureBox1.Image = null;
            firstname_bt.Focus();
            add_bt.Enabled = true;
            next_bt.Enabled = false;
        }

        private void firstname_bt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                lastname_tb.Focus();
            }
        }

        private void lastname_tb_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                tell_tb.Focus();
            }
        }

        private void tell_tb_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                email_tb.Focus();
            }
        }

        private void email_tb_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                pictureBox1.Focus();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try {
                pictureBox1.Image = null;
                firstname_bt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lastname_tb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tell_tb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                email_tb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                byte[] image = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }

        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Do You Want Delete Customer ", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cc.delete_customer(Convert.ToInt32( this.dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Deleted  Successfully", " Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = cc.get_all_customer();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                
            }
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            try
            {
                Business_Access.Customers_Class cc = new Business_Access.Customers_Class();
                byte[] image;

                if (pictureBox1.Image == null)
                {
                    string state = "no_image";

                    image = new byte[0];

                    cc.update_customer((Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value)), firstname_bt.Text, lastname_tb.Text, tell_tb.Text, email_tb.Text, image, state);

                    MessageBox.Show("Edited Successfully", " Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                else if (pictureBox1.Image != null)
                {
                    string state = "with_image";
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    image = ms.ToArray();

                    cc.update_customer((Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value)), firstname_bt.Text, lastname_tb.Text, tell_tb.Text, email_tb.Text, image, state);

                    MessageBox.Show("add Successfully", " Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dataGridView1.DataSource = cc.get_all_customer();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                
            }
            catch
            {
                return;
            }
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
            dt = cc.Search_customer(search_tb.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cc.Search_customer(search_tb.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;

        }




        void navigation(int index)
        {
            try {
                pictureBox1.Image = null;
                DataTable dt = cc.get_all_customer(); ;
                firstname_bt.Text = dt.Rows[index][1].ToString();
                lastname_tb.Text = dt.Rows[index][2].ToString();
                tell_tb.Text = dt.Rows[index][3].ToString();
                email_tb.Text = dt.Rows[index][4].ToString();
                byte[] image = (byte[])dt.Rows[index][5];
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }

        }

        private void first_bt_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            label_position.Text = (bmb.Position + 1) + " / " + bmb.Count;
            try
            {
                pictureBox1.Image = null;
                firstname_bt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lastname_tb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tell_tb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                email_tb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                byte[] image = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }

        }

        private void previous_bt_Click(object sender, EventArgs e)
        {

            bmb.Position -= 1;
            label_position.Text = (bmb.Position + 1) + " / " + bmb.Count;
            try
            {
                pictureBox1.Image = null;
                firstname_bt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lastname_tb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tell_tb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                email_tb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                byte[] image = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }

        private void next_bt_Click(object sender, EventArgs e)
        {



            bmb.Position += 1;
            label_position.Text = (bmb.Position + 1) + " / " + bmb.Count;
            try
            {
                pictureBox1.Image = null;
                firstname_bt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lastname_tb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tell_tb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                email_tb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                byte[] image = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }


        }

        private void last_bt_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            label_position.Text = (bmb.Position + 1) + " / " + bmb.Count;
            try
            {
                pictureBox1.Image = null;
                firstname_bt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lastname_tb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tell_tb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                email_tb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                byte[] image = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
