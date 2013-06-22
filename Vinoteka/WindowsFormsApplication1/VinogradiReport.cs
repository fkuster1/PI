using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class VinogradiReport : Form
    {
        public VinogradiReport()
        {
            InitializeComponent();
        }

        private void VinogradiReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VinotekaDataSet1.Vinova_loza' table. You can move, or remove it, as needed.
            this.Vinova_lozaTableAdapter.Fill(this.VinotekaDataSet1.Vinova_loza);
            // TODO: This line of code loads data into the 'VinotekaDataSet1.Sorta' table. You can move, or remove it, as needed.
            this.SortaTableAdapter.Fill(this.VinotekaDataSet1.Sorta);
            // TODO: This line of code loads data into the 'VinotekaDataSet1.Vinograd' table. You can move, or remove it, as needed.
            this.VinogradTableAdapter.Fill(this.VinotekaDataSet1.Vinograd);

            this.reportViewer1.RefreshReport();
        }
    }
}
