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
    class RadSaBazomKursevi : RadSaBazom
    {
        internal static List<Kurs> SpisakKurseva()
        {
            String query = "SELECT * FROM kursevi";
            List<Kurs> kursevi = new List<Kurs>();

            //sqlcon = DbConnection.GetConnection();
            sqlcon = new MySqlConnection(connectionString);
            //sqlcon = con;

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                //MySqlDataReader rd = cmd.ExecuteReader();
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    String sifra = rd["sifra_kursa"].ToString();
                    String naziv = rd["naziv_kursa"].ToString();
                    int godina_studija = int.Parse(rd["godina_studija"].ToString());
                    byte izborni = byte.Parse(rd["izborni"].ToString());
                    String pr_kod = rd["pristupni_kod"].ToString();

                    Kurs k = new Kurs(sifra, naziv, godina_studija, izborni, pr_kod);
                    kursevi.Add(k);
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

            return kursevi;
        }

        internal static bool nadjiKurs(string sifra)
        {
            String query = String.Format("SELECT * FROM kursevi WHERE sifra_kursa='{0}'", sifra);
            sqlcon = new MySqlConnection(connectionString);
            bool exists = false;

            //sqlcon = DbConnection.GetConnection();
            //sqlcon = con;

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

        internal static bool AddKurs(Kurs kurs)
        {
            String query = String.Format("INSERT INTO `kursevi` (`sifra_kursa`, `naziv_kursa`, `godina_studija`, `izborni`, `pristupni_kod`) VALUES('{0}', '{1}','{2}', '{3}', '{4}')", kurs.Sifra_kursa, kurs.Naziv, kurs.Godina, kurs.Izborni, kurs.Pristupni_kod);
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

        internal static bool Update(Dictionary<string, bool> update, string newName, int godinaStudija, byte izborni, string newCode, ref Kurs kurs)
        {
            //`sifra_kursa`, `naziv_kursa`, `godina_studija`, `izborni`, `pristupni_kod`
            String queryName, queryYear, queryIzborni, queryKod;
            sqlcon = new MySqlConnection(connectionString);
            bool ok = false;
            try
            {
                sqlcon.Open();
                //     sqlcon.Parameters.Add(new MySqlParameter("@IMG", foto))
                if (update["naziv_kursa"])
                {
                    queryName = String.Format("UPDATE kursevi SET naziv_kursa='{0}' WHERE sifra_kursa='{1}'", newName, kurs.Sifra_kursa);
                    MySqlCommand cmd = new MySqlCommand(queryName, sqlcon);
                    kurs.Naziv = newName;
                    cmd.ExecuteNonQuery();

                }
                if (update["godina_studija"])
                {
                    queryYear = String.Format("UPDATE kursevi SET godina_studija='{0}' WHERE sifra_kursa='{1}'", godinaStudija, kurs.Sifra_kursa);
                    MySqlCommand cmd = new MySqlCommand(queryYear, sqlcon);
                    kurs.Godina = godinaStudija;
                    cmd.ExecuteNonQuery();
                }
                if (update["izborni"])
                {
                    queryIzborni = String.Format("UPDATE kursevi SET izborni='{0}' WHERE sifra_kursa='{1}'", izborni, kurs.Sifra_kursa);
                    MySqlCommand cmd = new MySqlCommand(queryIzborni, sqlcon);
                    kurs.Izborni = izborni;
                    cmd.ExecuteNonQuery();
                }
                if (update["pristupni_kod"])
                {
                    queryKod = String.Format("UPDATE kursevi SET pristupni_kod='{0}' WHERE sifra_kursa='{1}'", newCode, kurs.Sifra_kursa);
                    MySqlCommand cmd = new MySqlCommand(queryKod, sqlcon);
                    kurs.Pristupni_kod = newCode;
                    cmd.ExecuteNonQuery();
                }
                ok = true;
                //reader.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Inner Exception: " + ex.Message);
                Console.WriteLine();
                //Console.WriteLine("Query Executed: " + queryName);
                //Console.WriteLine();
            }
            finally
            {
                sqlcon.Close();
            }
            return ok;
        }

        internal static bool Obrisi(string sifra)
        {
            String query = String.Format("DELETE FROM kursevi WHERE sifra_kursa='{0}'", sifra);
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
    }
}
