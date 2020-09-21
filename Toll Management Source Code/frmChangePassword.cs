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
    public partial class frmChangePassword : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\tollManagement.mdf;Integrated Security=True");
        public SqlCommand cmd;

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("      আপনি কি বের হতে চান??", "", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tollManagementDataSet1.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.tollManagementDataSet1.tblUsers);
 
            tblAdmin.BackColor = Color.FromArgb(100, 0, 0, 0);
        
        }

        private void tblAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String user = cmbUserName.Text.Trim();
            String pas = txtNewPassword.Text;
            String conPas = txtConfirmPassword.Text;
            con.Open();

            if (pas == conPas)
            {
                string query = "Select * from tblUsers Where userName = '" + cmbUserName.Text.Trim() + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    cmd = new SqlCommand("UPDATE tblUsers SET Password = '" + txtNewPassword.Text.Trim() + "' WHERE userName = '" + cmbUserName.Text.Trim() + "'", con);

                    try
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("পাসওয়ার্ড পরিবর্তন সম্পূর্ণ হয়েছে। ধন্যবাদ...");

                        cmbUserName.Text = "";
                        txtNewPassword.Text = "";
                        txtConfirmPassword.Text = "";
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("ব্যবহারকারীর নাম নির্বাচন করুন।");
                }
            }
            else
            {
                MessageBox.Show("দুঃখিত!!!! পাসওয়ার্ড দুটি মিল হয়নি, সঠিক ভাবে পাসওয়ার্ড প্রদান করুন।");
            }
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbUserName.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";

            frmAdmin objFrmMain = new frmAdmin();
            this.Hide();
            objFrmMain.Show();
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
