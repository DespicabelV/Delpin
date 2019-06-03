using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        //Katrine:
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
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Der er sket en fejl i din SQL\n" +
                    ex.Message + "\n" + com.CommandText);
            }
            finally
            {
                conn.Close();
            }
        }

        public DEB HentDEB(long cprCvr)
        {
            DEB deb = new DEB();
            try
            {
                conn = new SqlConnection(Connection());
                string SelectSqlString = $"Select * from DEB where cprCvr = {cprCvr}";
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
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Der er sket en fejl i din SQL\n" +
                    ex.Message + "\n" + com.CommandText);
            }
            finally
            {
                conn.Close();
            }
            return deb;
        }

        //Bruges ikke, da det ikke er muligt at slette en DEB i øjeblikket. 
        //public void SletDEB(long cprCvr)
        //{
        //    try
        //    {
        //        string DeleteSqlString = $"Delete from LejeOrdreLinjer where cprCvr" +
        //            $"Delete from DEB where cprCvr = {cprCvr}";
        //        Console.WriteLine(DeleteSqlString);
        //        conn = new SqlConnection(Connection());
        //        conn.Open();
        //        SqlCommand com = new SqlCommand(DeleteSqlString, conn);
        //        com.ExecuteNonQuery();
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show("Der er sket en fejl i din SQL\n" +
        //            ex.Message + "\n" + com.CommandText);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //}
 
        public void UpdateDEB(DEB deb)
        {
            try
            {
                string UpdateSqlString = $"Update DEB set cprCvr = '{deb.CprCvr}', " +
                    $"navn = '{deb.Navn}', gade = '{deb.Gade}', postnr = {deb.Postnr}, byen = '{deb.By}', tlf = {deb.Tlf}," +
                    $" email = '{deb.Email}', ansvarlig = '{deb.Ansvarlig}' where cprCvr = {deb.CprCvr}";
                Console.WriteLine(UpdateSqlString);
                conn = new SqlConnection(Connection());
                conn.Open();
                SqlCommand com = new SqlCommand(UpdateSqlString, conn);
                com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Der er sket en fejl i din SQL\n" +
                    ex.Message + "\n" + com.CommandText);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<string> HentLejeListe(string start, string slut)
        {
            //Henter lejelisten og printer den ud til en textfil. 
            List<string> linje = new List<string>();
            try
            {
                string slutdato, startdato, resnr, gade, postnummer, by, nyLinje, levering;

                string SelectSqlString = $"select LOL.resnr, LOL.startDato, LOL.slutDato, LO.gade, LO.postnr, LO.levering, LO.byen from LejeOrdreLinjer LOL " +
                    $"join LejeOrdre LO on LOL.ordrenr = LO.ordrenr " +
                    $"where startDato >= '{start}' AND startDato <= '{slut}' " +
                    $"OR slutDato <= '{slut}' AND slutDato > '{start}' " +
                    $"Order by startDato ";
                conn = new SqlConnection(Connection());
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

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Der er sket en fejl i din SQL\n" +
                    ex.Message + "\n" + com.CommandText);
            }
            finally
            {
                conn.Close();
            }
            return linje;
        }

        //Viggo:
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
                MessageBox.Show("Der er sket en fejl i din SQL\n" +
                    ex.Message + "\n" + com.CommandText);
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
                MessageBox.Show("Der er sket en fejl i din SQL\n" +
                    ex.Message + "\n" + com.CommandText);
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
                MessageBox.Show("Der er sket en fejl i din SQL\n" +
                    ex.Message + "\n" + com.CommandText);
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
                MessageBox.Show("Der er sket en fejl i din SQL\n" +
                    ex.Message + "\n" + com.CommandText);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Sog_Ordre_Hent_Dato (int ID, out string start, out string slut)
        {
            start = ""; slut = "";
            try
            {
                conn = new SqlConnection(Connection());
                conn.Open();
                SqlCommand Sog_Ordre_Hent_Dato = new SqlCommand();
                Sog_Ordre_Hent_Dato.CommandText = $"select startDato, slutDato from LejeOrdreLinjer where ID = {ID}";
                Sog_Ordre_Hent_Dato.Connection = conn;
                reader = Sog_Ordre_Hent_Dato.ExecuteReader();
                while (reader.Read())
                {
                    start = reader["startDato"].ToString();
                    slut = reader["slutDato"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Der er sket en fejl i din SQL\n" +
                    ex.Message + "\n" + com.CommandText);
            }
            finally
            {
                conn.Close();
            }
        }

        //Line:
        public List<HovedKategori> HentHovedKategori()
        {
            List<HovedKategori> result = new List<HovedKategori>();

            try
            {
                string VisHovedKategoriSqlString = $"Select navn from HovedKategori ";

                conn = new SqlConnection(Connection());
                conn.Open();

                SqlCommand comselect = new SqlCommand();
                comselect.CommandText = VisHovedKategoriSqlString;
                comselect.Connection = conn;


                SqlDataReader myReader = comselect.ExecuteReader();

                while (myReader.Read())
                {
                    result.Add(new HovedKategori(myReader["navn"].ToString()));
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Der er sket en fejl i din SQL\n" +
                    ex.Message + "\n" + com.CommandText);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public List<Kategori> HentKategorir(string hovedKategori)
        {
            // Liste som midlertidige gemmer kategorier 

            List<Kategori> result = new List<Kategori>();

            try
            {
                string VisKategoriSqlString = $"" +
                $"SELECT Kategori.navn, Kategori.id FROM Kategori " +
                $"RIGHT JOIN Hovedkategori on Hovedkategori.id = Kategori.overkategori " +
                $"WHERE hovedkategori.navn = '{hovedKategori}' ";

                conn = new SqlConnection(Connection());
                conn.Open();

                SqlCommand comselect = new SqlCommand();
                comselect.CommandText = VisKategoriSqlString;
                comselect.Connection = conn;


                SqlDataReader myReader = comselect.ExecuteReader();

                while (myReader.Read())
                {
                    result.Add(new Kategori(myReader["navn"].ToString(), Convert.ToInt32(myReader["id"])));
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Der er sket en fejl i din SQL\n" +
                    ex.Message + "\n" + com.CommandText);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public List<Res> HentRes(int kategoriId, string startdato, string slutdato)
        {
            // Liste som midlertidige gemmer resourcer

            List<Res> result = new List<Res>();

            try
            {
                string VisKategoriSqlString = $"" +
                                $"SELECT Res.resnr, Res.navn, Res.pris, LejeOrdreLinjer.startDato, LejeOrdreLinjer.slutDato " +
                                $"FROM Res " +
                                $"left join LejeOrdreLinjer ON Res.resnr = LejeOrdreLinjer.resnr " +
                                $" WHERE Res.resnr NOT IN " +
                                $"(SELECT resnr FROM LejeOrdreLinjer LOL " +
                                $"WHERE(startDato <= '{startdato}' AND slutDato >= '{startdato}') " +
                                $"OR(startDato < '{slutdato}' AND slutDato >= '{slutdato}') " +
                                $"OR('{startdato}' <= startDato AND '{slutdato}' >= startDato)) " +
                                $"and Res.kategori =  {kategoriId} " +
                                $"Order by startDato, slutDato";

                conn = new SqlConnection(Connection());
                conn.Open();

                SqlCommand comselect = new SqlCommand();
                comselect.CommandText = VisKategoriSqlString;
                comselect.Connection = conn;


                SqlDataReader myReader = comselect.ExecuteReader();

                while (myReader.Read())
                {
                    result.Add(new Res(Convert.ToDouble(myReader["pris"]), myReader["navn"].ToString(), Convert.ToInt32(myReader["resnr"]), myReader["startDato"].ToString(), myReader["slutDato"].ToString()));
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Der er sket en fejl i din SQL\n" +
                    ex.Message + "\n" + com.CommandText);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
