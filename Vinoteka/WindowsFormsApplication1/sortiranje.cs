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
    public partial class sortiranje : Form
    {
        public sortiranje()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public struct Bacva
        {
            public int Zapremnina;
            public int Podrum;
            public decimal BrojLitara;
            public int Id;
        }
        public struct Mogucazamjena
        {
            public int iz, u, vino;
            public decimal kolicina;
        }
        List<Mogucazamjena> moguca = new List<Mogucazamjena>();

        private void sortiranje_Load(object sender, EventArgs e)
        {
            List<Bacva> Bacve = new List<Bacva>();
            Bacva Bacvaa;

            string sql = "SELECT Bacve.Zapremnina,Bacve.Podrum, SUM(Vino_u_bacvi.BrojLitara) AS Expr1, Bacve.Id FROM Bacve INNER JOIN Vino_u_bacvi ON Bacve.Id = Vino_u_bacvi.Id_bacve GROUP BY Bacve.Id, Bacve.Zapremnina, Bacve.Podrum";
            SqlDataReader myReader = Baza.Instance.DohvatiDataReader(sql);
            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    Bacvaa.Zapremnina = (int)myReader[0];
                    Bacvaa.Podrum = (int)myReader[1];
                    Bacvaa.BrojLitara = Convert.ToDecimal(myReader[2]);
                    Bacvaa.Id = (int)myReader[3];
                    Bacve.Add(Bacvaa);
                }
            }
            myReader.Close();
            decimal nedostaje = 0;
            for (int i = 0; i < Bacve.Count; i++)
            {
                if (Bacve[i].BrojLitara < Bacve[i].Zapremnina)
                {
                    nedostaje = Bacve[i].Zapremnina - Bacve[i].BrojLitara;
                    for (int j = 0; j < Bacve.Count; j++)
                    {
                        if (Bacve[i].Podrum == Bacve[j].Podrum && i!=j)
                        {
                            if (Bacve[j].BrojLitara < Bacve[j].Zapremnina)
                            {
                                if (nedostaje >= Bacve[j].BrojLitara)
                                {
                                    decimal zamjena = nedostaje - Bacve[j].BrojLitara;
                                    string sql2 = "select Id_vina from Vino_u_bacvi where Id_bacve=" + Bacve[i].Id + " except select Id_vina from Vino_u_bacvi where Id_bacve=" + Bacve[j].Id;
                                    SqlDataReader myReader2 = Baza.Instance.DohvatiDataReader(sql2);
                                    if (!myReader2.HasRows)
                                    {
                                        myReader2.Close();
                                        string poruka = "Mozete staviti vino iz bacve " + Bacve[j].Id + " u bacvu " + Bacve[i].Id + " , a u bacvi "+Bacve[i].Id+" ce ostati " + zamjena + " litara prostora.\n";
                                        lista.Items.Add(poruka);
                                        Mogucazamjena nova = new Mogucazamjena();
                                        nova.iz = Bacve[j].Id;
                                        nova.u = Bacve[i].Id;
                                        //tolko je puno koda ispod jer obični intersect nije dobro htio vraćati
                                        string sql3 = "select Id_vina from Vino_u_bacvi where Id_bacve=" + Bacve[i].Id;
                                        List<int> vina = new List<int>();
                                        SqlDataReader myReader3 = Baza.Instance.DohvatiDataReader(sql3);
                                        if (myReader3.HasRows)
                                        {
                                            while (myReader3.Read())
                                            {
                                                vina.Add((int)myReader3[0]);
                                            }
                                        }
                                        myReader3.Close();
                                        string sql4 = "select Id_vina from Vino_u_bacvi where Id_bacve=" + Bacve[j].Id;
                                        SqlDataReader myReader4 = Baza.Instance.DohvatiDataReader(sql3);
                                        int idvina=-1;
                                        if (myReader4.HasRows)
                                        {
                                            while (myReader4.Read())
                                            {
                                                if (vina.Contains((int)myReader4[0])) idvina=(int)myReader4[0];
                                            }
                                        }
                                        myReader4.Close();
                                        nova.vino = idvina;
                                        nova.kolicina = Bacve[j].BrojLitara;
                                        moguca.Add(nova);
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int trenutni = lista.SelectedIndex;
            if (lista.SelectedIndex >= 0)
            {
                MessageBox.Show(moguca[trenutni].iz + " " + moguca[trenutni].vino);
                Baza.Instance.IzvrsiUpit("delete from Vino_u_bacvi where Id_bacve="+moguca[trenutni].iz+" and Id_vina="+moguca[trenutni].vino);
                decimal skolicina = Convert.ToDecimal(Baza.Instance.DohvatiVrijednost("select BrojLitara from Vino_u_bacvi where Id_bacve=" + moguca[trenutni].u));
                MessageBox.Show(skolicina + " " + moguca[trenutni].kolicina);
                decimal nkolicina = skolicina + moguca[trenutni].kolicina;
                MessageBox.Show(nkolicina + " " + moguca[trenutni].u);
                Baza.Instance.IzvrsiUpit("update Vino_u_bacvi set BrojLitara="+nkolicina+" where Id_bacve=" + moguca[trenutni].u + " and Id_vina=" + moguca[trenutni].vino);
            }
            else MessageBox.Show("Morate odabrati jednu vrijednost!");
        }
    }
}