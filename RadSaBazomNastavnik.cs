using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using System.Data.SqlClient;
using System.Data;

namespace MoodlePortal
{
    class RadSaBazomNastavnik : RadSaBazom
    {
        internal static bool nadjiNastavnika(long jmbg)  //provera da li je nastavnik vec u bazi
        {
            String query = String.Format("SELECT * FROM nastavnik WHERE jmbg_nastavnika='{0}'", jmbg);
            sqlcon = new MySqlConnection(connectionString);
            bool exists = false;

            MySqlDataReader reader;
            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    exists = true; //ako ne vratimo ovde true onda nije dobro
                reader.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
            }
            finally
            {
                sqlcon.Close();
            }

            return exists;
        }

        internal static bool Insert(long jmbg, string ime, string prezime, string email)
        {
            String query = String.Format("INSERT INTO nastavnik(jmbg_nastavnika, ime, prezime, email) values('{0}', '{1}','{2}', '{3}')", jmbg, ime, prezime, email);
            //sqlcon = DbConnection.GetConnection();
            sqlcon = new MySqlConnection(connectionString);
            bool ok = false;
            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                cmd.ExecuteNonQuery();

                ok = true;

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
            }
            finally
            {
                sqlcon.Close();
            }
            return ok;
        }


        internal static List<Nastavnik> SpisakNastavnika()
        {
            String query = "SELECT * FROM nastavnik";
            List<Nastavnik> nastavnici = new List<Nastavnik>();

            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    long jmbg = (long)rd["jmbg_nastavnika"];
                    String ime = rd["ime"].ToString();
                    String prezime = rd["prezime"].ToString();
                    String email = rd["email"].ToString();
                    String podaciONastavniku = "Jmbg=" + rd[0].ToString() + ", " + rd[1] + " " + rd[2];
                    
                    Nastavnik n = new Nastavnik(jmbg, ime, prezime, email);
                    nastavnici.Add(n);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
            }
            finally
            {
                sqlcon.Close();
            }

            return nastavnici;
        }

        internal static Nastavnik podaciONastavniku(long jmbg)
        {
            String query = String.Format("SELECT * FROM nastavnik WHERE jmbg_nastavnika = '{0}' ", jmbg);
            Nastavnik podaciONastavniku = null;
            
            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    //podaciONastavniku = "Jmbg=" + rd[0].ToString() + ", " + rd[1] + " " + rd[2];
                    podaciONastavniku = new Nastavnik(Int64.Parse(rd[0].ToString()), rd[1].ToString(), rd[2].ToString(), rd[3].ToString());
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
            }
            finally
            {
                sqlcon.Close();
            }
            return podaciONastavniku;
        }
        internal static void sacuvajFotografiju(byte[] img, long jmbg)
        {
            //UPDATE studenti SET ime="kaca" WHERE br_indeksa=639
            String query = String.Format("UPDATE studenti SET fotografija='{0}' WHERE jmbg_nastavnika='{1}'", img, jmbg);

            //sqlcon = DbConnection.GetConnection();
            sqlcon = new MySqlConnection(connectionString);
            //sqlcon = con;

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Query Executed: " + query);
                Console.WriteLine();
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
