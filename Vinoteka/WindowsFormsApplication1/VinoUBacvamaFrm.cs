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
    public partial class VinoUBacvamaFrm : Form
    {
        bool ucitano = false;
        VinoJeUBacvama vinob;
        public VinoUBacvamaFrm()
        {
            InitializeComponent();
            this.CenterToScreen();

            //popunimo combobox vina
            vinob = new VinoJeUBacvama();
            var dataSource = new List<Comboi>();
            SqlDataReader myReader = Baza.Instance.DohvatiDataReader("SELECT Vino.Id, 'Vrsta: '+RTRIM(Vrsta_vina.Ime) + ', Godina proizvodnje: ' + CAST(Vino.Godina_proizvodnje AS VARCHAR(50)) AS nekaj FROM Vino INNER JOIN Vrsta_vina ON Vino.Vrsta = Vrsta_vina.Id");
            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    dataSource.Add(new Comboi() { Name = myReader[1].ToString(), Value = myReader[0].ToString() });
                }
            }
            myReader.Close();
            this.vino.DataSource = dataSource;
            this.vino.DisplayMember = "Name";
            this.vino.ValueMember = "Value";

            //popunimo combobox bačvi
            var dataSource1 = new List<Comboi>();
            SqlDataReader myReader1 = Baza.Instance.DohvatiDataReader("SELECT Bacve.Id, 'Podrum:' + RTRIM(Podrum.Adresa) + ',  Id: ' + CAST(Bacve.Id AS VARCHAR(50)) AS nekaj FROM Bacve INNER JOIN Podrum ON Bacve.Podrum = Podrum.Id");
            if (myReader1.HasRows)
            {
                while (myReader1.Read())
                {
                    dataSource1.Add(new Comboi() { Name = myReader1[1].ToString(), Value = myReader1[0].ToString() });
                }
            }
            myReader1.Close();
            this.bacva.DataSource = dataSource1;
            this.bacva.DisplayMember = "Name";
            this.bacva.ValueMember = "Value";

            ucitano = true;
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
            vinob.Bacva = Convert.ToInt32(bacva.SelectedValue);
            vinob.Vino = Convert.ToInt32(vino.SelectedValue);
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
                    object imavec = Baza.Instance.DohvatiVrijednost("exec BrojLitara @bacva="+vinob.Bacva+", @vino="+vinob.Vino);
                    if (imavec==null)
                    {
                        vinob.UnesiVinoUBacvu();
                    }
                    else
                    {
                        vinob.AzurirajVinoUBacvi();
                    }
                    preostalo -= vinob.BrojLitara;
                    preostalooo.Text = preostalo.ToString();
                }
                else MessageBox.Show("Ne može stati toliku vina u tu bačvu!");
            }
        }

        private void bacva_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ucitano)
            {
                int idbacva = Convert.ToInt32(bacva.SelectedValue);
                object pom1 = Baza.Instance.DohvatiVrijednost("select Zapremnina from Bacve where Id=" + idbacva + ";");
                object pom = Baza.Instance.DohvatiVrijednost("select sum(BrojLitara) from Vino_u_bacvi where Id_bacve=" + idbacva + ";");
                if (DBNull.Value != pom1)
                {
                    int ukupno = Convert.ToInt32(pom1);
                    double iskoristeno;
                    if (DBNull.Value != pom)
                    {
                        iskoristeno = Convert.ToDouble(pom);
                    }
                    else iskoristeno = 0;
                    double preostalo = ukupno - iskoristeno;
                    preostalooo.Text = preostalo.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vinoTableAdapter.FillBy(this.vinotekaDataSet1.Vino);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }

    public class Comboi
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
