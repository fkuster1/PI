﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PocetnaFrm : Form
    {
        public PocetnaFrm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var forma3 = new vinogradFrm();
            forma3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var forma6 = new bacve_i_podrumiFrm();
            forma6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var forma = new pretraga_i_pregled_statistikeFrm();
            forma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var forma2 = new PosloviFrm();
            forma2.Show();
        }
    }
}
