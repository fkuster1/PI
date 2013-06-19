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
    public partial class VinoUBacvamaFrm : Form
    {
        VinoJeUBacvama vinob;
        public VinoUBacvamaFrm()
        {
            InitializeComponent();
            vinob = new VinoJeUBacvama();
        }

        private void VinuUBacvamaFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Bacve' table. You can move, or remove it, as needed.
            this.bacveTableAdapter.Fill(this.vinotekaDataSet1.Bacve);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vino' table. You can move, or remove it, as needed.
            this.vinoTableAdapter.Fill(this.vinotekaDataSet1.Vino);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vinob.Bacva = Convert.ToInt32(bacva.Text);
            vinob.Vino = Convert.ToInt32(vino.Text);
            vinob.BrojLitara = float.Parse(brlitara.Text);
            object pom1 = Baza.Instance.DohvatiVrijednost("select Zapremnina from Bacve where Id=" + vinob.Bacva + ";");
            object pom = Baza.Instance.DohvatiVrijednost("select sum(BrojLitara) from Vino_u_bacvi where Id_bacve=" + vinob.Bacva + ";");
            if (DBNull.Value != pom1)
            {
                int ukupno = (int)pom1;
                double iskoristeno;
                if (DBNull.Value != pom)
                {
                    iskoristeno = Convert.ToDouble(pom);
                }
                else iskoristeno = 0;
                double preostalo = ukupno - iskoristeno;
                if (vinob.BrojLitara <= preostalo)
                {
                    object imavec = Baza.Instance.DohvatiVrijednost("select BrojLitara from Vino_u_bacvi where Id_bacve=" + vinob.Bacva + " and Id_vina=" + vinob.Vino + ";");
                    if (imavec==null)
                    {
                        vinob.UnesiVinoUBacvu();
                    }
                    else
                    {
                        vinob.AzurirajVinoUBacvi();
                    }
                    preostalo -= vinob.BrojLitara;
                    preostalotxt.Text = "Preostalo: " + preostalo.ToString();
                }
                else MessageBox.Show("Ne može stati toliku vina u tu bačvu!");
            }
        }

        private void bacva_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idbacva = Convert.ToInt32(bacva.Text);
            object pom1 = Baza.Instance.DohvatiVrijednost("select Zapremnina from Bacve where Id=" + idbacva + ";");
            object pom = Baza.Instance.DohvatiVrijednost("select sum(BrojLitara) from Vino_u_bacvi where Id_bacve=" + idbacva + ";");
            if (DBNull.Value != pom1)
            {
                int ukupno = (int)pom1;
                double iskoristeno;
                if (DBNull.Value != pom)
                {
                    iskoristeno = Convert.ToDouble(pom);
                }
                else iskoristeno = 0;
                double preostalo = ukupno - iskoristeno;
                preostalotxt.Text = "Preostalo: " + preostalo.ToString();
            }
        }
    }
}
