using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
        public class Pojistenec
        {
            public string Jmeno { get; set; }
            public string Prijmeni { get; set; }
            public int Vek { get; set; }
            public int Telefon { get; set; }

            public Pojistenec(string jmeno, string prijmeni, int vek, int telefon)
            {
                this.Jmeno = jmeno;
                this.Prijmeni = prijmeni;
                this.Vek = vek;
                this.Telefon = telefon;
            }
        public override string ToString()
        {
            return Jmeno + "   " + Prijmeni + "   " + Vek + "      " + Telefon;
        }
    }
}
