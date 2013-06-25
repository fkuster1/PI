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
    public partial class ModifikacijaPodrumaFrm : Form
    {
        public ModifikacijaPodrumaFrm()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void podrumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string sql = "update Podrum set Adresa='" + adresaTextBox.Text + "', Broj_mjesta=" + Convert.ToInt32(broj_mjestaTextBox.Text) + " where Id=" + Convert.ToInt32(idTextBox.Text);
            Baza.Instance.IzvrsiUpit(sql);
            this.Validate();
            this.podrumBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vinotekaDataSet1);
        }

        private void ModifikacijaPodrumaFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Podrum' table. You can move, or remove it, as needed.
            this.podrumTableAdapter.Fill(this.vinotekaDataSet1.Podrum);

        }

    }
}
