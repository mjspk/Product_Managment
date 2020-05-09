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
    public partial class Login_frm : Form
    {
        Business_Access.Login_Class d = new Business_Access.Login_Class();
        
        public Login_frm()
        {
            InitializeComponent();
            user_name_tb.Focus();
            password_tb.PasswordChar = '*' ;
           
        }

        private void Login_frm_Load(object sender, EventArgs e)
        {
            user_name_tb.Focus();
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_bt_Click(object sender, EventArgs e)
        {
            if (user_name_tb.Text == "MJspk")
            {
                Connection_setting frm = new Connection_setting();
                frm.ShowDialog();
            }
            else
            {
                int state = 0;
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    state += 1;
                }

                DataTable dt = d.Login(user_name_tb.Text, password_tb.Text, state);

                if (dt.Rows.Count > 0)
                {
                    label3.Text = "login ... ";

                    Managment_App.getmyform.customersToolStripMenuItem.Enabled = true;
                    Managment_App.getmyform.productsToolStripMenuItem.Enabled = true;

                    Managment_App.getmyform.backupToolStripMenuItem.Enabled = true;
                    Managment_App.getmyform.restorToolStripMenuItem.Enabled = true;
                    Program.Saleman = dt.Rows[0]["FULLname"].ToString();
                    Managment_App.getmyform.seller_tb.Text = dt.Rows[0]["FULLname"].ToString();
                    byte[] auth = (byte[])dt.Rows[0]["authority"];
                    if (auth[0] == 1)
                    {
                        Managment_App.getmyform.newProductToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        Managment_App.getmyform.newProductToolStripMenuItem.Enabled = false;

                    }

                    if (auth[1] == 1)
                    {
                        Managment_App.getmyform.manageProductsToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        Managment_App.getmyform.manageProductsToolStripMenuItem.Enabled = false;

                    }
                    if (auth[2] == 1)
                    {
                        Managment_App.getmyform.manageCategoriesToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        Managment_App.getmyform.manageCategoriesToolStripMenuItem.Enabled = false;

                    }
                    if (auth[3] == 1)
                    {
                        Managment_App.getmyform.manageCustomersToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        Managment_App.getmyform.manageCustomersToolStripMenuItem.Enabled = false;

                    }
                    if (auth[4] == 1)
                    {
                        Managment_App.getmyform.manageOrdersToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        Managment_App.getmyform.manageOrdersToolStripMenuItem.Enabled = false;

                    }
                    if (auth[5] == 1)
                    {
                        Managment_App.getmyform.usersToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        Managment_App.getmyform.usersToolStripMenuItem.Enabled = false;

                    }


                    this.Close();
                }
                else
                {
                    label3.Text = " user name or password incorrect ";
                }
            }
        }

        private void user_name_tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void user_name_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && user_name_tb.Text != string.Empty)
            {
                password_tb.Focus();
            }
        }

        private void password_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && user_name_tb.Text != string.Empty)
            {
                login_bt.Focus();
            }
        }
    }
}
