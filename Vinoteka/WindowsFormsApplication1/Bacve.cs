using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Bacve
    {
        public string Proizvodac
        {
            get;
            set;
        }
        public int Zapremnina
        {
            get;
            set;
        }
        public int Vrsta
        {
            get;
            set;
        }
        public int Podrum
        {
            get;
            set;
        }
        public string DatumKupnje
        {
            get;
            set;
        }
        public void UnesiBacvu()
        {
            Baza.Instance.IzvrsiUpit("insert into Bacve values(default, '" + Proizvodac + "', " + Zapremnina + ", " + Vrsta + ", " + Podrum + ", '" + DatumKupnje + "');");
        }
    }
}
