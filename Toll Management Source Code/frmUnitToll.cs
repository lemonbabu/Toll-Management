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

namespace Toll_Automation
{
    public partial class frmUnitToll : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\tollManagement.mdf;Integrated Security=True");
        public SqlCommand cmd;

        public frmUnitToll()
        {
            InitializeComponent();
        }

        private void frmUnitToll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tollManagementDataSetTblVehicles2.tblVehicles' table. You can move, or remove it, as needed.
            this.tblVehiclesTableAdapter.Fill(this.tollManagementDataSetTblVehicles2.tblVehicles);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UpdateToll();
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from tblVehicles", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            
        }
        

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmAdmin objFrmMain = new frmAdmin();
            this.Hide();
            objFrmMain.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReportHourly objFrmMain = new frmReportHourly();
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

        private void tblAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        protected void UpdateToll()
        {
            
            int selectedValue = (int)cmbVehicleName.SelectedValue;
            
            String newTollRate = txtNewTollRate.Text;
            con.Open();
            if (newTollRate != "")
            {
                string query = "Select * from tblVehicles Where Id = '" + selectedValue + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    cmd = new SqlCommand("UPDATE tblVehicles SET UnitToll = '" + txtNewTollRate.Text.Trim() + "' WHERE Id = '" + selectedValue + "'", con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("টোলের হার পরিবর্তিত হয়েছে। ধন্যবাদ...");

                        cmbVehicleName.Text = "";
                        txtNewTollRate.Text = "";
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No data Found");
                }
            }
            else
            {
                MessageBox.Show("নতুন টোলের হার প্রদান করুন।");
            }
            con.Close();
            
        }
    }
}
