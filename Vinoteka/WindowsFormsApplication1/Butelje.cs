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
            get;
            set;
        }
        public float Zapremnina
        {
            get;
            set;
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
