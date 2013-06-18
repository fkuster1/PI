using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Vinova_loza
    {
        public int Sorta
        {
            get;
            set;
        }
        public int Broj_cokota
        {
            get;
            set;
        }
        public int Vinograd
        {
            get;
            set;
        }
        public void UnesiLozu()
        {
            Baza.Instance.IzvrsiUpit("insert into Vinova_loza (Sorta, BrojCokota, Vinograd) values(" + Sorta + ", " + Broj_cokota + ", " + Vinograd + ");");
        }
    }
}
