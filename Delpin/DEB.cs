using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin
{
    public class DEB
    {
        private long cprCvr;
        private string navn;
        private string gade;
        private int postnr;
        private string by;
        private int tlf;
        private string email;
        private string ansvarlig;

        public DEB(long cprCvr, string navn, string gade, int postnr, string by, int tlf, string email, string ansvarlig)
        {
            this.cprCvr = cprCvr;
            this.navn = navn;
            this.gade = gade;
            this.postnr = postnr;
            this.by = by;
            this.tlf = tlf;
            this.email = email;
            this.ansvarlig = ansvarlig;         
        }

        public DEB()
        {

        }
       

        public long CprCvr
        {            
            get { return cprCvr; }
            set { this.cprCvr = value; }
        }

        public string Navn
        {
            get { return navn; }
            set { this.navn = value; }
        }

        public string Gade
        {
            get { return gade; }
            set { this.gade = value; }
        }

        public int Postnr
        {
            get { return postnr; }
            set { this.postnr = value; }
        }

        public string By
        {
            get { return by; }
            set { this.by = value; }
        }

        public int Tlf
        {
            get { return tlf; }
            set { this.tlf = value; }
        }

        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }

        public string Ansvarlig
        {
            get { return ansvarlig; }
            set { this.ansvarlig = value; }
        }
    }
}
