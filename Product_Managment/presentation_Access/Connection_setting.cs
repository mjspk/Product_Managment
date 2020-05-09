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
    public partial class Connection_setting : Form
    {
        public Connection_setting()
        {
            InitializeComponent();
              sever_tb.Text=Properties.Settings.Default.server;
           database_tb.Text= Properties.Settings.Default.database ;
            if (Properties.Settings.Default.mode == "SQL")
            {
                sql_rb.Checked = true;
                username_tb.Text = Properties.Settings.Default.user_id;
                password_tb.Text = Properties.Settings.Default.password;
            }
            else
            {
                win_rb.Checked = true;
                username_tb.Clear();
                password_tb.Clear();
                username_tb.ReadOnly = true;
                password_tb.ReadOnly = true;
            }
          
   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = sever_tb.Text;
            Properties.Settings.Default.database = database_tb.Text;
            Properties.Settings.Default.mode = sql_rb.Checked==true? "SQL":"Windows";
            Properties.Settings.Default.user_id = username_tb.Text;
            Properties.Settings.Default.password = password_tb.Text;
            Properties.Settings.Default.Save();



        }

        private void sql_rb_CheckedChanged(object sender, EventArgs e)
        {
            username_tb.ReadOnly = false;
            password_tb.ReadOnly = false;
        }

        private void win_rb_CheckedChanged(object sender, EventArgs e)
        {
            username_tb.ReadOnly = true;
            password_tb.ReadOnly = true;

        }
    }
}
