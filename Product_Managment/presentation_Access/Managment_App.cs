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
using System.Data.SqlClient;

namespace Product_Managment.presentation_Access
{
    public partial class Managment_App : Form
    {

        public DataTable dta = new DataTable();
        Business_Access.Orders_Class order = new Business_Access.Orders_Class();
        private static Managment_App frm;
        
        
        static void frm_Formclosed(object sender,FormClosedEventArgs e)
        {
            frm = null;
        }
        
        public static Managment_App getmyform
        {
            get
            {
                if( frm==null)
                {
                    frm = new Managment_App();
                    frm.FormClosed += new FormClosedEventHandler(frm_Formclosed);

                }
                return frm;
            }
        }



        void createdatatable()
        {
            dta.Columns.Add("Product ID");
            dta.Columns.Add("Product Name");
            dta.Columns.Add("Price");
            dta.Columns.Add("Quntity");
            dta.Columns.Add("Amount");
            dta.Columns.Add(" Total Amount");
            dta.Columns.Add("Discount");
            dataGridView1.DataSource = dta;


        }

       public void cleardata()
        {
            product_id_tb.Clear();
            product_name_tb.Clear();
            product_price_tb.Clear();
            amount_tb.Clear();
            discount_tb.Clear();
            total_amount_tb.Clear();


            customer_id.Clear();
            firstname_bt.Clear();
            lastname_tb.Clear();
            tell_tb.Clear();
            email_tb.Clear();
            pictureBox1.Image = null;
            dataGridView1.DataSource = null;
            dta.Clear();

            description_tb.Clear();
            dateTimePicker1.Refresh();

        }
       public void resizzedgv()
        {

            this.dataGridView1.RowHeadersWidth= button6.Width;
            this.dataGridView1.Columns[0].Width =product_id_tb.Width;
            this.dataGridView1.Columns[1].Width =product_name_tb.Width;
            this.dataGridView1.Columns[2].Width = product_price_tb.Width;
            this.dataGridView1.Columns[3].Width = product_quntity_tb.Width;
            this.dataGridView1.Columns[4].Width = amount_tb.Width;
            this.dataGridView1.Columns[5].Width = discount_tb.Width;
            this.dataGridView1.Columns[6].Width = total_amount_tb.Width;
        }
        public Managment_App()
        {
            if (frm==null)            
                frm = this;
            
            InitializeComponent();
            seller_tb.Text = Program.Saleman;
            createdatatable();
            
            
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_frm frm = new Login_frm();
            frm.ShowDialog();
        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Product_frm frm = new Add_Product_frm();
            frm.ShowDialog();
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Management_frm frm = new Product_Management_frm();
            frm.ShowDialog();

        }

        private void manageCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories_Management_Frm frm = new Categories_Management_Frm();
            frm.ShowDialog();
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Management frm = new Customer_Management();
            frm.ShowDialog();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Business_Access.Orders_Class order = new Business_Access.Orders_Class();
            order_id_tb.Text = order.get_last_order().Rows[0][0].ToString();
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
            cleardata();

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                Customer_Management frm = new Customer_Management();
                frm.ShowDialog();
                customer_id.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                firstname_bt.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lastname_tb.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tell_tb.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                email_tb.Text = frm.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                byte[] pic = (byte[])frm.dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Product_Management_frm frm = new Product_Management_frm();
            frm.ShowDialog();
            product_id_tb.Clear();
            product_name_tb.Clear();
            product_price_tb.Clear();
            amount_tb.Clear();
            discount_tb.Clear();
            total_amount_tb.Clear();
           
            product_id_tb.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            product_name_tb.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            product_price_tb.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            product_price_tb.Focus();


        }

       
        private void button7_Click(object sender, EventArgs e)
        {

          

        }

