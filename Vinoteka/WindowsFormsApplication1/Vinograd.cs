using System;
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
        public int BrojCokota
        {
            get;
            set;
        }
        public void UnesiVinograd()
        {
            Baza.Instance.IzvrsiUpit("insert into Vinograd values(default, '" + Adresa + "', " + BrojCokota + ", '" + DatumSadnje + "');");
        }
    }
}
