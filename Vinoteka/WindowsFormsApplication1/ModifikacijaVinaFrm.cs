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
    public partial class ModifikacijaVinaFrm : Form
    {
        public ModifikacijaVinaFrm()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vinoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string sql = "update Vino set Godina_proizvodnje=" + Convert.ToInt32(godina_proizvodnjeTextBox.Text) + ", BrojLitara=" + Convert.ToInt32(brojLitaraTextBox.Text) + ", Vrsta=" + Convert.ToInt32(vrstaTextBox.Text) + ", Kiselina=" + Convert.ToInt32(kiselinaTextBox.Text) + ", Alkohol=" + Convert.ToInt32(alkoholTextBox.Text) + " where Id=" + Convert.ToInt32(idTextBox.Text);
            Baza.Instance.IzvrsiUpit(sql);
            this.Validate();
            this.vinoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vinotekaDataSet1);

        }

        private void ModifikacijaVinaFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vino' table. You can move, or remove it, as needed.
            this.vinoTableAdapter.Fill(this.vinotekaDataSet1.Vino);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string sql = "delete from Vino where Id=" + Convert.ToInt32(idTextBox.Text);
            Baza.Instance.IzvrsiUpit(sql);
            this.Validate();
            this.vinoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vinotekaDataSet1);
        }
    }
}
