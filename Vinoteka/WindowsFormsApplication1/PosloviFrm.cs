using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            DateTime d = DateTime.Now;
            DateTime prije1 = d.AddDays(-15);
            prije1 = prije1.AddYears(-1);
            DateTime kasnije1 = d.AddDays(15);
            kasnije1 = kasnije1.AddYears(-1);
            DateTime prije2 = d.AddDays(-15);
            prije2 = prije2.AddYears(-2);
            DateTime kasnije2 = d.AddDays(15);
            kasnije2 = kasnije2.AddYears(-2);
            DateTime prije3 = d.AddDays(-15);
            prije3 = prije3.AddYears(-3);
            DateTime kasnije3 = d.AddDays(15);
            kasnije3 = kasnije3.AddYears(-3);
            SqlDataReader reader = Baza.Instance.DohvatiDataReader("select Opis, Datum, Ime from Obavljeni_poslovi, Poslovi where Poslovi.Id=Obavljeni_poslovi.Id_Posla;");
            while (reader.Read())
            {
                string datum = reader[1].ToString();
                DateTime dp = Convert.ToDateTime(datum);
                if (dp>prije1 && dp<kasnije1 || dp>prije2 && dp<kasnije2 || dp>prije3 && dp<kasnije3) 
                {
                    listBox1.Items.Add("Datuma " + datum.Trim() + " ste obavili posao " + reader[2].ToString().Trim() + " sa opisom " + reader[0].ToString().Trim() + ".");
                }
            }
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
