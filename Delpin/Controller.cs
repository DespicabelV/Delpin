﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delpin
{
    class Controller
    {
        //Katrine:
        Database_Manager DBM = new Database_Manager();

        public void GemDEB(long cprCvr, string navn, string gade, int postnr, string by, int tlf, string email, string ansvarlig)
        {
            DEB deb = new DEB(cprCvr, navn, gade, postnr, by, tlf, email, ansvarlig);
            DBM.IndsætDEB(deb);
        }

        public DEB HentDEB(long cprCvr)
        {
            DEB deb = DBM.HentDEB(cprCvr);
            return deb;
        }

        //Det er ikke muligt at slette en DEB i øjeblikket.
        //public void SletDEB(long cprCvr)
        //{
        //    DBM.SletDEB(cprCvr);
        //}

        public void UpdateDEB(long cprCvr, string navn, string gade, int postnr, string by, int tlf, string email, string ansvarlig)
        {
            DEB deb = new DEB(cprCvr, navn, gade, postnr, by, tlf, email, ansvarlig);
            DBM.UpdateDEB(deb);
        }

        public void SkrivOpretFil(string filnavn, string start, string slut)
        {
            //Opretter filnavn. Filnavnet hedder startdato + slutdato. 
            filnavn = $"{filnavn}.txt";
            StreamWriter outputStream = null;
            
            outputStream = new StreamWriter(filnavn);
            List<string> linje = new List<string>();

            //Der laves en liste som bliver udfyldt med informationer fra databasen. 
            linje = DBM.HentLejeListe(start, slut);
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
