using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L2
{
    /// <summary>
    /// Aukciono sąrašo klasė
    /// </summary>
    public class Aukcionas
    {
        /// <summary>
        /// Aukciono mazgo klasė
        /// </summary>
        private sealed class AMazgas
        {
            public Ženklas Duom { get; set; }
            public AMazgas Kitas { get; set; }
            public AMazgas() { }

            public AMazgas(Ženklas duom, AMazgas kitas)
            {
                Duom = duom;
                Kitas = kitas;
            }
        }
        private AMazgas pr;
        private AMazgas pb;
        private AMazgas d;

        public Aukcionas()
        {
            pr = null;
            pb = null;
            d = null;
        }

        public void Pradžia()
        {
            d = pr;
        }

        public void Kitas()
        {
            d = d.Kitas;
        }

        public bool Yra()
        {
            return d != null;
        }

        public Ženklas ImtiDuomenis()
        {
            return d.Duom;
        }

        public void DetiDuomenisA(Ženklas ženklas)
        {
            pr = new AMazgas(ženklas, null);
        }

        public void DėtiDuomenisT(Ženklas naujas)
        {
            var dd = new AMazgas(naujas, null);
            if (pr != null)
            {
                pb.Kitas = dd;
                pb = dd;
            }
            else
            {
                pr = dd;
                pb = dd;
            }
        }

        public void Rikiuoti()
        {
            for (AMazgas d1 = pr; d1 != null; d1 = d1.Kitas)
            {
                AMazgas minv = d1;
                for (AMazgas d2 = d1.Kitas; d2 != null; d2 = d2.Kitas)
                    if (d2.Duom < minv.Duom)
                        minv = d2;
                // Informacinių dalių sukeitimas vietomis
                Ženklas St = d1.Duom;
                d1.Duom = minv.Duom;
                minv.Duom = St;
            }
        }

        public Ženklas RastiŽenklą(string tekstas)
        {
            for (AMazgas d1 = pr; d1 != null; d1 = d1.Kitas)
            {
                Ženklas ženklas = d1.Duom;
                if (ženklas.Pavadinimas.Equals(tekstas))
                {
                    return ženklas;
                }
            }
            return null;
        }
    }
}