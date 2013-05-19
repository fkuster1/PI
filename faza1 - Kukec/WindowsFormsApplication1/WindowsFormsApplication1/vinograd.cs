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
    public partial class vinograd : Form
    {
        public vinograd()
        {
            InitializeComponent();
        }

        private void vinograd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet.vinograd' table. You can move, or remove it, as needed.
            this.vinogradTableAdapter.Fill(this.vinotekaDataSet.vinograd);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
