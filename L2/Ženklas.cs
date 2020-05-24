using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L2
{
    /// <summary>
    /// Ženklo klasė
    /// </summary>
    public class Ženklas
    {
        public string Pavadinimas { get; set; }
        public int Metai { get; set; }
        public double Kaina { get; set; }

        public Ženklas() { }

        public Ženklas(string pavadinimas, int metai, double kaina)
        {
            Pavadinimas = pavadinimas;
            Metai = metai;
            Kaina = kaina;
        }

        public override string ToString()
        {
            string eilute;
            eilute = string.Format("{0, -20} {1, -20} {2, -20}",
            Pavadinimas, Metai, Kaina);
            return eilute;
        }

        static public bool operator >(Ženklas pirmas, Ženklas
antras)
        {
            int ip = String.Compare(pirmas.Pavadinimas,
            antras.Pavadinimas, StringComparison.CurrentCulture);
            return pirmas.Kaina > antras.Kaina ||
            pirmas.Kaina == antras.Kaina && ip < 0;
        }
        static public bool operator <(Ženklas pirmas,
        Ženklas antras)
        {
            return !(pirmas > antras);
        }
    }

}