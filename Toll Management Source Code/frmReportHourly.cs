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
using Microsoft.Reporting.WinForms;

namespace Toll_Automation
{
    public partial class frmReportHourly : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\tollManagement.mdf;Integrated Security=True");
        public SqlCommand cmd;

        public frmReportHourly()
        {
            InitializeComponent();
        }

        private void tblDataTimeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tollManagementDataSetReport1.tblTotalVehicles' table. You can move, or remove it, as needed.
            this.tblTotalVehiclesTableAdapter.Fill(this.tollManagementDataSetReport1.tblTotalVehicles);
            // TODO: This line of code loads data into the 'dataSetTblDataTime.tblDataTime' table. You can move, or remove it, as needed.
            this.tblDataTimeTableAdapter.Fill(this.dataSetTblDataTime.tblDataTime);

            this.reportViewerHourlyData.RefreshReport();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String time = cmbTime.Text.Trim();
            String ex = cmbTimeEx.Text.Trim();
            time = time + " " + ex;
            if (time != "" & ex != "")
            {
                con.Open();
                cmd = new SqlCommand("Select * from tblDataTime Where Time = '" + time + "' ", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                ReportDataSource rds = new ReportDataSource("DataSetReportHourlyData", dtbl);
                //reportViewerHourlyData.LocalReport.ReportPath = @"C:\Users\Orange\Desktop\Toll\Toll Automation\Toll Automation\ReportHourlyData.rdlc";
                reportViewerHourlyData.LocalReport.DataSources.Clear();
                reportViewerHourlyData.LocalReport.DataSources.Add(rds);
                reportViewerHourlyData.RefreshReport();

                con.Close();
            }
            else
            {
                MessageBox.Show("দয়া করে সময় নিবাচন করুন??");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAdmin objFrmMain = new frmAdmin();
            this.Hide();
            objFrmMain.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReports objFrmMain = new frmReports();
            this.Hide();
            objFrmMain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDataEntry objFrmMain = new frmDataEntry();
            this.Hide();
            objFrmMain.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmLogin objFrmMain = new frmLogin();
            this.Hide();
            objFrmMain.Show();
        }
        
    }
}
