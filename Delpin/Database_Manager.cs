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
    }
}
