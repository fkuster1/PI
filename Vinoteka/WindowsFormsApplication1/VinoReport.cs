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
    public partial class VinoReport : Form
    {
        public VinoReport()
        {
            InitializeComponent();
        }

        private void VinoReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VinotekaDataSet1.Vino' table. You can move, or remove it, as needed.
            this.VinoTableAdapter.Fill(this.VinotekaDataSet1.Vino);

            this.reportViewer1.RefreshReport();
        }
    }
}
