namespace WindowsFormsApplication1
{
    partial class PodrumiReport
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
            this.PodrumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PodrumTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.PodrumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PodrumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VinotekaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PodrumBindingSource
            // 
            this.PodrumBindingSource.DataMember = "Podrum";
            this.PodrumBindingSource.DataSource = this.VinotekaDataSet1;
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
            reportDataSource1.Value = this.PodrumBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // PodrumTableAdapter
            // 
            this.PodrumTableAdapter.ClearBeforeFill = true;
            // 
            // PodrumiReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PodrumiReport";
            this.Text = "PodrumiReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PodrumiReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PodrumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VinotekaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PodrumBindingSource;
        private VinotekaDataSet1 VinotekaDataSet1;
        private VinotekaDataSet1TableAdapters.PodrumTableAdapter PodrumTableAdapter;
    }
}