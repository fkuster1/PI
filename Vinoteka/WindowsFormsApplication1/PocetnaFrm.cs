using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

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
