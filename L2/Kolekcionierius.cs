using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L2
{
    /// <summary>
    /// Kolekcionieriaus klasė
    /// </summary>
    public class Kolekcionierius
    {
        public string Pavarde { get; set; }
        public string Vardas { get; set; }
        public string Zenklas { get; set; }
        public int Kiekis { get; set; }
        public double Kaina { get; set; }

        public Kolekcionierius(string pavarde, string vardas, string zenklas, int kiekis, double kaina)
        {
            Pavarde = pavarde;
            Vardas = vardas;
            Zenklas = zenklas;
            Kiekis = kiekis;
            Kaina = kaina;
        }

        public override string ToString()
        {
            string eilute;
            eilute = string.Format("{0, -20} {1, -20} {2,-20} {3,-20} {4,-20}",
            Pavarde, Vardas,Zenklas,Kiekis,Kaina);
            return eilute;
        }

        static public bool operator >(Kolekcionierius pirmas, Kolekcionierius
antras)
        {
            int ip = String.Compare(pirmas.Zenklas,
            antras.Zenklas, StringComparison.CurrentCulture);
            return ip > 0 || ip == 0 && pirmas.Kaina > antras.Kaina;
        }
        static public bool operator <(Kolekcionierius pirmas,
        Kolekcionierius antras)
        {
            return !(pirmas > antras);
        }
    }
}