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
    public partial class frmDataEntry : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\tollManagement.mdf;Integrated Security=True");
        public SqlCommand cmd;

       
        int noOfV, unitToll, totalNoOfV, unDo = 0, unDoFlag = 0;
        double totalMoney, totalMonyofTotalV, totalCash;
        String vehicleName;
        public frmDataEntry()
        {
            InitializeComponent();
            
        }

        private void frmDataEntry_Load(object sender, EventArgs e)
        {
            pnlDataEntry.BackColor = Color.FromArgb(100, 0, 0, 0);

            dataEntryLoad(1);
            txtnonmotorsV.Text = noOfV.ToString();
            txtnonmotorsA.Text = totalMoney.ToString();

            dataEntryLoad(2);
            txtbikeV.Text = noOfV.ToString();
            txtbikeA.Text = totalMoney.ToString();

            dataEntryLoad(3);
            txtminibusV.Text = noOfV.ToString();
            txtminibusA.Text = totalMoney.ToString();

            dataEntryLoad(4);
            txtbusV.Text = noOfV.ToString();
            txtbusA.Text = totalMoney.ToString();

            dataEntryLoad(5);
            txtcarV.Text = noOfV.ToString();
            txtcarA.Text = totalMoney.ToString();

            dataEntryLoad(6);
            txtMicroV.Text = noOfV.ToString();
            txtMicroA.Text = totalMoney.ToString();

            dataEntryLoad(7);
            txtargV.Text = noOfV.ToString();
            txtargA.Text = totalMoney.ToString();

            dataEntryLoad(8);
            txttruckV.Text = noOfV.ToString();
            txttruckA.Text = totalMoney.ToString();

            dataEntryLoad(9);
            txtheavyV.Text = noOfV.ToString();
            txtheavyA.Text = totalMoney.ToString();

            dataEntryLoad(10);
            txttrailerV.Text = noOfV.ToString();
            txttrailerA.Text = totalMoney.ToString();

            dataEntryLoad(11);
            txtgovtV.Text = noOfV.ToString();
            txtgovtA.Text = totalMoney.ToString();

            dataEntryLoad(12);
            txttaxiV.Text = noOfV.ToString();
            txttaxiA.Text = totalMoney.ToString();

            dataEntryLoad(13);
            txtwheelV.Text = noOfV.ToString();
            txtwheelA.Text = totalMoney.ToString();

            dataEntryLoad(14);
            txtmediumtruckV.Text = noOfV.ToString();
            txtmediumtruckA.Text = totalMoney.ToString();

            String localDate;

            DateTime localDateTime = DateTime.Now;
            localDate = localDateTime.ToShortDateString(); 
            con.Open();
            String query = "Select * from tblAccounts Where Date = '" + localDate + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                DataSet dataset = new DataSet();
                sda.Fill(dataset);
                totalNoOfV = Convert.ToInt32(dataset.Tables[0].Rows[0]["TotalVehicles"].ToString());
                totalMonyofTotalV = Convert.ToDouble(dataset.Tables[0].Rows[0]["TotalAmount"].ToString());
                totalCash = Convert.ToDouble(dataset.Tables[0].Rows[0]["TotalCash"].ToString());
            }
            else
            {
                totalNoOfV = 0;
                totalMonyofTotalV = 0;
                totalCash = 0;
            }
            con.Close();
            txtTV.Text = totalNoOfV.ToString();
            txtEA.Text = totalMonyofTotalV.ToString();
            txtTotalCash.Text = totalCash.ToString();
        }

        private void DataPanel_Paint(object sender, PaintEventArgs e)
        {
            timer.Start();
        }

        private void DataEntryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            DialogResult confirm = MessageBox.Show("        Do you want to exit?","",MessageBoxButtons.YesNo);
            if (confirm==DialogResult.Yes)
            {
               Application.Exit();
            }
            else if(confirm==DialogResult.No)
            {
                e.Cancel = true;
            }
             */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSec.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void NonMotorsBtn_Click(object sender, EventArgs e)
        {
            UnitToll(1);
            dataEntry(1);

            txtnonmotorsV.Text = noOfV.ToString();
            txtnonmotorsA.Text = totalMoney.ToString();
        }

        private void BikeBtn_Click(object sender, EventArgs e)
        {
            UnitToll(2);
            dataEntry(2);

            txtbikeV.Text = noOfV.ToString();
            txtbikeA.Text = totalMoney.ToString();
        }

        private void MiniBusBtn_Click(object sender, EventArgs e)
        {
            UnitToll(3);
            dataEntry(3);

            txtminibusV.Text = noOfV.ToString();
            txtminibusA.Text = totalMoney.ToString();
        }

        private void BusBtn_Click(object sender, EventArgs e)
        {
            UnitToll(4);
            dataEntry(4);

            txtbusV.Text = noOfV.ToString();
            txtbusA.Text = totalMoney.ToString();
        }

        private void CarBtn_Click(object sender, EventArgs e)
        {
            UnitToll(5);
            dataEntry(5);

            txtcarV.Text = noOfV.ToString();
            txtcarA.Text = totalMoney.ToString();
        }

        private void MicroBtn_Click(object sender, EventArgs e)
        {
            UnitToll(6);
            dataEntry(6);

            txtMicroV.Text = noOfV.ToString();
            txtMicroA.Text = totalMoney.ToString();
        }

        private void AgrBtn_Click(object sender, EventArgs e)
        {
            UnitToll(7);
            dataEntry(7);

            txtargV.Text = noOfV.ToString();
            txtargA.Text = totalMoney.ToString();
        }

        private void TruckBtn_Click(object sender, EventArgs e)
        {
            UnitToll(8);
            dataEntry(8);

            txttruckV.Text = noOfV.ToString();
            txttruckA.Text = totalMoney.ToString();
        }

        private void HeavyTruckBtn_Click(object sender, EventArgs e)
        {
            UnitToll(9);
            dataEntry(9);

            txtheavyV.Text = noOfV.ToString();
            txtheavyA.Text = totalMoney.ToString();
        }

        private void TrailerBtn_Click(object sender, EventArgs e)
        {
            UnitToll(10);
            dataEntry(10);

            txttrailerV.Text = noOfV.ToString();
            txttrailerA.Text = totalMoney.ToString();
        }

        private void GovtBtn_Click(object sender, EventArgs e)
        {
            UnitToll(11);
            dataEntry(11);

            txtgovtV.Text = noOfV.ToString();
            txtgovtA.Text = totalMoney.ToString();
        }

        private void Taxibtn_Click(object sender, EventArgs e)
        {
            UnitToll(12);
            dataEntry(12);

            txttaxiV.Text = noOfV.ToString();
            txttaxiA.Text = totalMoney.ToString();
        }

        private void wheelbtn_Click(object sender, EventArgs e)
        {
            UnitToll(13);
            dataEntry(13);

            txtwheelV.Text = noOfV.ToString();
            txtwheelA.Text = totalMoney.ToString();
        }

        private void Mediumtruckbtn_Click(object sender, EventArgs e)
        {
            UnitToll(14);
            dataEntry(14);

            txtmediumtruckV.Text = noOfV.ToString();
            txtmediumtruckA.Text = totalMoney.ToString();
        }

        private void txtTV_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEA_Click(object sender, EventArgs e)
        {

        }

        private void txtbusA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbusV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            frmReports objFrmMain = new frmReports();
            this.Hide();
            objFrmMain.Show();
        }

        private void VehiclesLvl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin objFrmMain = new frmLogin();
            this.Hide();
            objFrmMain.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin objFrmMain = new frmLogin();
            this.Hide();
            objFrmMain.Show();
        }


        public void dataEntry(int vehicleId)
        {
            unDo = vehicleId;
            String date, localDate, localTime;

            DateTime localDateTime = DateTime.Now;
            localDate = localDateTime.ToShortDateString();
            localTime = localDateTime.ToShortTimeString();
 
            string[] h = localTime.Split(':', ' ');
            localTime = (h[0] + " " + h[2]).ToString();

            con.Open();
            string query = "Select * from tblDataTime Where VehicleName = '" + vehicleName + "' and Time = '" + localTime + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                try
                {
                    DataSet dataset = new DataSet();
                    sda.Fill(dataset);

                    date = dataset.Tables[0].Rows[0]["Date"].ToString();
                    noOfV = Convert.ToInt32(dataset.Tables[0].Rows[0]["AmountOfVehicle"].ToString());
                    
                    noOfV += 1;
                    totalMoney = unitToll * noOfV;
                    if (unDoFlag == 1)
                    {
                        noOfV -= 2;
                        totalMoney = totalMoney - (unitToll*2);
                    }

                    if (date != localDate)
                    {
                        con.Close();
                        if (unDoFlag == 1)
                        {
                            return;
                        }
                        for (int i = 1; i <= 14; i++)
                        {
                            UnitToll(i);
                            con.Open();
                            noOfV = 0;
                            totalMoney = 0;
                            cmd = new SqlCommand("UPDATE tblDataTime SET Date = '" + localDate + "', AmountOfVehicle = '" + noOfV + "', UnitToll = '" + unitToll + "', TotalMoney = '" + totalMoney + "' WHERE VehicleName = '" + vehicleName + "' and Time = '" + localTime + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        UnitToll(vehicleId);
                        con.Open();
                        noOfV = 1;
                        totalMoney = unitToll;
                        cmd = new SqlCommand("UPDATE tblDataTime SET Date = '" + localDate + "', AmountOfVehicle = '" + noOfV + "', UnitToll = '" + unitToll + "', TotalMoney = '" + totalMoney + "' WHERE VehicleName = '" + vehicleName + "' and Time = '" + localTime + "'", con);
                     }
                    else
                    {
                        cmd = new SqlCommand("UPDATE tblDataTime SET AmountOfVehicle = '" + noOfV + "', UnitToll = '" + unitToll + "', TotalMoney = '" + totalMoney + "' WHERE VehicleName = '" + vehicleName + "' and Time = '" + localTime + "'", con);
                   }
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO tblDataTime (VehicleName, Time, Date, AmountOfVehicle, UnitToll, TotalMoney)  VALUES('" + vehicleName + "', '" + localTime + "', '" + localDate + "', '" + 1 + "', '" + unitToll + "', '" + unitToll + "')", con);
                    noOfV = 1;
                    totalMoney = unitToll;
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            con.Close();
            dataEntryOfTotalVehicles(vehicleId);
        }

        public void UnitToll(int id)
        {
            con.Open();
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter("SELECT * FROM tblVehicles WHERE Id = '" + id + "'", con);
                DataSet dataset = new DataSet();
                Adpt.Fill(dataset);
                unitToll = Convert.ToInt32(dataset.Tables[0].Rows[0]["UnitToll"].ToString());
                vehicleName = dataset.Tables[0].Rows[0]["VehicleName"].ToString();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        //Counting total vehicle 
        public void dataEntryOfTotalVehicles(int vehicleId)
        {

            String localDate;

            DateTime localDateTime = DateTime.Now;
            localDate = localDateTime.ToShortDateString();

            con.Open();
            string query = "Select * from tblTotalVehicles Where VehicleName = '" + vehicleName + "' and Date = '" + localDate + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                try
                {
                    DataSet dataset = new DataSet();
                    sda.Fill(dataset);

                    noOfV = Convert.ToInt32(dataset.Tables[0].Rows[0]["NoOfVehicles"].ToString());
                    noOfV += 1;
                    totalMoney = unitToll * noOfV;
                    if (unDoFlag == 1)
                    {
                        noOfV -= 2;
                        totalMoney = totalMoney - (unitToll * 2);
                    }

                    cmd = new SqlCommand("UPDATE tblTotalVehicles SET UnitToll = '" + unitToll + "', NoOfVehicles = '" + noOfV + "', EstemateAmount = '" + totalMoney + "' WHERE Date = '" + localDate + "' and VehicleName = '" + vehicleName + "'", con);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO tblTotalVehicles (Date, VehicleName, UnitToll, noOfVehicles, EstemateAmount)  VALUES('" + localDate + "', '" + vehicleName + "', '" + unitToll + "', '" + 1 + "', '" + unitToll + "')", con);
                    noOfV = 1;
                    totalMoney = unitToll;
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            con.Close();
            dataEntryOfAccounts();
        }



        //Caculate the Accounts
        public void dataEntryOfAccounts()
        {

            String localDate;

            DateTime localDateTime = DateTime.Now;
            localDate = localDateTime.ToShortDateString();

            con.Open();
            string query = "Select * from tblAccounts Where Date = '" + localDate + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                try
                {
                    DataSet dataset = new DataSet();
                    sda.Fill(dataset);

                    totalNoOfV = Convert.ToInt32(dataset.Tables[0].Rows[0]["TotalVehicles"].ToString());
                    totalMonyofTotalV = Convert.ToDouble(dataset.Tables[0].Rows[0]["TotalAmount"].ToString());
                    double totalCash = Convert.ToDouble(dataset.Tables[0].Rows[0]["totalCash"].ToString());
                    totalNoOfV += 1;
                    totalMonyofTotalV += unitToll;
                    double dif = totalCash - totalMonyofTotalV;
                    if (unDoFlag == 1)
                    {
                        totalNoOfV -= 2;
                        totalMonyofTotalV -= (unitToll * 2);
                        dif = totalCash - totalMonyofTotalV;
                    }

                    cmd = new SqlCommand("UPDATE tblAccounts SET TotalVehicles = '" + totalNoOfV + "', TotalAmount = '" + totalMonyofTotalV + "', Diffrence = '" + dif + "' WHERE Date = '" + localDate + "'", con);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO tblAccounts (Date, TotalVehicles, TotalAmount, TotalCash, Diffrence)  VALUES('" + localDate + "', '" + 1 + "', '" + unitToll + "', '" + 0 + "', '" + -(unitToll) + "')", con);
                    totalNoOfV = 1;
                    totalMonyofTotalV = unitToll;
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            con.Close();
            txtTV.Text = totalNoOfV.ToString();
            txtEA.Text = totalMonyofTotalV.ToString();
        }


        //First time Page load
        public void dataEntryLoad(int vehicleId)
        {
            UnitToll(vehicleId);
            String localDate;

            DateTime localDateTime = DateTime.Now;
            localDate = localDateTime.ToShortDateString();

            con.Open();
            string query = "Select * from tblTotalVehicles Where VehicleName = '" + vehicleName + "' and Date = '" + localDate + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                try
                {
                    DataSet dataset = new DataSet();
                    sda.Fill(dataset);

                    noOfV = Convert.ToInt32(dataset.Tables[0].Rows[0]["NoOfVehicles"].ToString());
                    totalMoney = Convert.ToDouble(dataset.Tables[0].Rows[0]["EstemateAmount"].ToString());
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                noOfV = 0;
                totalMoney = 0;
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cash = txtTotalCash.Text;
            totalCash = Convert.ToDouble(cash);
            String localDate;

            DateTime localDateTime = DateTime.Now;
            localDate = localDateTime.ToShortDateString();

            con.Open();
            string query = "Select * from tblAccounts Where Date = '" + localDate + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                try
                {
                    DataSet dataset = new DataSet();
                    sda.Fill(dataset);

                    totalMonyofTotalV = Convert.ToDouble(dataset.Tables[0].Rows[0]["TotalAmount"].ToString());
                    double dif = totalCash - totalMonyofTotalV;

                    cmd = new SqlCommand("UPDATE tblAccounts SET TotalCash = '" + totalCash + "', Diffrence = '" + dif + "' WHERE Date = '" + localDate + "'", con);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO tblAccounts (Date, TotalVehicles, TotalAmount, TotalCash, Diffrence)  VALUES('" + localDate + "', '" + 0 + "', '" + 0 + "', '" + 0 + "', '" + 0 + "')", con);
                    totalNoOfV = 1;
                    totalMonyofTotalV = unitToll;
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            con.Close();
            MessageBox.Show("সম্পূর্ণ হয়েছে।");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (unDo == 0)
            {
                MessageBox.Show("কোন কাজ করা হয়নি।");
            }
            else
            {
                unDoFlag = 1;
                UnitToll(unDo);
                dataEntry(unDo);
                MessageBox.Show("পূর্বাবস্থায় ফেরা হয়েছে।");
                unDoFlag = 0;
                unDo = 0;
                frmDataEntry_Load(sender, e);
            }
        }

        private void txtTotalCash_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
