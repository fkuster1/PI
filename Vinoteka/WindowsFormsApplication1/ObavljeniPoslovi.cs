using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class ObavljeniPoslovi
    {
        public int VrstaPosla
        {
            get;
            set;
        }
        public float Trajanje
        {
            get;
            set;
        }
        public string Datum
        {
            get;
            set;
        }
        public string Opis
        {
            get;
            set;
        }
        public int idVinograda
        {
            get;
            set;
        }
        public int idPodruma
        {
            get;
            set;
        }
        public void UnesiPosao()
        {
            Baza.Instance.IzvrsiUpit("insert into Obavljeni_poslovi (Id_vinograda, Id_posla, Opis, Datum, Trajanje, PodrumId) values(" + idVinograda + ", " + VrstaPosla + ", '" + Opis + "', '" + Datum + "', " + Trajanje + ", " + idPodruma + ");");
        }
    }
}
