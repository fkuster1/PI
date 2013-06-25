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
    public partial class ModifikacijaVinoveLozeFrm : Form
    {
        public ModifikacijaVinoveLozeFrm()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vinova_lozaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string sql = "update Vinova_loza set Sorta=" + Convert.ToInt32(sortaTextBox.Text) + ", BrojCokota=" + Convert.ToInt32(brojCokotaTextBox.Text) + ", Vinograd=" + Convert.ToInt32(vinogradTextBox.Text) + " where Id=" + Convert.ToInt32(idTextBox.Text);
            Baza.Instance.IzvrsiUpit(sql);
            this.Validate();
            this.vinova_lozaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vinotekaDataSet1);

        }

        private void ModifikacijaVinoveLozeFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vinova_loza' table. You can move, or remove it, as needed.
            this.vinova_lozaTableAdapter.Fill(this.vinotekaDataSet1.Vinova_loza);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string sql = "delete from Vinova_loza where Id=" + Convert.ToInt32(idTextBox.Text);
            Baza.Instance.IzvrsiUpit(sql);
            this.Validate();
            this.vinova_lozaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vinotekaDataSet1);
        }
    }
}
