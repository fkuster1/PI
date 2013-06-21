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
    public partial class Sorte_Poslovi : Form
    {
        public Sorte_Poslovi()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Baza.Instance.IzvrsiUpit("insert into Vrsta_vina (Ime) values('" + txtVrstaVina.Text + "');");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baza.Instance.IzvrsiUpit("insert into Sorta (Naziv) values('" + txtSorta.Text + "');");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baza.Instance.IzvrsiUpit("insert into Poslovi (Ime) values('" + txtPosao.Text + "');");
        }
    }
}
