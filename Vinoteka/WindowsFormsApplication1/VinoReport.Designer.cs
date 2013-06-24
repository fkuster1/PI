namespace WindowsFormsApplication1
{
    partial class VinoReport
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
            this.VinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VinoTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.VinoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VinotekaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // VinoBindingSource
            // 
            this.VinoBindingSource.DataMember = "Vino";
            this.VinoBindingSource.DataSource = this.VinotekaDataSet1;
            // 
            // VinotekaDataSet1
            // 
            this.VinotekaDataSet1.DataSetName = "VinotekaDataSet1";
            this.VinotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VinoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // VinoTableAdapter
            // 
            this.VinoTableAdapter.ClearBeforeFill = true;
            // 
            // VinoReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VinoReport";
            this.Text = "VinoReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VinoReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VinotekaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VinoBindingSource;
        private VinotekaDataSet1 VinotekaDataSet1;
        private VinotekaDataSet1TableAdapters.VinoTableAdapter VinoTableAdapter;
    }
}