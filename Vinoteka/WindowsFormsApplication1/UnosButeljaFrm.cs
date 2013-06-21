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
    public partial class UnosButeljaFrm : Form
    {
        Butelje butelje;
        public UnosButeljaFrm()
        {
            InitializeComponent();
            this.CenterToScreen();
            butelje = new Butelje();
        }

        private void UnosButeljaFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Bacve' table. You can move, or remove it, as needed.
            this.bacveTableAdapter.Fill(this.vinotekaDataSet1.Bacve);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            butelje.BrojButelji = Convert.ToInt32(brojbutelja.Text);
            butelje.Zapremnina = Convert.ToInt32(zapremnina.Text);
            butelje.SadrziVino = (int)izbacve.SelectedValue;
            butelje.UnesiPodrum();
            int idVina = (int)Baza.Instance.DohvatiVrijednost("select top 1 Id from Butelje order by Id desc;");
            label4.Text = idVina.ToString();
        }
    }
}
