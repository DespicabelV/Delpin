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
    }
}
