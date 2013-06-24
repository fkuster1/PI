﻿using System;
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
        }
        public struct Bacva
        {
            public int Zapremnina;
            public int Podrum;
            public decimal BrojLitara;
            public int Id;
        }

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
                                        string poruka = "Mozete staviti vino iz bacve " + Bacve[j].Id + " u bacvu " + Bacve[i].Id + " , a u bacvi "+Bacve[i].Id+" ce ostati " + zamjena + " litara prostora.\n";
                                        richTextBox1.Text += poruka;
                                    }
                                    myReader2.Close();
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}