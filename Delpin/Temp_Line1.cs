using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Delpin
{
    class Temp_Line1
    {

        public class HovedKategori
        {
            public HovedKategori(string navn)
            {
                Navn = navn;
            }
            public string Navn { get; set; }
        }
        public class Kategori
        {

            //Klassen gemmer navn og id fra hovedkategori

            public Kategori(string navn, int id)
            {
                Navn = navn;
                this.id = id;
            }

            public string Navn { get; set; }
            public int id { get; set; }
        }

        public class Res
        {
            public Res(double pris, string navn, int resnr, string startDato, string slutDato)
            {
                Navn = navn;
                Pris = pris;
                Resnr = resnr;
                StartDato = startDato;
                SlutDato = slutDato;
            }

            public string Navn { get; set; }
            public double Pris { get; set; }
            public int Resnr { get; set; }

            public string StartDato { get; set; }
            public string SlutDato { get; set; }
        }

        // Opretter forbindelse til databasen og henter kolonnen navn fra hovedkategori

        Database_Manager conn = new Database_Manager();

        public List<HovedKategori> HentHovedKategori()
        {
            List<HovedKategori> result = new List<HovedKategori>();

            string VisHovedKategoriSqlString = $"Select navn from HovedKategori ";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpinas; User Id=delpinas; Password=Lu3wumM-!cTu";
            conn.Open();

            SqlCommand comselect = new SqlCommand();
            comselect.CommandText = VisHovedKategoriSqlString;
            comselect.Connection = conn;


            SqlDataReader myReader = comselect.ExecuteReader();

            while (myReader.Read())
            {
                result.Add(new HovedKategori(myReader["navn"].ToString()));
            }

            conn.Close();
            myReader.Close();

            return result;

        }

        //Opretter forbindelse til databasen
        //og joiner de to tabeller hovedkategori og kategori

        public List<Kategori> HentKategorir(string hovedKategori)
        {
            // Liste som midlertidige gemmer kategorier 

            List<Kategori> result = new List<Kategori>();

            string VisKategoriSqlString = $"" +
                $"SELECT Kategori.navn, Kategori.id FROM Kategori " +
                $"RIGHT JOIN Hovedkategori on Hovedkategori.id = Kategori.overkategori " +
                $"WHERE hovedkategori.navn = '{hovedKategori}' ";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpinas; User Id=delpinas; Password=Lu3wumM-!cTu";
            conn.Open();

            SqlCommand comselect = new SqlCommand();
            comselect.CommandText = VisKategoriSqlString;
            comselect.Connection = conn;


            SqlDataReader myReader = comselect.ExecuteReader();

            while (myReader.Read())
            {
                result.Add(new Kategori(myReader["navn"].ToString(), Convert.ToInt32(myReader["id"])));
            }

            conn.Close();
            myReader.Close();

            return result;
        }

        public List<Res> HentRes(int kategoriId, string startdato, string slutdato)
        {
            // Liste som midlertidige gemmer resourcer

            List<Res> result = new List<Res>();

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

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql7.gear.host; Initial Catalog=delpinas; User Id=delpinas; Password=Lu3wumM-!cTu";
            conn.Open();

            SqlCommand comselect = new SqlCommand();
            comselect.CommandText = VisKategoriSqlString;
            comselect.Connection = conn;


            SqlDataReader myReader = comselect.ExecuteReader();

            while (myReader.Read())
            {
                result.Add(new Res(Convert.ToDouble(myReader["pris"]), myReader["navn"].ToString(), Convert.ToInt32(myReader["resnr"]), myReader["startDato"].ToString(), myReader["slutDato"].ToString()));
            }

            conn.Close();
            myReader.Close();

            return result;
        }
    }
}
