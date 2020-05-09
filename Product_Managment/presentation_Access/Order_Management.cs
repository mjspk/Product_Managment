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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace Product_Managment.presentation_Access
{
    public partial class Order_Management : Form
    {
        Business_Access.Orders_Class order = new Business_Access.Orders_Class();
        public Order_Management()
        {
            InitializeComponent();
            dataGridView1.DataSource = order.Search_orders("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Managment_App.getmyform.Show();
            this.Close();
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {

            try { dataGridView1.DataSource = order.Search_orders(search_tb.Text); }
            catch
            {
                return;
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try {
                dataGridView1.DataSource = order.Search_orders(search_tb.Text);
            }
            catch
            {
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Business_Access.Orders_Class order = new Business_Access.Orders_Class();
           Managment_App.getmyform.order_id_tb.Text = order.get_last_order().Rows[0][0].ToString();
            Managment_App.getmyform.button2.Enabled = false;
           Managment_App.getmyform.button3.Enabled = true;
           Managment_App.getmyform.button4.Enabled = false;
           Managment_App.getmyform.cleardata();

            DataTable dt = order.Get_order_for_edit(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                Managment_App.getmyform.dateTimePicker1.Text = dt.Rows[0][1].ToString();
                Managment_App.getmyform.description_tb.Text = dt.Rows[0][2].ToString();
                Managment_App.getmyform.seller_tb.Text = dt.Rows[0][3].ToString();
                Managment_App.getmyform.sum_tb.Text = dt.Rows[0][4].ToString();
                Managment_App.getmyform.defences_tb.Text = dt.Rows[0][5].ToString();
                Managment_App.getmyform.remaining_tb.Text = dt.Rows[0][6].ToString();
                Managment_App.getmyform.customer_id.Text = dt.Rows[0][7].ToString();
                Managment_App.getmyform.firstname_bt.Text = dt.Rows[0][8].ToString();
                Managment_App.getmyform.lastname_tb.Text = dt.Rows[0][9].ToString();
                Managment_App.getmyform.tell_tb.Text = dt.Rows[0][10].ToString();
                Managment_App.getmyform.email_tb.Text = dt.Rows[0][11].ToString();

                byte[] pic = (byte[])dt.Rows[0][12];
                MemoryStream ms = new MemoryStream(pic);
                Managment_App.getmyform.pictureBox1.Image = Image.FromStream(ms);
            DataTable dt1 = order.get_order_details_for_edit(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            Managment_App.getmyform.dataGridView1.DataSource = dt1;
            Managment_App.getmyform.dta = dt1;
            Managment_App.getmyform.resizzedgv(); 
            this.Close();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Do You Want Delete Order ", "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
               order.delete_order(Convert.ToInt32( this.dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Deleted  Successfully", " Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = order.get_all_order();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report.Report_Order myreport = new Report.Report_Order();
            myreport.SetParameterValue("@ID_order", dataGridView1.CurrentRow.Cells[0].Value);
            Report.Report_frm frm = new Report.Report_frm();
            frm.crystalReportViewer1.ReportSource = myreport;
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Report.Report_Order myreport = new Report.Report_Order();
                myreport.SetParameterValue("@ID_order", dataGridView1.CurrentRow.Cells[0].Value);

                ExportOptions export = new ExportOptions();
                DiskFileDestinationOptions dfo = new DiskFileDestinationOptions();
                ExcelFormatOptions excelformat = new ExcelFormatOptions();
                dfo.DiskFileName = "E:\\ProductList.xls";
                export = myreport.ExportOptions;
                export.ExportDestinationType = ExportDestinationType.DiskFile;
                export.ExportFormatType = ExportFormatType.Excel;
                export.ExportFormatOptions = excelformat;
                export.ExportDestinationOptions = dfo;
                myreport.Export();
                MessageBox.Show("Saved as Excel Successfully!", "Save as Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Report.Report_Order myreport = new Report.Report_Order();
                myreport.SetParameterValue("@ID_order", dataGridView1.CurrentRow.Cells[0].Value);
                ExportOptions export = new ExportOptions();
                DiskFileDestinationOptions dfo = new DiskFileDestinationOptions();
                PdfFormatOptions pdfformat = new PdfFormatOptions();
                dfo.DiskFileName = "E:\\ProductList.pdf";
                export = myreport.ExportOptions;
                export.ExportDestinationType = ExportDestinationType.DiskFile;
                export.ExportFormatType = ExportFormatType.PortableDocFormat;
                export.ExportFormatOptions = pdfformat;
                export.ExportDestinationOptions = dfo;
                myreport.Export();
                MessageBox.Show("Saved as PDF Successfully!", "Save as PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
