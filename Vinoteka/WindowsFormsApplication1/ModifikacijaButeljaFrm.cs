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
    public partial class ModifikacijaButeljaFrm : Form
    {
        public ModifikacijaButeljaFrm()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buteljeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            string sql = "update Butelje set Vino_iz_bacve=" + Convert.ToInt32(vino_iz_bacveTextBox.Text) + ", BrojButelja=" + Convert.ToInt32(brojButeljaTextBox.Text) + ", Zapremnina_butelje=" + Convert.ToInt32(zapremnina_buteljeTextBox.Text) + " where Id=" + Convert.ToInt32(idTextBox.Text);
            Baza.Instance.IzvrsiUpit(sql);
            this.Validate();
            this.buteljeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vinotekaDataSet1);

        }

        private void ModifikacijaButeljaFrm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Butelje' table. You can move, or remove it, as needed.
            this.buteljeTableAdapter.Fill(this.vinotekaDataSet1.Butelje);

        }
    }
}
