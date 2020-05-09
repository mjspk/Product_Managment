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
    public partial class Product_Management_frm : Form
    {
        private static Product_Management_frm frm;

        static void frm_Formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Product_Management_frm getmyform
        {
            get
            {
                if (frm == null)
                {
                    frm = new Product_Management_frm();
                    frm.FormClosed += new FormClosedEventHandler(frm_Formclosed);

                }
                return frm;
            }
        }

            Business_Access.Product_Class prd = new Business_Access.Product_Class();

        public Product_Management_frm()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            dataGridView1.DataSource = prd.get_all_product();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.Search_product(search_tb.Text);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Product_frm frm = new Add_Product_frm();
                frm.ShowDialog();
        }

       
        private void delete_bt_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Do You Want Delete Product ", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.delete_product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Deleted  Successfully", " Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = prd.get_all_product();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Product_frm frm = new Add_Product_frm();
            frm.product_id_tb.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.product_label_tb.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.product_price_tb.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.product_quntity_tb.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.categoty_cmb.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = " Update Product Info";
            frm.ok_bt.Text = "Update";
            frm.state = "update";
            frm.product_id_tb.ReadOnly = true;
            byte[] image = (byte[])prd.get_image(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);








            frm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            preview_frm frm = new preview_frm();
            byte[] image = (byte[])prd.get_image(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report.Report_Product myreport = new Report.Report_Product();
            myreport.SetParameterValue("@ID_product", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Report.Report_frm frm = new Report.Report_frm();
            frm.crystalReportViewer1.ReportSource = myreport;
            frm.ShowDialog();
        }

        private void Manage_Product_frm_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Report.Multi_Product_Report myreport = new Report.Multi_Product_Report();
            Report.Report_frm frm = new Report.Report_frm();
            frm.crystalReportViewer1.ReportSource = myreport;
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try {
                Report.Multi_Product_Report myreport = new Report.Multi_Product_Report();

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
            try
            {
                Report.Multi_Product_Report myreport = new Report.Multi_Product_Report();

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
            catch
            {
                return;
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            preview_frm frm = new preview_frm();
            byte[] image = (byte[])prd.get_image(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.Search_product(search_tb.Text);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            
        }

      

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void dataGridView1_RowSelected(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
