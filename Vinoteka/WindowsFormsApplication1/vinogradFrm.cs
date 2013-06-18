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
    public partial class vinogradFrm : Form
    {
        Vinograd vinograd;
        public vinogradFrm()
        {
            InitializeComponent();
            vinograd = new Vinograd(); 
            string vin = (string)Baza.Instance.DohvatiVrijednost("select top 1 Adresa from Vinograd order by Id desc;");
            label4.Text = vin;
        }

        private void vinograd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet.vinograd' table. You can move, or remove it, as needed.
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vinograd.Adresa = adresa.Text;
            vinograd.DatumSadnje = datumSadnje.Value.ToShortDateString();
            vinograd.BrojCokota = Convert.ToInt32(broj_cokota.Text);
            vinograd.UnesiVinograd();
            string vin = (string)Baza.Instance.DohvatiVrijednost("select top 1 Adresa from Vinograd order by Id desc;");
            label4.Text = vin;
        }
    }
}
