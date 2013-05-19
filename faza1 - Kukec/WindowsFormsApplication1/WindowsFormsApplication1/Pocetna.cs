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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var forma3 = new vinograd();
            forma3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var forma6 = new bacve_i_podrumi();
            forma6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var forma = new pretraga_i_pregled_statistike();
            forma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var forma2 = new Poslovi();
            forma2.Show();
        }
    }
}
