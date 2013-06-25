﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class PocetnaFrm : Form
    {
        Form loadanje;
        public PocetnaFrm()
        {
            Thread loading = new Thread(new ThreadStart(dretvaLoading));//za početak loadanje
            loading.Start();
            InitializeComponent();
            this.CenterToScreen();
            CheckForIllegalCrossThreadCalls = false;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();

            //ako ima obavijesti, boja gumba za Poslove će se promijeniti u blago crvenu
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
                if (dp > prije1 && dp < kasnije1 || dp > prije2 && dp < kasnije2 || dp > prije3 && dp < kasnije3)
                {
                    button2.BackColor = Color.IndianRed;
                }
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var forma3 = new vinogradFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma3.Show();
            forma3.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var forma6 = new bacve_i_podrumiFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma6.Show();
            forma6.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var forma = new pretraga_i_pregled_statistikeFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma.Show();
            forma.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var forma2 = new PosloviFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma2.Show();
            forma2.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void PocetnaFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Baza.Instance.Connection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var forma3 = new UnosButeljaFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma3.Show();
            forma3.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var forma4 = new UnosVinaFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma4.Show();
            forma4.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var forma4 = new UnosVinoveLozeFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma4.Show();
            forma4.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var forma4 = new VinoUBacvamaFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma4.Show();
            forma4.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var forma4 = new Sorte_Poslovi();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma4.Show();
            forma4.TopMost = true;
            this.TopMost = false;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            var forma4 = new vrijemefrm();
            forma4.Show();
            forma4.TopMost = true;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            var forma4 = new VinogradiReport();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma4.Show();
            forma4.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var forma4 = new sortiranje();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma4.Show();
            forma4.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }


        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            var forma11 = new ModifikacijaVinaFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma11.Show();
            forma11.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var forma12 = new ModifikacijaVinogradaFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma12.Show();
            forma12.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var forma13 = new ModifikacijaVinoveLozeFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma13.Show();
            forma13.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var forma14 = new ModifikacijaBacviFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma14.Show();
            forma14.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var forma15 = new ModifikacijaPodrumaFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma15.Show();
            forma15.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            var forma16 = new ModifikacijaOstalihUnosaFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma16.Show();
            forma16.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var forma17 = new ModifikacijaPoslovaFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma17.Show();
            forma17.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            var forma18 = new ModifikacijaButeljaFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma18.Show();
            forma18.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var forma19 = new ModifikacijaVinaUBacvamaFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma19.Show();
            forma19.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start();
        }

        //dretvene metode
        public void dretvaLoading()
        {
            loadanje = new LoadFrm();
            loadanje.ShowDialog();
            loadanje.TopMost = true;
        }
        public void dretvaLoading2()
        {
            loadanje.Close();
        }

    }
}
