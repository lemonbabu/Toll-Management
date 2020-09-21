namespace Toll_Automation
{
    partial class frmUnitToll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnitToll));
            this.tblAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenuber = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblVehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tollManagementDataSetTblVehicles2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tollManagementDataSetTblVehicles2 = new Toll_Automation.tollManagementDataSetTblVehicles2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbVehicleName = new System.Windows.Forms.ComboBox();
            this.tblVehiclesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewTollRate = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tblVehiclesTableAdapter = new Toll_Automation.tollManagementDataSetTblVehicles2TableAdapters.tblVehiclesTableAdapter();
            this.tblVehiclesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAdmin.SuspendLayout();
            this.pnlMenuber.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tollManagementDataSetTblVehicles2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tollManagementDataSetTblVehicles2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAdmin
            // 
            this.tblAdmin.ColumnCount = 3;
            this.tblAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tblAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblAdmin.Controls.Add(this.pnlMenuber, 1, 0);
            this.tblAdmin.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tblAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAdmin.Location = new System.Drawing.Point(0, 0);
            this.tblAdmin.Name = "tblAdmin";
            this.tblAdmin.RowCount = 3;
            this.tblAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.tblAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblAdmin.Size = new System.Drawing.Size(844, 501);
            this.tblAdmin.TabIndex = 1;
            this.tblAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.tblAdmin_Paint);
            // 
            // pnlMenuber
            // 
            this.pnlMenuber.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuber.Controls.Add(this.button4);
            this.pnlMenuber.Controls.Add(this.button3);
            this.pnlMenuber.Controls.Add(this.button2);
            this.pnlMenuber.Controls.Add(this.button1);
            this.pnlMenuber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuber.Location = new System.Drawing.Point(104, 3);
            this.pnlMenuber.Name = "pnlMenuber";
            this.pnlMenuber.Size = new System.Drawing.Size(635, 44);
            this.pnlMenuber.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.SystemColors.Menu;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(1, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "অ্যাডমিন";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(478, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "বেরিয়ে যান";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(319, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "প্রতিবেদন দেখুন";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(160, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "তথ্য সংগ্রহ করুন";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(104, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 369);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleNameDataGridViewTextBoxColumn,
            this.unitTollDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblVehiclesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(320, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(312, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblVehiclesBindingSource
            // 
            this.tblVehiclesBindingSource.DataMember = "tblVehicles";
            this.tblVehiclesBindingSource.DataSource = this.tollManagementDataSetTblVehicles2BindingSource;
            // 
            // tollManagementDataSetTblVehicles2BindingSource
            // 
            this.tollManagementDataSetTblVehicles2BindingSource.DataSource = this.tollManagementDataSetTblVehicles2;
            this.tollManagementDataSetTblVehicles2BindingSource.Position = 0;
            // 
            // tollManagementDataSetTblVehicles2
            // 
            this.tollManagementDataSetTblVehicles2.DataSetName = "tollManagementDataSetTblVehicles2";
            this.tollManagementDataSetTblVehicles2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbVehicleName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNewTollRate);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 363);
            this.panel1.TabIndex = 1;
            // 
            // cmbVehicleName
            // 
            this.cmbVehicleName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblVehiclesBindingSource2, "Id", true));
            this.cmbVehicleName.DataSource = this.tblVehiclesBindingSource2;
            this.cmbVehicleName.DisplayMember = "VehicleName";
            this.cmbVehicleName.FormattingEnabled = true;
            this.cmbVehicleName.Location = new System.Drawing.Point(70, 113);
            this.cmbVehicleName.Name = "cmbVehicleName";
            this.cmbVehicleName.Size = new System.Drawing.Size(179, 21);
            this.cmbVehicleName.TabIndex = 14;
            this.cmbVehicleName.ValueMember = "Id";
            // 
            // tblVehiclesBindingSource2
            // 
            this.tblVehiclesBindingSource2.DataMember = "tblVehicles";
            this.tblVehiclesBindingSource2.DataSource = this.tollManagementDataSetTblVehicles2BindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "নতুন টোলের হার ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "যানবাহন নিবাচন করুন";
            // 
            // txtNewTollRate
            // 
            this.txtNewTollRate.Location = new System.Drawing.Point(70, 186);
            this.txtNewTollRate.Name = "txtNewTollRate";
            this.txtNewTollRate.Size = new System.Drawing.Size(179, 20);
            this.txtNewTollRate.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSubmit.ForeColor = System.Drawing.Color.Green;
            this.btnSubmit.Location = new System.Drawing.Point(108, 254);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 35);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "সম্পূর্ণ করুন";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tblVehiclesTableAdapter
            // 
            this.tblVehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // tblVehiclesBindingSource1
            // 
            this.tblVehiclesBindingSource1.DataMember = "tblVehicles";
            this.tblVehiclesBindingSource1.DataSource = this.tollManagementDataSetTblVehicles2;
            // 
            // vehicleNameDataGridViewTextBoxColumn
            // 
            this.vehicleNameDataGridViewTextBoxColumn.DataPropertyName = "VehicleName";
            this.vehicleNameDataGridViewTextBoxColumn.HeaderText = "যানবাহনের নাম";
            this.vehicleNameDataGridViewTextBoxColumn.Name = "vehicleNameDataGridViewTextBoxColumn";
            this.vehicleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitTollDataGridViewTextBoxColumn
            // 
            this.unitTollDataGridViewTextBoxColumn.DataPropertyName = "UnitToll";
            this.unitTollDataGridViewTextBoxColumn.HeaderText = "টোলের হার";
            this.unitTollDataGridViewTextBoxColumn.Name = "unitTollDataGridViewTextBoxColumn";
            this.unitTollDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmUnitToll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 501);
            this.Controls.Add(this.tblAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(860, 440);
            this.Name = "frmUnitToll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "টোলের হার পরিবর্তন";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUnitToll_Load);
            this.tblAdmin.ResumeLayout(false);
            this.pnlMenuber.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tollManagementDataSetTblVehicles2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tollManagementDataSetTblVehicles2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehiclesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblAdmin;
        private System.Windows.Forms.Panel pnlMenuber;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tollManagementDataSetTblVehicles2BindingSource;
        private tollManagementDataSetTblVehicles2 tollManagementDataSetTblVehicles2;
        private System.Windows.Forms.BindingSource tblVehiclesBindingSource;
        private tollManagementDataSetTblVehicles2TableAdapters.tblVehiclesTableAdapter tblVehiclesTableAdapter;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tblVehiclesBindingSource1;
        private System.Windows.Forms.TextBox txtNewTollRate;
        private System.Windows.Forms.ComboBox cmbVehicleName;
        private System.Windows.Forms.BindingSource tblVehiclesBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTollDataGridViewTextBoxColumn;
    }
}