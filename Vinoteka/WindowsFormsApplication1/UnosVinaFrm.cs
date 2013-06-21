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
    public partial class UnosVinaFrm : Form
    {
        Vino vino;
        public UnosVinaFrm()
        {
            InitializeComponent();
            this.CenterToScreen();
            vino = new Vino();
            SqlDataReader reader = Baza.Instance.DohvatiDataReader("select Vinova_loza.Id,Sorta.Naziv, Vinograd.Adresa from Vinova_loza, Sorta, Vinograd where Sorta.Id=Vinova_loza.Sorta and Vinova_loza.Vinograd=Vinograd.Id;");
            while (reader.Read())
            {
                loze.Items.Add(reader[0]);
            }
        }

        private void UnosVinaFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vinova_loza' table. You can move, or remove it, as needed.
            this.vinova_lozaTableAdapter.Fill(this.vinotekaDataSet1.Vinova_loza);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vrsta_vina' table. You can move, or remove it, as needed.
            this.vrsta_vinaTableAdapter.Fill(this.vinotekaDataSet1.Vrsta_vina);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vino.GodinaProizvodnje = Convert.ToInt32(godina.Text);
            vino.Kiselina = float.Parse(kiselina.Text);
            vino.Kolicina = Convert.ToInt32(brlitara.Text);
            vino.Alkohol = float.Parse(alkohol.Text);
            vino.VrstaVina = Convert.ToInt32(vrstavina.SelectedValue);
            foreach (int a in loze.CheckedItems)
            {
                vino.DodajLozu(a);
            }
            vino.UnesiVino();
        }

    }
}
