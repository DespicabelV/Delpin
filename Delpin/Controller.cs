using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin
{
    class Controller
    {

       
        public static void GemDEB(long cprCvr, string navn, string gade, int postnr, string by, int tlf, string email, string ansvarlig)
        {
            Database_Manager dbm = new Database_Manager();
            DEB deb = new DEB(cprCvr, navn, gade, postnr, by, tlf, email, ansvarlig);
            dbm.IndsætDEB(deb);
        }

        public static DEB HentDEB(long cprCvr)
        {
            Database_Manager dbm = new Database_Manager();
            DEB deb = dbm.HentDEB(cprCvr);
            return deb;
        }

        public static void SletDEB(long cprCvr)
        {
            Database_Manager dbm = new Database_Manager();
            dbm.SletDEB(cprCvr);
        }

        public static void UpdateDEB(long cprCvr, string navn, string gade, int postnr, string by, int tlf, string email, string ansvarlig)
        {
            Database_Manager dbm = new Database_Manager();
            DEB deb = new DEB(cprCvr, navn, gade, postnr, by, tlf, email, ansvarlig);
            dbm.UpdateDEB(deb);
        }

    }
}
