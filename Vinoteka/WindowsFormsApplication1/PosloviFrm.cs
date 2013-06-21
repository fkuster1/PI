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
        ObavljeniPoslovi poslovi;
        public PosloviFrm()
        {
            InitializeComponent();
            this.CenterToScreen();
            poslovi = new ObavljeniPoslovi();
        }

        private void Poslovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Poslovi' table. You can move, or remove it, as needed.
            this.posloviTableAdapter.Fill(this.vinotekaDataSet1.Poslovi);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Podrum' table. You can move, or remove it, as needed.
            this.podrumTableAdapter.Fill(this.vinotekaDataSet1.Podrum);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vinograd' table. You can move, or remove it, as needed.
            this.vinogradTableAdapter.Fill(this.vinotekaDataSet1.Vinograd);
            // TODO: This line of code loads data into the 'vinotekaDataSet.Poslovi' table. You can move, or remove it, as needed.
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            poslovi.VrstaPosla = (int)posao.SelectedValue;
            poslovi.Trajanje = Convert.ToInt32(trajanje.Text);
            poslovi.Datum = datum.Value.ToShortDateString();
            poslovi.Opis = opis.Text;
            poslovi.idVinograda = (int)vinograd.SelectedValue;
            poslovi.idPodruma = (int)podrum.SelectedValue;
            poslovi.UnesiPosao();
        }
    }
}
