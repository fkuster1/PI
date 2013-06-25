using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Butelje
    {
        int brojButelji;
        public int BrojButelji
        {
            get{ return BrojButelji; }
            set{ brojButelji = Math.Abs(value); }
        }
        float zapremnina;
        public float Zapremnina
        {
            get{ return Zapremnina; }
            set{ zapremnina = Math.Abs(value); }
        }
        public int SadrziVino
        {
            get;
            set;
        }
        public void UnesiPodrum()
        {
            Baza.Instance.IzvrsiUpit("insert into Butelje (Vino_iz_bacve, BrojButelja, Zapremnina_butelje) values(" + SadrziVino + ", "+brojButelji+", " + zapremnina + ");");
        }
    }
}
