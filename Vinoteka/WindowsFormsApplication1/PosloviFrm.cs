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
    public partial class PosloviFrm : Form
    {
        public PosloviFrm()
        {
            InitializeComponent();
        }

        private void Poslovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet.Poslovi' table. You can move, or remove it, as needed.
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
