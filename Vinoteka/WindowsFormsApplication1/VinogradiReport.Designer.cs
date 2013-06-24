namespace WindowsFormsApplication1
{
    partial class VinogradiReport
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
            this.VinogradBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VinogradTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.VinogradTableAdapter();
            this.Vinova_lozaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Vinova_lozaTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.Vinova_lozaTableAdapter();
            this.SortaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SortaTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.SortaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VinogradBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vinova_lozaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VinogradBindingSource
            // 
            this.VinogradBindingSource.DataMember = "Vinograd";
            this.VinogradBindingSource.DataSource = this.VinotekaDataSet1;
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
            reportDataSource1.Value = this.VinogradBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // VinogradTableAdapter
            // 
            this.VinogradTableAdapter.ClearBeforeFill = true;
            // 
            // Vinova_lozaBindingSource
            // 
            this.Vinova_lozaBindingSource.DataMember = "Vinova_loza";
            this.Vinova_lozaBindingSource.DataSource = this.VinotekaDataSet1;
            // 
            // Vinova_lozaTableAdapter
            // 
            this.Vinova_lozaTableAdapter.ClearBeforeFill = true;
            // 
            // SortaBindingSource
            // 
            this.SortaBindingSource.DataMember = "Sorta";
            this.SortaBindingSource.DataSource = this.VinotekaDataSet1;
            // 
            // SortaTableAdapter
            // 
            this.SortaTableAdapter.ClearBeforeFill = true;
            // 
            // VinogradiReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VinogradiReport";
            this.Text = "VinogradiReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VinogradiReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VinogradBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VinotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vinova_lozaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VinogradBindingSource;
        private VinotekaDataSet1 VinotekaDataSet1;
        private VinotekaDataSet1TableAdapters.VinogradTableAdapter VinogradTableAdapter;
        private System.Windows.Forms.BindingSource Vinova_lozaBindingSource;
        private System.Windows.Forms.BindingSource SortaBindingSource;
        private VinotekaDataSet1TableAdapters.Vinova_lozaTableAdapter Vinova_lozaTableAdapter;
        private VinotekaDataSet1TableAdapters.SortaTableAdapter SortaTableAdapter;
    }
}