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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            //this.KeyPreview = true;
            //this.KeyDown +=
            //    new KeyDownEventHandler(Form1_KeyDown);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            String localDate;
            int date, expDate = 20238;

            DateTime localDateTime = DateTime.Now;
            localDate = localDateTime.ToShortDateString();
            string[] h = localDate.Split('/');
            date = Convert.ToInt32((h[2] + h[0]).ToString());
            if (date >= expDate)
            {
                MessageBox.Show(" দুঃখিত আপনার আপটি মেয়াদ শেষ হয়ে গেছে। অনুগ্যহ পূর্বক যোগাযোগ করুন। Mail: lemonbabu2@gmail.com Mob: 01755408123");
                this.Close();
            }
            else if (date <= 20205)
            {
                MessageBox.Show("আপনার সময় ও তারিখ ভুল আছে। দয়া করা ঠিক করুন।");
                this.Close();
            }
            // TODO: This line of code loads data into the 'tollManagementDataSet1.tblUsers' table. You can move, or remove it, as needed.
           this.tblUsersTableAdapter1.Fill(this.tollManagementDataSet1.tblUsers);
           Loginpanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void LoginBut_Click(object sender, EventArgs e)
        {
            String userName, password;
            userName = cmbUserName.Text.Trim();
            password = txtPassword.Text;

            if (userName != "" && password != "")
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\tollManagement.mdf;Integrated Security=True");
                    string query = "Select * from tblUsers Where UserName = '" + cmbUserName.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count == 1)
                    {
                        if (userName == "Admin")
                        {
                            frmAdmin objFrmMain = new frmAdmin();
                            this.Hide();
                            objFrmMain.Show();
                        }
                        else
                        {
                            frmDataEntry objFrmMain = new frmDataEntry();
                            this.Hide();
                            objFrmMain.Show();
                        }
                    }
                    else if (userName == "lemonbabu2@gmail.com" && password == "lemon5336")
                    {
                        frmChangePassword objFrmMain = new frmChangePassword();
                        this.Hide();
                        objFrmMain.Show();
                    }
                    else
                    {
                        lblLogin.Text = "পাসওয়ার্ড ভুল প্রবেশ করিয়েছেন।";
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                lblLogin.Text = "ব্যবহারকারীর নাম ও পাসওয়ার্ড প্রবেশ করান।";
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBut_Click(sender, e);
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("      Are you sure to close this Application?", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
