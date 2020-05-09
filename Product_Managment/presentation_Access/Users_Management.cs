using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Managment.presentation_Access
{
    public partial class Form1 : Form
    {
        Business_Access.Login_Class lg = new Business_Access.Login_Class();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = lg.get_all_users();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            password_tb.PasswordChar = '*';
            
        }

       

        private void new_bt_Click(object sender, EventArgs e)
        {
            username_tb.ReadOnly = false;
            full_name_tb.Clear();
            username_tb.Clear();
            password_tb.Clear();
            
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
            checkBox4.CheckState = CheckState.Unchecked;
            checkBox6.CheckState = CheckState.Unchecked;

        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            byte[] auth = new byte[6];
            if (checkBox1.CheckState == CheckState.Checked)
            {
                auth[0] = 1;
            }
            else
            {
                auth[0] = 0;
            }


            if (checkBox2.CheckState == CheckState.Checked)
            {
                auth[1] = 1;
            }
            else
            {
                auth[1] = 0;
            }

            if (checkBox3.CheckState == CheckState.Checked)
            {
                auth[2] = 1;
            }
            else
            {
                auth[2] = 0;
            }

            if (checkBox4.CheckState == CheckState.Checked)
            {
                auth[3] = 1;
            }
            else
            {
                auth[3] = 0;
            }

            if (checkBox5.CheckState == CheckState.Checked)
            {
                auth[4] = 1;
            }
            else
            {
                auth[4] = 0;
            }

            if (checkBox6.CheckState == CheckState.Checked)
            {
                auth[5] = 1;
            }
            else
            {
                auth[5] = 0;
            }
            if (full_name_tb.Text != string.Empty&& username_tb.Text != string.Empty && password_tb.Text != string.Empty )
            {
                lg.add_user(full_name_tb.Text, username_tb.Text, password_tb.Text, comboBox1.Text, auth);
                MessageBox.Show("User Added Successfully", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView1.DataSource = lg.get_all_users();
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
            else
            {
                MessageBox.Show("Please Complete The Info Then Press Add", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try {
                username_tb.ReadOnly = true;
                comboBox1.Text = string.Empty;
                full_name_tb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                username_tb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox1.SelectedText = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                password_tb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                byte[] auyh = (byte[])dataGridView1.CurrentRow.Cells[4].Value;

                if (auyh[0] == 1)
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }

                if (auyh[1] == 1)
                {
                    checkBox2.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }
                if (auyh[2] == 1)
                {
                    checkBox3.Checked = true;
                }
                else
                {
                    checkBox3.Checked = false;
                }
                if (auyh[3] == 1)
                {
                    checkBox4.Checked = true;
                }
                else
                {
                    checkBox4.Checked = false;
                }
                if (auyh[4] == 1)
                {
                    checkBox5.Checked = true;
                }
                else
                {
                    checkBox5.Checked = false;
                }

                if (auyh[5] == 1)
                {
                    checkBox6.Checked = true;
                }
                else
                {
                    checkBox6.Checked = false;
                }
            }
            catch
            {
                return;
            }

        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Do You Want Delete User ", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                lg.delete_user(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                MessageBox.Show("Deleted  Successfully", " Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = lg.get_all_users();
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }

            
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            byte[] auth = new byte[6];
            if (checkBox1.CheckState == CheckState.Checked)
            {
                auth[0] = 1;
            }
            else
            {
                auth[0] = 0;
            }


            if (checkBox2.CheckState == CheckState.Checked)
            {
                auth[1] = 1;
            }
            else
            {
                auth[1] = 0;
            }

            if (checkBox3.CheckState == CheckState.Checked)
            {
                auth[2] = 1;
            }
            else
            {
                auth[2] = 0;
            }

            if (checkBox4.CheckState == CheckState.Checked)
            {
                auth[3] = 1;
            }
            else
            {
                auth[3] = 0;
            }

            if (checkBox5.CheckState == CheckState.Checked)
            {
                auth[4] = 1;
            }
            else
            {
                auth[4] = 0;
            }

            if (checkBox6.CheckState == CheckState.Checked)
            {
                auth[5] = 1;
            }
            else
            {
                auth[5] = 0;
            }
            if (full_name_tb.Text != string.Empty && username_tb.Text != string.Empty && password_tb.Text != string.Empty)
            {
                lg.edit_user(full_name_tb.Text, username_tb.Text, password_tb.Text, comboBox1.Text, auth);
                MessageBox.Show("User Added Successfully", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Please Complete The Info Then Press Add", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dataGridView1.DataSource = lg.get_all_users();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void username_tb_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void username_tb_Validated(object sender, EventArgs e)
        {
            try {
                if (lg.add_user_verfy(username_tb.Text).Rows.Count > 0)
                {
                    username_tb.SelectionStart = 0;
                    username_tb.SelectionLength = username_tb.TextLength;
                    verfy_lb.Text = "This Username Already Existed  ";

                }
                else
                {
                    verfy_lb.Text = "Available ";
                    verfy_lb.ForeColor = Color.Green;
                }
            }
            catch
            {
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                checkBox1.CheckState = CheckState.Checked;
                checkBox2.CheckState = CheckState.Checked;
                checkBox3.CheckState = CheckState.Checked;
                checkBox4.CheckState = CheckState.Checked;
                checkBox6.CheckState = CheckState.Checked;
            }
        }
    }
}
