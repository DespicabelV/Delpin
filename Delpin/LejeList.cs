using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin
{
    class LejeList
    {
        private int resnr;
        private string navn, start, slut;
        private double pris;

        public LejeList(int resnr, string navn, double pris, string start, string slut)
        {
            this.resnr = resnr;
            this.navn = navn;
            this.pris = pris;
            this.start = start;
            this.slut = slut;
        }
    }
}
