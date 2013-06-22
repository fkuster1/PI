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
    public partial class PodrumiReport : Form
    {
        public PodrumiReport()
        {
            InitializeComponent();
        }

        private void PodrumiReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VinotekaDataSet1.Podrum' table. You can move, or remove it, as needed.
            this.PodrumTableAdapter.Fill(this.VinotekaDataSet1.Podrum);

            this.reportViewer1.RefreshReport();
        }
    }
}
