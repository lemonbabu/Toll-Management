namespace Toll_Automation
{
    partial class frmReportHourly
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportHourly));
            this.reportViewerHourlyData = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnOk = new System.Windows.Forms.Button();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.dataSetTblDataTime = new Toll_Automation.DataSetTblDataTime();
            this.tblDataTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDataTimeTableAdapter = new Toll_Automation.DataSetTblDataTimeTableAdapters.tblDataTimeTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbTimeEx = new System.Windows.Forms.ComboBox();
            this.tollManagementDataSetTblDataTime = new Toll_Automation.tollManagementDataSetTblDataTime();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tollManagementDataSetReport1 = new Toll_Automation.tollManagementDataSetReport1();
            this.tblTotalVehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTotalVehiclesTableAdapter = new Toll_Automation.tollManagementDataSetReport1TableAdapters.tblTotalVehiclesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTblDataTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tollManagementDataSetTblDataTime)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tollManagementDataSetReport1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTotalVehiclesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerHourlyData
            // 
            this.reportViewerHourlyData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerHourlyData.DocumentMapCollapsed = true;
            reportDataSource1.Name = "DataSetReportHourlyData";
            reportDataSource1.Value = this.tblDataTimeBindingSource;
            this.reportViewerHourlyData.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerHourlyData.LocalReport.ReportEmbeddedResource = "Toll_Automation.ReportHourlyData.rdlc";
            this.reportViewerHourlyData.Location = new System.Drawing.Point(168, 107);
            this.reportViewerHourlyData.Name = "reportViewerHourlyData";
            this.reportViewerHourlyData.Size = new System.Drawing.Size(635, 395);
            this.reportViewerHourlyData.TabIndex = 15;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(444, 11);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cmbTime
            // 
            this.cmbTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbTime.Location = new System.Drawing.Point(207, 11);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(116, 21);
            this.cmbTime.TabIndex = 17;
            // 
            // dataSetTblDataTime
            // 
            this.dataSetTblDataTime.DataSetName = "DataSetTblDataTime";
            this.dataSetTblDataTime.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDataTimeBindingSource
            // 
            this.tblDataTimeBindingSource.DataMember = "tblDataTime";
            this.tblDataTimeBindingSource.DataSource = this.dataSetTblDataTime;
            // 
            // tblDataTimeTableAdapter
            // 
            this.tblDataTimeTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.SystemColors.Menu;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(6, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 30);
            this.button4.TabIndex = 21;
            this.button4.Text = "অ্যাডমিন";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(483, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 30);
            this.button3.TabIndex = 20;
            this.button3.Text = "বেরিয়ে যান";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(324, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 30);
            this.button2.TabIndex = 19;
            this.button2.Text = "প্রতিবেদন দেখুন";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(165, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "তথ্য সংগ্রহ করুন";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbTimeEx
            // 
            this.cmbTimeEx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTimeEx.FormattingEnabled = true;
            this.cmbTimeEx.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbTimeEx.Location = new System.Drawing.Point(329, 11);
            this.cmbTimeEx.Name = "cmbTimeEx";
            this.cmbTimeEx.Size = new System.Drawing.Size(90, 21);
            this.cmbTimeEx.TabIndex = 22;
            // 
            // tollManagementDataSetTblDataTime
            // 
            this.tollManagementDataSetTblDataTime.DataSetName = "tollManagementDataSetTblDataTime";
            this.tollManagementDataSetTblDataTime.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewerHourlyData, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 521);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.cmbTimeEx);
            this.panel1.Controls.Add(this.cmbTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(168, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 46);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(168, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 46);
            this.panel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "সময় নির্বাচন করুন";
            // 
            // tollManagementDataSetReport1
            // 
            this.tollManagementDataSetReport1.DataSetName = "tollManagementDataSetReport1";
            this.tollManagementDataSetReport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTotalVehiclesBindingSource
            // 
            this.tblTotalVehiclesBindingSource.DataMember = "tblTotalVehicles";
            this.tblTotalVehiclesBindingSource.DataSource = this.tollManagementDataSetReport1;
            // 
            // tblTotalVehiclesTableAdapter
            // 
            this.tblTotalVehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Toll_Automation.Properties.Resources.rsz_106472076_603608706937951_4676661359971261923_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 521);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "প্রতিবেদন (ঘণ্টা হিসাবে)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTblDataTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tollManagementDataSetTblDataTime)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tollManagementDataSetReport1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTotalVehiclesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerHourlyData;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cmbTime;
        private DataSetTblDataTime dataSetTblDataTime;
        private System.Windows.Forms.BindingSource tblDataTimeBindingSource;
        private DataSetTblDataTimeTableAdapters.tblDataTimeTableAdapter tblDataTimeTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTimeEx;
        private tollManagementDataSetTblDataTime tollManagementDataSetTblDataTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tblTotalVehiclesBindingSource;
        private tollManagementDataSetReport1 tollManagementDataSetReport1;
        private tollManagementDataSetReport1TableAdapters.tblTotalVehiclesTableAdapter tblTotalVehiclesTableAdapter;
    }
}