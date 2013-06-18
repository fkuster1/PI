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
    public partial class VinoUBacvamaFrm : Form
    {
        VinoJeUBacvama vinob;
        public VinoUBacvamaFrm()
        {
            InitializeComponent();
            vinob = new VinoJeUBacvama();
        }

        private void VinuUBacvamaFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Bacve' table. You can move, or remove it, as needed.
            this.bacveTableAdapter.Fill(this.vinotekaDataSet1.Bacve);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vino' table. You can move, or remove it, as needed.
            this.vinoTableAdapter.Fill(this.vinotekaDataSet1.Vino);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vinob.Bacva = Convert.ToInt32(bacva.Text);
            vinob.Vino = Convert.ToInt32(vino.Text);
            vinob.BrojLitara = float.Parse(brlitara.Text);
            vinob.UnesiVinoUBacvu();
        }
    }
}
