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
    public partial class bacve_i_podrumi : Form
    {
        public bacve_i_podrumi()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var forma4 = new bacve();
            forma4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var forma5 = new Podrumi();
            forma5.Show();
        }
    }
}
