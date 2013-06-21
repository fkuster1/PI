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
    public partial class UnosVinoveLozeFrm : Form
    {
        Vinova_loza vinova;
        public UnosVinoveLozeFrm()
        {
            InitializeComponent();
            this.CenterToScreen();
            vinova = new Vinova_loza();
        }

        private void UnosVinoveLozeFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vinograd' table. You can move, or remove it, as needed.
            this.vinogradTableAdapter.Fill(this.vinotekaDataSet1.Vinograd);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Sorta' table. You can move, or remove it, as needed.
            this.sortaTableAdapter.Fill(this.vinotekaDataSet1.Sorta);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vinova.Broj_cokota = Convert.ToInt32(brojcokota.Text);
            vinova.Vinograd = Convert.ToInt32(vinograd.SelectedValue);
            vinova.Sorta = Convert.ToInt32(sorte.SelectedValue);
            vinova.UnesiLozu();
        }
    }
}
