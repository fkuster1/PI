﻿using System;
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
        int brojMjesta;
        public int BrojMjesta
        {
            get { return BrojMjesta; }
            set { brojMjesta = Math.Abs(value); }
        }
        public void UnesiPodrum()
        {
            Baza.Instance.IzvrsiUpit("insert into Podrum (Adresa, Broj_mjesta) values('" + Adresa + "', " + brojMjesta + ");");
        }
    }
}
