using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Delpin
{
    class Temp_Viggo
    {
        SqlConnection conn;
        SqlDataReader reader;

        //Åbner en forbindelse
        private string Connection()
        {
            return "Data Source=den1.mssql7.gear.host; Initial Catalog=delpinas; User Id=delpinas; Password=Lu3wumM-!cTu";
        }

        

        public void Opret_Ordre_Sog(long ID, out string navn, out string gade, out int postnr, out string byen)
        {
            navn   = "";
            gade   = "";
            postnr = 0;
            byen   = "";
            try
            {
                conn = new SqlConnection(Connection());
                conn.Open();
                navn = "FEJL"; gade = "FEJL"; postnr = 0; byen = "FEJL";
                SqlCommand Opret_Ordre_Sog = new SqlCommand();
                Opret_Ordre_Sog.CommandText  = $"select navn, gade, postnr, byen from DEB where cprCvr = {ID}";
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

        public List<LejeList> Sog_Ordre_Sog(int ID)
        {
            string navn, start, slut;
            int resnr;
            double pris;
            List<LejeList> list = new List<LejeList>();

            try
            {
                conn = new SqlConnection(Connection());
                conn.Open();
                SqlCommand Opret_Ordre_Sog = new SqlCommand();
                Opret_Ordre_Sog.CommandText = $"select resnr, resnavn, startDato, slutDato, pris from LejeOrdreLinjer where ordrenr = {ID}";
                Opret_Ordre_Sog.Connection = conn;
                reader = Opret_Ordre_Sog.ExecuteReader();


                while (reader.Read())
                {
                    resnr = Convert.ToInt32(reader["resnr"]);
                    navn  = reader["resnavn"].ToString();
                    pris  = Convert.ToInt32(reader["pris"]);
                    start = reader["startDato"].ToString();
                    slut  = reader["slutDato"].ToString();
                    LejeList l = new LejeList(resnr, navn, pris, start, slut);
                    list.Add(l);
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
            return list;
        }
    }

}
