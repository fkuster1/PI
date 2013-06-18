using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Vino
    {
        public int GodinaProizvodnje
        {
            get;
            set;
        }
        public float Alkohol
        {
            get;
            set;
        }
        public float Kiselina
        {
            get;
            set;
        }
        public float Kolicina
        {
            get;
            set;
        }
        public int VrstaVina //tu ce se spremiti kljuc od vrijednosti iz padajuceg izbornika 
        {
            get;
            set;
        }
        private List<int> vinoJeOdLoze=new List<int>();
        public void DodajLozu(int loza)
        {
            vinoJeOdLoze.Add(loza);
        }
        public void UnesiVino()
        {
            Baza.Instance.IzvrsiUpit("insert into Vino (Godina_proizvodnje, BrojLitara, Vrsta, Kiselina, Alkohol) values(" + GodinaProizvodnje + ", " + Kolicina + ", " + VrstaVina + ", " + Kiselina + ", " + Alkohol + ");");
            int idVina = (int)Baza.Instance.DohvatiVrijednost("select top 1 Id from Vino order by Id desc;");
            foreach (int vino in vinoJeOdLoze)
            {
                Baza.Instance.IzvrsiUpit("insert into Vino_je_od values(" + idVina + ", " + vino + ");");
            }
        }
    }
}
