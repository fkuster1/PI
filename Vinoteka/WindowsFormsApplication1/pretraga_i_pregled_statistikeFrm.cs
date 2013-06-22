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
    public partial class pretraga_i_pregled_statistikeFrm : Form
    {
        public pretraga_i_pregled_statistikeFrm()
        {
            InitializeComponent();
            this.CenterToScreen();
            slikabacve.Image = Properties.Resources.Barrel;
        }

        private void pretraga_i_pregled_statistike_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Bacve' table. You can move, or remove it, as needed.
            this.bacveTableAdapter.Fill(this.vinotekaDataSet1.Bacve);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Bacve' table. You can move, or remove it, as needed.
            //this.bacveTableAdapter.Fill(this.vinotekaDataSet1.Bacve);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vino' table. You can move, or remove it, as needed.
            this.vinoTableAdapter.Fill(this.vinotekaDataSet1.Vino);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vinograd' table. You can move, or remove it, as needed.
            this.vinogradTableAdapter.Fill(this.vinotekaDataSet1.Vinograd);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Podrum' table. You can move, or remove it, as needed.
            this.podrumTableAdapter.Fill(this.vinotekaDataSet1.Podrum);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Obavljeni_poslovi' table. You can move, or remove it, as needed.
            this.obavljeni_posloviTableAdapter.Fill(this.vinotekaDataSet1.Obavljeni_poslovi);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Poslovi' table. You can move, or remove it, as needed.
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            int podrum = (int)dataGridView3.CurrentRow.Cells[0].Value;
            this.bacveTableAdapter.PopuniBacve(vinotekaDataSet1.Bacve, podrum);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int pocetna = Convert.ToInt32(pocetak.Text);
            int zavrsna = Convert.ToInt32(kraj.Text);
            this.vinoTableAdapter.PopuniVinaPoGodinama(vinotekaDataSet1.Vino, pocetna, zavrsna);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string pocetna = datepoc.Value.ToShortDateString();
            string zavrsna = datekraj.Value.ToShortDateString();
            this.vinogradTableAdapter.DajVinogradePoGodinama(vinotekaDataSet1.Vinograd, pocetna, zavrsna);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string pocetna = poslovipoc.Value.ToShortDateString();
            string zavrsna = poslovikraj.Value.ToShortDateString();
            this.obavljeni_posloviTableAdapter.DajPoslovePoDatumu(vinotekaDataSet1.Obavljeni_poslovi, pocetna, zavrsna);
        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView4.CurrentRow!=null)
            {
                int bacva = (int)dataGridView4.CurrentRow.Cells[0].Value;
                object pom1 = Baza.Instance.DohvatiVrijednost("select Zapremnina from Bacve where Id=" + bacva + ";");
                object pom = Baza.Instance.DohvatiVrijednost("select sum(BrojLitara) from Vino_u_bacvi where Id_bacve=" + bacva + ";");
                if (DBNull.Value != pom && DBNull.Value != pom1)
                {
                    int ukupno = (int)pom1;
                    double iskoristeno = Convert.ToDouble(pom);
                    double postotak = iskoristeno / ukupno;
                    postotak = Math.Round(postotak, 2);
                    if (postotak <= 0.2) slikabacve.Image = Properties.Resources.Barrel;
                    else if (postotak <= 0.4) slikabacve.Image = Properties.Resources.Barrel1;
                    else if (postotak <= 0.6) slikabacve.Image = Properties.Resources.Barrel2;
                    else if (postotak <= 0.8) slikabacve.Image = Properties.Resources.Barrel3;
                    else slikabacve.Image = Properties.Resources.Barrel4;
                    string tip = "Popunjenost bačve: " + (postotak*100).ToString() + "%";
                    toolTip1.SetToolTip(this.slikabacve, tip);
                }
                else
                {
                    slikabacve.Image = Properties.Resources.Barrel;
                    string tip = "Popunjenost bačve: 0%";
                    toolTip1.SetToolTip(this.slikabacve, tip);
                }
            }
        }

      


    }
}
