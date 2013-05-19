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
    public partial class pretraga_i_pregled_statistike : Form
    {
        public pretraga_i_pregled_statistike()
        {
            InitializeComponent();
        }

        private void pretraga_i_pregled_statistike_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet.vino' table. You can move, or remove it, as needed.
            this.vinoTableAdapter.Fill(this.vinotekaDataSet.vino);
            // TODO: This line of code loads data into the 'vinotekaDataSet.bacve' table. You can move, or remove it, as needed.
            this.bacveTableAdapter.Fill(this.vinotekaDataSet.bacve);
            // TODO: This line of code loads data into the 'vinotekaDataSet.Podrum' table. You can move, or remove it, as needed.
            this.podrumTableAdapter.Fill(this.vinotekaDataSet.Podrum);
            // TODO: This line of code loads data into the 'vinotekaDataSet.vinograd' table. You can move, or remove it, as needed.
            this.vinogradTableAdapter.Fill(this.vinotekaDataSet.vinograd);
            // TODO: This line of code loads data into the 'vinotekaDataSet.Obavljeni_poslovi' table. You can move, or remove it, as needed.
            this.obavljeni_posloviTableAdapter.Fill(this.vinotekaDataSet.Obavljeni_poslovi);
            // TODO: This line of code loads data into the 'vinotekaDataSet.Sorta' table. You can move, or remove it, as needed.
            this.sortaTableAdapter.Fill(this.vinotekaDataSet.Sorta);

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
