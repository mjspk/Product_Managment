using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Managment.presentation_Access
{
    public partial class Restore_frm : Form
    {
        SqlConnection cn;
        SqlCommand cmd = new SqlCommand();
        public Restore_frm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.mode == "SQL")
            {
                cn = new SqlConnection(@"Server =" + Properties.Settings.Default.server + "; DataBase= " + Properties.Settings.Default.database + " ; Integrated Security=false ; User Id= " + Properties.Settings.Default.user_id + ";Password=" + Properties.Settings.Default.password + "");

            }
            else
            {
                cn = new SqlConnection(@"Server =" + Properties.Settings.Default.server + "; DataBase= " + Properties.Settings.Default.database + " ; Integrated Security=true; ");

            }
        }

        private void browes_bt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                save_path.Text = openFileDialog1.FileName;
            }
        }

        private void restore_bt_Click(object sender, EventArgs e)
        {
            
            cmd.CommandText = "alter database sell_managment_DB set offline with rollback immediate ; restore database sell_managment_DB from disk='" + save_path.Text + "' WITH REPLACE";
            cmd.Connection = cn;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Restore Successfully", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            cmd.CommandText = "alter database sell_managment_DB set online";
            cmd.Connection = cn;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
