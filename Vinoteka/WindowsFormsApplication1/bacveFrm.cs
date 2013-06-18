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
    public partial class bacveFrm : Form
    {
        Bacve bacve;
        public bacveFrm()
        {
            
            InitializeComponent();
            bacve = new Bacve();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bacve.Proizvodac = proizvodac.Text;
            bacve.Zapremnina = Convert.ToInt32(zapremnina.Text);
            bacve.Podrum = (int)podrum.SelectedValue;
            bacve.Vrsta = (int)vrsta.SelectedValue;
            bacve.DatumKupnje = datum.Value.ToShortDateString();
            bacve.UnesiBacvu();
        }

        private void bacveFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vrsta_bacvi' table. You can move, or remove it, as needed.
            this.vrsta_bacviTableAdapter.Fill(this.vinotekaDataSet1.Vrsta_bacvi);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Podrum' table. You can move, or remove it, as needed.
            this.podrumTableAdapter.Fill(this.vinotekaDataSet1.Podrum);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vrsta_bacvi' table. You can move, or remove it, as needed.
            this.vrsta_bacviTableAdapter.Fill(this.vinotekaDataSet1.Vrsta_bacvi);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vrsta_bacvi' table. You can move, or remove it, as needed.
            this.vrsta_bacviTableAdapter.Fill(this.vinotekaDataSet1.Vrsta_bacvi);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Podrum' table. You can move, or remove it, as needed.
            this.podrumTableAdapter.Fill(this.vinotekaDataSet1.Podrum);

        }
    }
}
