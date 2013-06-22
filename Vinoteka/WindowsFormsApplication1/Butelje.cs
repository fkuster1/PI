using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Butelje
    {
        public int BrojButelji
        {
            get{ return BrojButelji; }
            set{ BrojButelji = Math.Abs(value); }
        }
        public float Zapremnina
        {
            get{ return Zapremnina; }
            set{ Zapremnina = Math.Abs(value); }
        }
        public int SadrziVino
        {
            get;
            set;
        }
        public void UnesiPodrum()
        {
            Baza.Instance.IzvrsiUpit("insert into Butelje (Vino_iz_bacve, BrojButelja, Zapremnina_butelje) values(" + SadrziVino + ", " + BrojButelji + ", " + Zapremnina + ");");
        }
    }
}
