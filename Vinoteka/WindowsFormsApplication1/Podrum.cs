using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Podrum
    {
        public string Adresa
        {
            get;
            set;
        }
        public int BrojMjesta
        {
            get;
            set;
        }
        public void UnesiPodrum()
        {
            Baza.Instance.IzvrsiUpit("insert into Podrum (Adresa, Broj_mjesta) values('" + Adresa + "', " + BrojMjesta + ");");
        }
    }
}
