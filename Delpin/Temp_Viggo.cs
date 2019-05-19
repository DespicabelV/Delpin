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
        SqlConnection db;
        SqlDataReader reader;

        //Åbner en forbindelse
        public SqlConnection OpenDB()
        {
            // Opretter en forindelse "db" som kender til databasen det hjælp af den connection string der er givet
            db = new SqlConnection("Data Source=den1.mssql7.gear.host; Initial Catalog=delpinas; User Id=delpinas; Password=Lu3wumM-!cTu");
            db.Open();
            return db;
        }

        //Lukker alle forbindelser der er blevet åbnet
        public void CloseDB()
        {
            db.Close();
        }

        public void Opret_Ordre_Sog(long ID, out string navn, out string gade, out int postnr, out string byen)
        {
            OpenDB();
            navn = "FEJL"; gade = "FEJL"; postnr = 0; byen = "FEJL";
            SqlCommand Opret_Ordre_Sog = new SqlCommand();
            Opret_Ordre_Sog.CommandText  = $"select navn, gade, postnr, byen from DEB where cprCvr = {ID}";
            Opret_Ordre_Sog.Connection = db;
            reader = Opret_Ordre_Sog.ExecuteReader();
            while (reader.Read())
            {
                navn = reader["navn"].ToString();
                gade = reader["gade"].ToString();
                postnr = Convert.ToInt32(reader["postnr"]);
                byen = reader["byen"].ToString();
            }
            CloseDB();
        }

        public string Opret_Ordre_OO(string dato, int levering, string gade, int postnr, string by, string res, long cprcvr)
        {
            string test;
            //OpenDB();
            //SqlCommand Opret_Ordre_OO = new SqlCommand();
            //Opret_Ordre_OO.CommandText = $"insert into LejeOrdre(dato, levering, gade, postnr, byen, res, cprCvr) values" +
            //    $"('{dato}', {levering}, '{gade}', {postnr}, '{by}', '{res}', {cprcvr})";
            //Opret_Ordre_OO.ExecuteNonQuery();
            //CloseDB();
            test = $"insert into LejeOrdre(dato, levering, gade, postnr, byen, res, cprCvr) values" +
                $"('{dato}', {levering}, '{gade}', {postnr}, '{by}', '{res}', {cprcvr})";
            return test;
        }


    }
}
