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
    public partial class Backup_frm : Form
    {
        SqlConnection cn ;
        SqlCommand cmd = new SqlCommand();
        public Backup_frm()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void browes_bt_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                save_path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void backup_bt_Click(object sender, EventArgs e)
        {
            string filename = save_path.Text +"\\sell_managment_DB"+ DateTime.Now.ToShortDateString().Replace('/','-') + "-" + DateTime.Now.ToLongTimeString().Replace(':','-');

            cmd.CommandText = "backup database sell_managment_DB to disk='" + filename + ".bak'";
            cmd.Connection = cn;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Backup Successfully", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
