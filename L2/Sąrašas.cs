using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L2
{
    /// <summary>
    /// Sąrašo klasė
    /// </summary>
    public sealed class Sąrašas
    {
        private sealed class Mazgas
        {
            public Kolekcionierius Duom { get; set; }
            public Mazgas Kitas { get; set; }
            public Mazgas() { }

            public Mazgas(Kolekcionierius reikme, Mazgas adr)
            {
                Duom = reikme;
                Kitas = adr;
            }
        }
        // Čia klasės Mazgas aprašas
        private Mazgas pr; // sąrašo pradžia
        private Mazgas pb; // sąrašo pabaiga
        private Mazgas d; // sąrašo sąsaja
                          /** Pradinės sąrašo adresų reikšmės */
        public Sąrašas()
        {
            pr = null;
            pb = null;
            d = null;
        }

        //-----------------------------------------------
        /** Sąsajai priskiriama sąrašo pradžia */
        public void Pradžia()
        { d = pr; }
        /** Sąsajai priskiriamas tolesnis elementas */
        public void Kitas()
        {
            d = d.Kitas;
        }
        public void Pabaiga()
        {
            d = pb;
        }
        /** Grąžina true, jeigu sąrašas netuščias */
        public bool YraK()
        { return d != null; }
        public bool Yra()
        { return d != null; }
        //-----------------------------------------------
        /** Grąžina sąrašo sąsajos elemento reikšmę */
        public Kolekcionierius ImtiDuomenis()
        { return d.Duom; }

        public void DėtiDuomenisA(Kolekcionierius naujas)
        {
            pr = new Mazgas(naujas, pr);
        }

        public void DėtiDuomenisT(Kolekcionierius naujas)
        {
            var dd = new Mazgas(naujas, null);
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

        public int Kiekis(string pavadinimas)
        {
            int kiek = 0;
            for(Mazgas a = pr; a != null; a = a.Kitas)
            {
                Kolekcionierius kol = a.Duom;
                if (kol.Zenklas.Equals(pavadinimas)) kiek++;
            }
            return kiek;
        }

        public void Rikiuoti()
        {
            for (Mazgas d1 = pr; d1 != null; d1 = d1.Kitas)
            {
                Mazgas minv = d1;
                for (Mazgas d2 = d1.Kitas; d2 != null; d2 = d2.Kitas)
                    if (d2.Duom < minv.Duom)
                        minv = d2;
                // Informacinių dalių sukeitimas vietomis
                Kolekcionierius St = d1.Duom;
                d1.Duom = minv.Duom;
                minv.Duom = St;
            }
        }
    }
}