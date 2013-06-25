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
    public partial class ModifikacijaVinaUBacvamaFrm : Form
    {
        public ModifikacijaVinaUBacvamaFrm()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vino_u_bacviBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string sql = "update Vino_u_bacvi set BrojLitara=" + Convert.ToInt32(brojLitaraTextBox.Text) + " where Id_bacve=" + Convert.ToInt32(id_bacveTextBox.Text) + " and Id_vina=" + Convert.ToInt32(id_vinaTextBox.Text);
            Baza.Instance.IzvrsiUpit(sql);
            this.Validate();
            this.vino_u_bacviBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vinotekaDataSet1);

        }

        private void ModifikacijaVinaUBacvamaFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vino_u_bacvi' table. You can move, or remove it, as needed.
            this.vino_u_bacviTableAdapter.Fill(this.vinotekaDataSet1.Vino_u_bacvi);

        }

    }
}