        private void product_quntity_tb_TextChanged(object sender, EventArgs e)
        {
            if (product_price_tb.Text != string.Empty && product_quntity_tb.Text != string.Empty)
            {

                amount_tb.Text = (Convert.ToDouble(product_price_tb.Text) * Convert.ToInt32(product_quntity_tb.Text)).ToString();

                if (Convert.ToInt32(product_quntity_tb.Text) > Convert.ToInt32(order.quntity_varfy(product_id_tb.Text).Rows[0][0].ToString()))
                {
                    MessageBox.Show("This Quntity Of that Product Not Available In Stock There is Just  ' " + order.quntity_varfy(product_id_tb.Text).Rows[0][0]+ " '  Piece(s) From it ", " Quntity ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    product_quntity_tb.Text = order.quntity_varfy( product_id_tb.Text).Rows[0][0].ToString();
                }
            }
           
           
        }

        private void discount_tb_TextChanged(object sender, EventArgs e)
        {
            if (amount_tb.Text != string.Empty && discount_tb.Text != string.Empty)
            {

                total_amount_tb.Text = (Convert.ToDouble(amount_tb.Text) - (Convert.ToDouble(discount_tb.Text) *( Convert.ToDouble(amount_tb.Text)/100))).ToString();
            }
        }

        private void Managment_App_Load(object sender, EventArgs e)
        {
            resizzedgv();
            Business_Access.Login_Class lg = new Business_Access.Login_Class();
            
           
            try
            {
                DataTable dt = lg.check_state(1);
                if (dt.Rows.Count > 0)
                {
                    presentation_Access.Managment_App.getmyform.customersToolStripMenuItem.Enabled = true;
                    presentation_Access.Managment_App.getmyform.productsToolStripMenuItem.Enabled = true;

                    presentation_Access.Managment_App.getmyform.backupToolStripMenuItem.Enabled = true;
                    presentation_Access.Managment_App.getmyform.restorToolStripMenuItem.Enabled = true;
                    Program.Saleman = dt.Rows[0]["FULLname"].ToString();
                    presentation_Access.Managment_App.getmyform.seller_tb.Text = dt.Rows[0]["FULLname"].ToString();
                    byte[] auth = (byte[])dt.Rows[0]["authority"];
                    if (auth[0] == 1)
                    {
                        presentation_Access.Managment_App.getmyform.newProductToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        presentation_Access.Managment_App.getmyform.newProductToolStripMenuItem.Enabled = false;

                    }

                    if (auth[1] == 1)
                    {
                        presentation_Access.Managment_App.getmyform.manageProductsToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        presentation_Access.Managment_App.getmyform.manageProductsToolStripMenuItem.Enabled = false;

                    }
                    if (auth[2] == 1)
                    {
                        presentation_Access.Managment_App.getmyform.manageCategoriesToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        presentation_Access.Managment_App.getmyform.manageCategoriesToolStripMenuItem.Enabled = false;

                    }
                    if (auth[3] == 1)
                    {
                        presentation_Access.Managment_App.getmyform.manageCustomersToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        presentation_Access.Managment_App.getmyform.manageCustomersToolStripMenuItem.Enabled = false;

                    }
                    if (auth[4] == 1)
                    {
                        presentation_Access.Managment_App.getmyform.manageOrdersToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        presentation_Access.Managment_App.getmyform.manageOrdersToolStripMenuItem.Enabled = false;

                    }
                    if (auth[5] == 1)
                    {
                        presentation_Access.Managment_App.getmyform.usersToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        presentation_Access.Managment_App.getmyform.usersToolStripMenuItem.Enabled = false;

                    }
                }
            }
           catch
            {
                this.Show();
            }
            
        }

        private void product_quntity_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void product_price_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8&&e.KeyChar!=Convert.ToChar( System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void product_price_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter&&product_price_tb.Text!=string.Empty)
            {
                product_quntity_tb.Focus();
            }
        }

