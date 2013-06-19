using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class VinoJeUBacvama
    {
        public int Vino
        {
            get;
            set;
        }
        public int Bacva
        {
            get;
            set;
        }
        public float BrojLitara
        {
            get;
            set;
        }
        public void UnesiVinoUBacvu()
        {
            Baza.Instance.IzvrsiUpit("insert into Vino_u_bacvi (Id_bacve, Id_vina, BrojLitara) values(" + Bacva + ", " + Vino + ", " + BrojLitara + ");");
        }
        public void AzurirajVinoUBacvi()
        {
            decimal stariBrLitara = Convert.ToDecimal(Baza.Instance.DohvatiVrijednost("select BrojLitara from Vino_u_bacvi where Id_bacve=" + Bacva + " and Id_vina=" + Vino + ";"));
            float noviBrLitara=(float)stariBrLitara+BrojLitara;      
            Baza.Instance.IzvrsiUpit("update Vino_u_bacvi set BrojLitara=" + noviBrLitara + " where Id_bacve="+Bacva+" and Id_vina="+Vino+";");
        }
    }
}
