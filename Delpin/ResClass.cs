using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin
{
    class ResClass
    {
    }

    public class HovedKategori
    {
        public HovedKategori(string navn)
        {
            Navn = navn;
        }
        public string Navn { get; set; }
    }

    public class Kategori
    {

        //Klassen gemmer navn og id fra hovedkategori

        public Kategori(string navn, int id)
        {
            Navn = navn;
            this.id = id;
        }

        public string Navn { get; set; }
        public int id { get; set; }
    }

    public class Res
    {
        public Res(double pris, string navn, int resnr, string startDato, string slutDato)
        {
            Navn = navn;
            Pris = pris;
            Resnr = resnr;
            StartDato = startDato;
            SlutDato = slutDato;
        }

        public string Navn { get; set; }
        public double Pris { get; set; }
        public int Resnr { get; set; }

        public string StartDato { get; set; }
        public string SlutDato { get; set; }
    }
}