        private void product_quntity_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && product_quntity_tb.Text != string.Empty)
            {
                discount_tb.Focus();

            }
        }

        private void discount_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                for(Int32 i=0; i< (dataGridView1.Rows.Count); ++i)
                {
                    if(dataGridView1.Rows[i].Cells[0].Value.ToString()==product_id_tb.Text)
                    {
                        MessageBox.Show("This Product Already Added You Can Edit If You Want", "!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                if (product_price_tb.Text != string.Empty && product_quntity_tb.Text != string.Empty && amount_tb.Text != string.Empty && total_amount_tb.Text != string.Empty)
                {
                    DataRow r = dta.NewRow();
                    r[0] = product_id_tb.Text;
                    r[1] = product_name_tb.Text;
                    r[2] = product_price_tb.Text;
                    r[3] = product_quntity_tb.Text;
                    r[4] = amount_tb.Text;
                    r[5] = discount_tb.Text;
                    r[6] = total_amount_tb.Text;
                    dta.Rows.Add(r);
                    dataGridView1.DataSource = dta;
                    product_id_tb.Clear();
                    product_name_tb.Clear();
                    product_price_tb.Clear();
                    product_quntity_tb.Clear();
                    amount_tb.Clear();
                    discount_tb.Clear();
                    total_amount_tb.Clear();
                    sum_tb.Text = (from DataGridViewRow row in dataGridView1.Rows where row.Cells[6].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
                    resizzedgv();
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                product_id_tb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                product_name_tb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                product_price_tb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                product_quntity_tb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                amount_tb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                discount_tb.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                total_amount_tb.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                product_price_tb.Focus();

            }
            catch
            {
                return;
            }
            
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            sum_tb.Text = (from DataGridViewRow row in dataGridView1.Rows where row.Cells[6].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

      
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch
            {
                return;
            }
        }

        private void deleteAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


            dta.Clear();
            dataGridView1.Refresh();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

           

                if (order_id_tb.Text != string.Empty && customer_id.Text != string.Empty && description_tb.Text != string.Empty && seller_tb.Text != string.Empty)
                {
                    order.add_order(Convert.ToInt32(order_id_tb.Text), dateTimePicker1.Value, Convert.ToInt32(customer_id.Text), description_tb.Text, seller_tb.Text, sum_tb.Text, defences_tb.Text, remaining_tb.Text);


                    for (int a = 0; a < dataGridView1.Rows.Count; a++)
                    {
                        order.add_order_details(dataGridView1.Rows[a].Cells[0].Value.ToString(),
                            Convert.ToInt32(order_id_tb.Text), dataGridView1.Rows[a].Cells[2].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[a].Cells[3].Value), dataGridView1.Rows[a].Cells[4].Value.ToString(), dataGridView1.Rows[a].Cells[5].Value.ToString(), dataGridView1.Rows[a].Cells[6].Value.ToString());
                    }






                    MessageBox.Show("Order Saved Successfully", "Save Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button2.Enabled = true;
                    button3.Enabled = false;
                    button4.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Please Complete Your Order", "Save Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }




      

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Business_Access.Orders_Class order = new Business_Access.Orders_Class();
            order_id_tb.Text = order.get_last_order().Rows[0][0].ToString();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch
            {
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (order_id_tb.Text != string.Empty)
            {
                Report.Report_Order myreport = new Report.Report_Order();
                myreport.SetParameterValue("@ID_order", Convert.ToInt32(order_id_tb.Text));
                Report.Report_frm frm = new Report.Report_frm();
                frm.crystalReportViewer1.ReportSource = myreport;
                frm.ShowDialog();
            }
            else
            {
                Report.Report_Order myreport = new Report.Report_Order();
                myreport.SetParameterValue("@ID_order", order.get_last_order_forprint().Rows[0][0]);
                Report.Report_frm frm = new Report.Report_frm();
                frm.crystalReportViewer1.ReportSource = myreport;
                frm.ShowDialog();
            }
        }

        private void manageOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_Management frm = new Order_Management();
            frm.ShowDialog();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();

        }

        private void defences_tb_TextChanged(object sender, EventArgs e)
        {
            if (sum_tb.Text != string.Empty&&defences_tb.Text!=string.Empty)
            {
                remaining_tb.Text = (Convert.ToDouble(sum_tb.Text) - Convert.ToDouble(defences_tb.Text)).ToString();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            seller_tb.Clear();


            Managment_App.getmyform.customersToolStripMenuItem.Enabled = false;
            Managment_App.getmyform.productsToolStripMenuItem.Enabled = false;

            Managment_App.getmyform.backupToolStripMenuItem.Enabled = false;
            Managment_App.getmyform.restorToolStripMenuItem.Enabled = false;
            Managment_App.getmyform.newProductToolStripMenuItem.Enabled = false;

           
           
                Managment_App.getmyform.manageProductsToolStripMenuItem.Enabled = false;

            
                Managment_App.getmyform.manageCategoriesToolStripMenuItem.Enabled = false;

           
                Managment_App.getmyform.manageCustomersToolStripMenuItem.Enabled = false;

           
                Managment_App.getmyform.manageOrdersToolStripMenuItem.Enabled = false;

           
                Managment_App.getmyform.usersToolStripMenuItem.Enabled = false;
            Business_Access.Login_Class lg = new Business_Access.Login_Class();
            lg.uncheck_state();

           
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup_frm frm = new Backup_frm();
            frm.ShowDialog();
        }

        private void restorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore_frm frm = new Restore_frm();
            frm.ShowDialog();
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connectionSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Connection_setting frm = new Connection_setting();
            frm.ShowDialog();
        }
    
    }
}
