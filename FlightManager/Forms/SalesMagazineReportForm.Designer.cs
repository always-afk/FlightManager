
namespace FlightManager.Forms
{
    partial class SalesMagazineReportForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fM_DataDataSet = new FlightManager.FM_DataDataSet();
            this.fMDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesMagazineReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesMagazineReportTableAdapter = new FlightManager.FM_DataDataSetTableAdapters.SalesMagazineReportTableAdapter();
            this.button_FilterData = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_RemoveFilter = new System.Windows.Forms.Button();
            this.button_FilterPassport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fM_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMagazineReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.salesMagazineReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FlightManager.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(743, 401);
            this.reportViewer1.TabIndex = 0;
            // 
            // fM_DataDataSet
            // 
            this.fM_DataDataSet.DataSetName = "FM_DataDataSet";
            this.fM_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fMDataDataSetBindingSource
            // 
            this.fMDataDataSetBindingSource.DataSource = this.fM_DataDataSet;
            this.fMDataDataSetBindingSource.Position = 0;
            // 
            // salesMagazineReportBindingSource
            // 
            this.salesMagazineReportBindingSource.DataMember = "SalesMagazineReport";
            this.salesMagazineReportBindingSource.DataSource = this.fM_DataDataSet;
            // 
            // salesMagazineReportTableAdapter
            // 
            this.salesMagazineReportTableAdapter.ClearBeforeFill = true;
            // 
            // button_FilterData
            // 
            this.button_FilterData.Location = new System.Drawing.Point(559, 8);
            this.button_FilterData.Name = "button_FilterData";
            this.button_FilterData.Size = new System.Drawing.Size(75, 23);
            this.button_FilterData.TabIndex = 1;
            this.button_FilterData.Text = "Filter";
            this.button_FilterData.UseVisualStyleBackColor = true;
            this.button_FilterData.Click += new System.EventHandler(this.button_FilterData_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.salesMagazineReportBindingSource;
            this.comboBox1.DisplayMember = "PassportId";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "PassportId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(317, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(444, 10);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "To";
            // 
            // button_RemoveFilter
            // 
            this.button_RemoveFilter.Location = new System.Drawing.Point(640, 8);
            this.button_RemoveFilter.Name = "button_RemoveFilter";
            this.button_RemoveFilter.Size = new System.Drawing.Size(81, 23);
            this.button_RemoveFilter.TabIndex = 8;
            this.button_RemoveFilter.Text = "RemoveFilter";
            this.button_RemoveFilter.UseVisualStyleBackColor = true;
            this.button_RemoveFilter.Click += new System.EventHandler(this.button_RemoveFilter_Click);
            // 
            // button_FilterPassport
            // 
            this.button_FilterPassport.Location = new System.Drawing.Point(178, 8);
            this.button_FilterPassport.Name = "button_FilterPassport";
            this.button_FilterPassport.Size = new System.Drawing.Size(67, 23);
            this.button_FilterPassport.TabIndex = 9;
            this.button_FilterPassport.Text = "Filter";
            this.button_FilterPassport.UseVisualStyleBackColor = true;
            this.button_FilterPassport.Click += new System.EventHandler(this.button_FilterPassport_Click);
            // 
            // SalesMagazineReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.button_FilterPassport);
            this.Controls.Add(this.button_RemoveFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_FilterData);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SalesMagazineReportForm";
            this.Text = "SalesMagazineReportForm";
            this.Load += new System.EventHandler(this.SalesMagazineReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fM_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMagazineReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource fMDataDataSetBindingSource;
        private FM_DataDataSet fM_DataDataSet;
        private System.Windows.Forms.BindingSource salesMagazineReportBindingSource;
        private FM_DataDataSetTableAdapters.SalesMagazineReportTableAdapter salesMagazineReportTableAdapter;
        private System.Windows.Forms.Button button_FilterData;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_RemoveFilter;
        private System.Windows.Forms.Button button_FilterPassport;
    }
}