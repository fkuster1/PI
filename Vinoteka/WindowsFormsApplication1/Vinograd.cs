﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Vinograd
    {
        public string Adresa
        {
            get;
            set;
        }
        public string DatumSadnje
        {
            get;
            set;
        }
        int brojCokota;
        public int BrojCokota
        {
            get { return BrojCokota; }
            set { brojCokota = Math.Abs(value); }
        }
        public void UnesiVinograd()
        {
            Baza.Instance.IzvrsiUpit("insert into Vinograd (Adresa, Broj_cokota, Vrijeme_sadnje) values('" + Adresa + "', " + brojCokota + ", '" + DatumSadnje + "');");
        }
    }
}
