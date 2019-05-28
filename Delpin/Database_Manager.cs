using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Delpin
{
    class Database_Manager
    {
        SqlConnection conn;
        SqlCommand com;
        SqlDataReader reader;

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
        public void IndsætDEB(DEB deb)
        {
            try
            {
                string InsertSqlString = $"Insert into DEB(cprCvr, navn, gade, postnr, byen, email, tlf, ansvarlig)" +
                                                  $"values({deb.CprCvr},'{deb.Navn}','{deb.Gade}',{deb.Postnr},'{deb.By}','{deb.Email}',{deb.Tlf},'{deb.Ansvarlig}')";
                Console.WriteLine(InsertSqlString);
                conn = new SqlConnection(Connection());
                conn.Open();
                com = new SqlCommand(InsertSqlString, conn);
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

        public DEB HentDEB(long cprCvr)
        {
            DEB deb = new DEB();
            string SelectSqlString = $"Select * from DEB where cprCvr = {cprCvr}";
            SqlConnection conn = new SqlConnection(Connection());
            conn.Open();
            SqlCommand comselect = new SqlCommand(SelectSqlString, conn);

            SqlDataReader myReader = comselect.ExecuteReader();
            while (myReader.Read())
            {
                deb = new DEB(Convert.ToInt64(myReader["cprCvr"].ToString()),
                myReader["navn"].ToString(),
                myReader["gade"].ToString(),
                Convert.ToInt32(myReader["postnr"].ToString()),
                myReader["byen"].ToString(),
                Convert.ToInt32(myReader["tlf"].ToString()),
                myReader["email"].ToString(),
                myReader["ansvarlig"].ToString());


            }
            myReader.Close();
            conn.Close();
            return deb;
        }

        public void SletDEB(long cprCvr)
        {
            string DeleteSqlString = $"Delete from DEB where cprCvr = {cprCvr}";
            Console.WriteLine(DeleteSqlString);
            SqlConnection conn = new SqlConnection(Connection());
            conn.Open();
            SqlCommand com = new SqlCommand(DeleteSqlString, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }
 
        public void UpdateDEB(DEB deb)
        {
            string UpdateSqlString = $"Update DEB set cprCvr = '{deb.CprCvr}', " +
                $"navn = '{deb.Navn}', gade = '{deb.Gade}', postnr = {deb.Postnr}, byen = '{deb.By}', tlf = {deb.Tlf}," +
                $" email = '{deb.Email}', ansvarlig = '{deb.Ansvarlig}' where cprCvr = {deb.CprCvr}";
            Console.WriteLine(UpdateSqlString);
            SqlConnection conn = new SqlConnection(Connection());
            conn.Open();
            SqlCommand com = new SqlCommand(UpdateSqlString, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }

        public List<string> HentLejeListe(string start, string slut)
        {
            List<string> linje = new List<string>();
            string slutdato, startdato, resnr, gade, postnummer, by, nyLinje, levering;

            string SelectSqlString = $"select LOL.resnr, LOL.startDato, LOL.slutDato, LO.gade, LO.postnr, LO.levering, LO.byen from LejeOrdreLinjer LOL " +
                $"join LejeOrdre LO on LOL.ordrenr = LOL.ordrenr " +
                $"where startDato >= '{start}' AND startDato <= '{slut}' " +
                $"OR slutDato <= '{slut}' AND slutDato > '{start}' " +
                $"Order by startDato ";
            SqlConnection conn = new SqlConnection(Connection());
            conn.Open();
            SqlCommand comselect = new SqlCommand(SelectSqlString, conn);

            SqlDataReader myReader = comselect.ExecuteReader();
            while (myReader.Read())
            {
                //Startdato og slutdato laves til yyyy-MM-dd, for ellers tager den klokkeslæt med.
                startdato = Convert.ToDateTime(myReader["startDato"]).ToString("yyyy-MM-dd");
                slutdato = Convert.ToDateTime(myReader["slutDato"]).ToString("yyyy-MM-dd");
                resnr = myReader["resnr"].ToString();
                gade = myReader["gade"].ToString();
                postnummer = myReader["postnr"].ToString();
                by = myReader["byen"].ToString();
                levering = myReader["levering"].ToString();

                nyLinje = "Startdato: " + startdato + "\t Slutdato: " + slutdato + "\t Levering: " + levering + "\t Resnr: " + resnr + "\t Gade: " + gade + "\t Postnummer: " + postnummer + "\t By: " + by;
                //Tilføjer en string/linje til listen med alle informationerne. 
                linje.Add(nyLinje);
            }

            myReader.Close();

            conn.Close();
            return linje;

        }

        public void Opret_Ordre_Sog(long ID, out string navn, out string gade, out int postnr, out string byen)
        {
            navn = "";
            gade = "";
            postnr = 0;
            byen = "";
            try
            {
                conn = new SqlConnection(Connection());
                conn.Open();
                navn = "FEJL"; gade = "FEJL"; postnr = 0; byen = "FEJL";
                SqlCommand Opret_Ordre_Sog = new SqlCommand();
                Opret_Ordre_Sog.CommandText = $"select navn, gade, postnr, byen from DEB where cprCvr = {ID}";
                Opret_Ordre_Sog.Connection = conn;
                reader = Opret_Ordre_Sog.ExecuteReader();
                while (reader.Read())
                {
                    navn = reader["navn"].ToString();
                    gade = reader["gade"].ToString();
                    postnr = Convert.ToInt32(reader["postnr"]);
                    byen = reader["byen"].ToString();
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Der er sket en fejl i din SQL");
                //Udskriver fejltypen:
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Opret_Ordre_OO(string dato, int levering, string gade, int postnr, string by, long cprcvr, out int ordrenr)
        {
            ordrenr = 0;
            try
            {
                conn = new SqlConnection(Connection());
                conn.Open();
                SqlCommand Opret_Ordre_OO = new SqlCommand();
                Opret_Ordre_OO.CommandText = $"insert into LejeOrdre(dato, levering, gade, postnr, byen, cprCvr) values" +
                  $"('{dato}', {levering}, '{gade}', {postnr}, '{by}', {cprcvr})";
                Opret_Ordre_OO.Connection = conn;
                Opret_Ordre_OO.ExecuteNonQuery();

                SqlCommand Ordrenr = new SqlCommand();
                Ordrenr.CommandText = $"select ordrenr from LejeOrdre where cprCvr = {cprcvr}";
                Ordrenr.Connection = conn;
                reader = Ordrenr.ExecuteReader();
                while (reader.Read())
                {
                    ordrenr = Convert.ToInt32(reader["ordrenr"]);
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Der er sket en fejl i din SQL");
                //Udskriver fejltypen:
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public void Opret_Ordre_Afdeling(string afd, out string bynavn, out int postnr, out string gade)
        {
            bynavn = "FEJL"; postnr = 0; gade = "FEJL";
            try
            {
                conn = new SqlConnection(Connection());
                conn.Open();
                SqlCommand Opret_Ordre_Sog = new SqlCommand();
                Opret_Ordre_Sog.CommandText = $"select bynavn, postnr, gade from Afdelinger where bynavn = '{afd}'";
                Opret_Ordre_Sog.Connection = conn;
                reader = Opret_Ordre_Sog.ExecuteReader();
                while (reader.Read())
                {
                    gade = reader["gade"].ToString();
                    postnr = Convert.ToInt32(reader["postnr"]);
                    bynavn = reader["bynavn"].ToString();
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Der er sket en fejl i din SQL");
                //Udskriver fejltypen:
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Opret_Ordre_LejeOrdreLinjer(int ordrenr, int resnr, string resnavn, string startdato, string slutdato, int pris)
        {
            try
            {
                conn = new SqlConnection(Connection());
                conn.Open();
                SqlCommand Opret_Ordre_Dato = new SqlCommand();
                Opret_Ordre_Dato.CommandText = $"insert into LejeOrdreLinjer(ordrenr, resnr, resnavn, startDato, slutDato, pris) values" +
                $"({ordrenr}, {resnr},'{resnavn}', '{startdato}', '{slutdato}', {pris})";
                Opret_Ordre_Dato.Connection = conn;
                Opret_Ordre_Dato.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Der er sket en fejl i din SQL");
                //Udskriver fejltypen:
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
