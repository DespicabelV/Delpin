using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace Delpin
{
    public class Temp_Katrine
    {
    }

    class DataBM
    {
        SqlConnection conn;
        SqlCommand com;

        //Forbindelsen
        private string Connection()
        {
            return "Data Source=den1.mssql7.gear.host; Initial Catalog=delpinas; User Id=delpinas; Password=Lu3wumM-!cTu";
        }

        //Forbinder databasen
        private void ForbindDatabase(string kommando)
        {
            try
            {
                Console.WriteLine(kommando);
                conn = new SqlConnection(Connection());
                conn.Open();
                com = new SqlCommand(kommando, conn);
                com.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Der er sket en fejl i din SQL");
                //Udskriver fejltypen:
                Console.WriteLine(ex.Message);
                //Udskriver kommandoen:
                Console.WriteLine(com.CommandText);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<string> HentLejeListe(string start, string slut)
        {
            List<string> linje = new List<string>();
            string slutdato, resnr, gade, postnummer, by, startdato, nyLinje;
           
            string SelectSqlString = $"select LOL.resnr, LOL.startDato, LOL.slutDato, LO.gade, LO.postnr, LO.byen from LejeOrdreLinjer LOL " +
                $"join LejeOrdre LO on LOL.ordrenr = LOL.ordrenr " +
                $"where startDato >= '{start}' AND slutDato <= '{slut}' " +
                $"Order by startDato";
            SqlConnection conn = new SqlConnection(Connection());
            conn.Open();
            SqlCommand comselect = new SqlCommand(SelectSqlString, conn);

            SqlDataReader myReader = comselect.ExecuteReader();
            while (myReader.Read())
            {
                startdato = myReader["startDato"].ToString();
                slutdato = myReader["slutDato"].ToString();
                resnr = myReader["resnr"].ToString();
                gade = myReader["gade"].ToString();
                postnummer = myReader["postnr"].ToString();
                by = myReader["byen"].ToString();

                
                nyLinje = "Startdato: " + startdato + "\t Slutdato: " + slutdato + "\t Resnr: " + resnr + "\t Gade: " + gade + "\t Postnummer: " + postnummer + "\t By: " + by;
                linje.Add(nyLinje);
                

            }
            
            myReader.Close();
            
            conn.Close();
            return linje;

        }
    }
}
