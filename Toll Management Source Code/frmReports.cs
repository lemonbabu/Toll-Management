using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toll_Automation
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReportHourly objFrmMain = new frmReportHourly();
            this.Hide();
            objFrmMain.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmReportDay objFrmMain = new frmReportDay();
            this.Hide();
            objFrmMain.Show();
        }

        private void btnDataEntry_Click(object sender, EventArgs e)
        {
            frmReportTotal objFrmMain = new frmReportTotal();
            this.Hide();
            objFrmMain.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmDataEntry objFrmMain = new frmDataEntry();
            this.Hide();
            objFrmMain.Show();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {

        }
    }
}
