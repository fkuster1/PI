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
    public partial class bacve_i_podrumiFrm : Form
    {
        Form loadanje;
        public bacve_i_podrumiFrm()
        {
            InitializeComponent();
            this.CenterToScreen();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var forma4 = new bacveFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma4.Show();
            forma4.TopMost = true;
            Thread loading2 = new Thread(new ThreadStart(dretvaLoading2));
            loading2.Start(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var forma5 = new PodrumiFrm();
            Thread loading = new Thread(new ThreadStart(dretvaLoading));
            loading.Start();
            forma5.Show();
            forma5.TopMost = true;
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
