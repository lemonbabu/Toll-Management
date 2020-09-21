namespace Toll_Automation
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.Loginpanel = new System.Windows.Forms.Panel();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.tblUsersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tollManagementDataSet1 = new Toll_Automation.tollManagementDataSet1();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.LoginheadLvl = new System.Windows.Forms.Label();
            this.PasswordLvl = new System.Windows.Forms.Label();
            this.UserNameLvl = new System.Windows.Forms.Label();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter1 = new Toll_Automation.tollManagementDataSet1TableAdapters.tblUsersTableAdapter();
            this.Loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tollManagementDataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginpanel
            // 
            this.Loginpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Loginpanel.AutoSize = true;
            this.Loginpanel.BackColor = System.Drawing.Color.Transparent;
            this.Loginpanel.Controls.Add(this.cmbUserName);
            this.Loginpanel.Controls.Add(this.tableLayoutPanel1);
            this.Loginpanel.Controls.Add(this.label1);
            this.Loginpanel.Controls.Add(this.txtPassword);
            this.Loginpanel.Controls.Add(this.btnLogin);
            this.Loginpanel.Controls.Add(this.LoginheadLvl);
            this.Loginpanel.Controls.Add(this.PasswordLvl);
            this.Loginpanel.Controls.Add(this.UserNameLvl);
            this.Loginpanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Loginpanel.Location = new System.Drawing.Point(0, 0);
            this.Loginpanel.Name = "Loginpanel";
            this.Loginpanel.Size = new System.Drawing.Size(375, 515);
            this.Loginpanel.TabIndex = 0;
            // 
            // cmbUserName
            // 
            this.cmbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUserName.DataSource = this.tblUsersBindingSource1;
            this.cmbUserName.DisplayMember = "userName";
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(109, 130);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(152, 21);
            this.cmbUserName.TabIndex = 9;
            this.cmbUserName.ValueMember = "userName";
            // 
            // tblUsersBindingSource1
            // 
            this.tblUsersBindingSource1.DataMember = "tblUsers";
            this.tblUsersBindingSource1.DataSource = this.tollManagementDataSet1;
            // 
            // tollManagementDataSet1
            // 
            this.tollManagementDataSet1.DataSetName = "tollManagementDataSet1";
            this.tollManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblLogin, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 237);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 28);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Red;
            this.lblLogin.Location = new System.Drawing.Point(3, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(358, 28);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(183, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "টোল ব্যবস্থাপনায়";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(109, 196);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Location = new System.Drawing.Point(112, 271);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(152, 37);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "প্রবেশ করুন";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // LoginheadLvl
            // 
            this.LoginheadLvl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginheadLvl.AutoSize = true;
            this.LoginheadLvl.BackColor = System.Drawing.Color.Transparent;
            this.LoginheadLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginheadLvl.ForeColor = System.Drawing.Color.Yellow;
            this.LoginheadLvl.Location = new System.Drawing.Point(103, 17);
            this.LoginheadLvl.Name = "LoginheadLvl";
            this.LoginheadLvl.Size = new System.Drawing.Size(165, 54);
            this.LoginheadLvl.TabIndex = 2;
            this.LoginheadLvl.Text = "স্বাগতম";
            this.LoginheadLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLvl
            // 
            this.PasswordLvl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLvl.AutoSize = true;
            this.PasswordLvl.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLvl.ForeColor = System.Drawing.Color.LightGreen;
            this.PasswordLvl.Location = new System.Drawing.Point(145, 168);
            this.PasswordLvl.Name = "PasswordLvl";
            this.PasswordLvl.Size = new System.Drawing.Size(76, 25);
            this.PasswordLvl.TabIndex = 1;
            this.PasswordLvl.Text = "পাসওয়ার্ড";
            // 
            // UserNameLvl
            // 
            this.UserNameLvl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameLvl.AutoSize = true;
            this.UserNameLvl.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLvl.ForeColor = System.Drawing.Color.LightGreen;
            this.UserNameLvl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UserNameLvl.Location = new System.Drawing.Point(120, 102);
            this.UserNameLvl.Name = "UserNameLvl";
            this.UserNameLvl.Size = new System.Drawing.Size(129, 25);
            this.UserNameLvl.TabIndex = 0;
            this.UserNameLvl.Text = "ব্যবহারকারীর নাম ";
            this.UserNameLvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.tollManagementDataSet1;
            // 
            // tblUsersTableAdapter1
            // 
            this.tblUsersTableAdapter1.ClearBeforeFill = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Toll_Automation.Properties.Resources._new;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(364, 391);
            this.Controls.Add(this.Loginpanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(380, 430);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "টোল ব্যবস্থাপনা";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Loginpanel.ResumeLayout(false);
            this.Loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tollManagementDataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Loginpanel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label LoginheadLvl;
        private System.Windows.Forms.Label PasswordLvl;
        private System.Windows.Forms.Label UserNameLvl;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbUserName;
        private tollManagementDataSet1 tollManagementDataSet1;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private System.Windows.Forms.BindingSource tblUsersBindingSource1;
        private tollManagementDataSet1TableAdapters.tblUsersTableAdapter tblUsersTableAdapter1;

    }
}

