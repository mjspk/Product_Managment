using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;



namespace Product_Managment.presentation_Access
{
    public partial class Categories_Management_Frm : Form
    {
        SqlDataAdapter da;
       SqlConnection cn;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;

        public Categories_Management_Frm()
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
           
            add_bt.Enabled = false;

            da = new SqlDataAdapter("select ID_CAT as 'Category ID',Description_CAT as 'Description' from Categories", cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            id_tb.DataBindings.Add("text", dt, "Category ID");
            description_tb.DataBindings.Add("text", dt, "Description");
            bmb = this.BindingContext[dt];
            label_position.Text = (bmb.Position+1) + " / " + bmb.Count;
        }

        private void first_bt_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            label_position.Text = (bmb.Position+1) + " / " + bmb.Count;

        }

        private void last_bt_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            label_position.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void next_bt_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            label_position.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void previous_bt_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            label_position.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            int id = Convert.ToInt32(dt.Rows[ dt.Rows.Count - 1][0])+1;
            id_tb.Text = id.ToString();
            new_bt.Enabled = false;
            add_bt.Enabled = true;
            description_tb.Focus();
        }

        private void add_bt_Click(object sender, EventArgs e)
        {

            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Added Successfullt ", "  Add new  Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            add_bt.Enabled = false;
            new_bt.Enabled = true;
            label_position.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
          
            

        }

        private void print_all_bt_Click(object sender, EventArgs e)
        {
            Report.Report_Categories myreport = new Report.Report_Categories();
            Report.Report_frm frm = new Report.Report_frm();
            myreport.Refresh();
            frm.crystalReportViewer1.ReportSource = myreport;
            frm.ShowDialog();
        }

        private void print_bt_Click(object sender, EventArgs e)
        {
          
        }

        private void save_excel_bt_Click(object sender, EventArgs e)
        {
            Report.Report_Categories myreport = new Report.Report_Categories();

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

        private void save_pdf_bt_Click(object sender, EventArgs e)
        {
            Report.Report_Categories myreport = new Report.Report_Categories();

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

        private void edit_bt_Click_1(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Edited Successfullt ", "  edit Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label_position.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void delete_bt_Click_1(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Deleted Successfullt ", "  Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label_position.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void print_bt_Click_1(object sender, EventArgs e)
        {
            Report.Sngil_Category_Report myreport = new Report.Sngil_Category_Report();
            myreport.SetParameterValue("@ID_CAT", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Report.Report_frm frm = new Report.Report_frm();
            frm.crystalReportViewer1.ReportSource = myreport;
            frm.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
