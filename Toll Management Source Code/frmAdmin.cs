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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.FromArgb(0, 100, 0, 0);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReports objFrmMain = new frmReports();
            this.Hide();
            objFrmMain.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword objFrmMain = new frmChangePassword();
            this.Hide();
            objFrmMain.Show();
        }

        private void btnDataEntry_Click(object sender, EventArgs e)
        {
            frmDataEntry objFrmMain = new frmDataEntry();
            this.Hide();
            objFrmMain.Show();

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmUnitToll objFrmMain = new frmUnitToll();
            this.Hide();
            objFrmMain.Show();
        }
    }
}
