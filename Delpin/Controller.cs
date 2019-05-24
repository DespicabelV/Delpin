using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delpin
{
    class Controller
    {
        Database_Manager dbm = new Database_Manager();

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

        public void SkrivOpretFil(string filnavn, string start, string slut)
        {
            //Opretter filnavn. Filnavnet hedder startdato + slutdato. 
            filnavn = $"{filnavn}.txt";
            StreamWriter outputStream = null;

            outputStream = new StreamWriter(filnavn);
            List<string> linje = new List<string>();

            //Der laves en liste som bliver udfyldt med informationer fra databasen. 
            linje = dbm.HentLejeListe(start, slut);
            for (int i = 0; i < linje.Count; i++)
            {
                //Udskriver hver linje i listen til en fil.
                outputStream.WriteLine(linje[i]);

            }

            string filename = filnavn;
            System.Diagnostics.Process.Start(filnavn);

            if (outputStream != null)
                outputStream.Close();
        }
    }
}
