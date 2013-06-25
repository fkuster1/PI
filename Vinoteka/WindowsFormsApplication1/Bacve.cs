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
        int zapremnina;
        public int Zapremnina
        {
            get { return Zapremnina; }
            set {zapremnina=Math.Abs(value);}
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
            Baza.Instance.IzvrsiUpit("insert into Bacve (Proizvodac, Zapremnina, Vrsta, Podrum, DatumKupnje) values('" + Proizvodac + "', " + zapremnina + ", " + Vrsta + ", " + Podrum + ", '" + DatumKupnje + "');");
        }
    }
}
