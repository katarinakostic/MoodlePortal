using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MoodlePortal
{
    class RadSaBazom
    {
        public static MySqlConnection sqlcon;
        public static String connectionString = "datasource=localhost; username=root; password=; database=moodleDb";
        public static bool nadjiStudenta(int br_indeksa)
        {

            String query = String.Format("SELECT * FROM studenti WHERE br_indeksa='{0}'", br_indeksa);
            sqlcon = new MySqlConnection(connectionString);

            //sqlcon = DbConnection.GetConnection();
            //sqlcon = con;
            try
           {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    sqlcon.Close();
                    return false;
                }
                else
                {
                    sqlcon.Close();
                    return true; //ako ne vratimo ovde true onda nije dobro
                }
            }
            catch (Exception exc)
            {

            }
            finally
            {
                sqlcon.Close();
            }

            return false;
        }

        public static bool Insert(int br_indeksa, string ime, string prezime, string email)
        {
            String query = String.Format("INSERT INTO studenti(br_indeksa, ime, prezime, email) values('{0}', '{1}','{2}', '{3}')", br_indeksa, ime, prezime, email);
            //sqlcon = DbConnection.GetConnection();
            sqlcon = new MySqlConnection(connectionString);
            bool ok = false;
            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();
                //sqlcon.Close();
                ok=true;

            }
            catch (Exception exc)
            {
                
            }
            finally
            {
                sqlcon.Close();
            }
            return ok;
        }

        public static bool Obrisi(int br_indeksa)
        {
            String query = String.Format("DELETE FROM studenti WHERE br_indeksa='{0}'", br_indeksa);
            //sqlcon = DbConnection.GetConnection();
            sqlcon = new MySqlConnection(connectionString);
            bool ok=false;

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                cmd.ExecuteNonQuery();
                ok = true;

            }
            catch (Exception exc)
            {

            }
            finally
            {
                sqlcon.Close();
            }
            return ok;

        }

        internal static Dictionary<int, String> SpisakStudenata()
        {
            String query = "SELECT * FROM studenti";
            Dictionary<int, String> studenti = new Dictionary<int, String>();

            //sqlcon = DbConnection.GetConnection();
            sqlcon = new MySqlConnection(connectionString);
            //sqlcon = con;
                try
              {
                    sqlcon.Open();
            MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                String podaciOStudentu = "Broj indeksa=" + rd[0].ToString() + ", " + rd[1] + " " + rd[2];
                studenti.Add(int.Parse(rd[0].ToString()), podaciOStudentu);
                //int i = 33;
                    // studenti.Add(int.Parse(rd[0].ToString()), "m");
            }

                //sqlcon.Close();
                //return studenti;
            }
            catch (Exception exc)
            {
            }
            finally
            {
                sqlcon.Close();
            }

           return studenti;
        }
        internal static String podaciOStudentu(int br_indeksa)
        {
            String query = String.Format("SELECT * FROM studenti WHERE br_indeksa = '{0}' ", br_indeksa);
            String podaciOStudentu = "";
            //sqlcon = DbConnection.GetConnection();
            sqlcon = new MySqlConnection(connectionString);
            //sqlcon = con;
            //    try
            //   {
            //        sqlcon.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                //if (sqlcon.Close())
                //    sqlcon.Open();
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    podaciOStudentu = "Broj indeksa=" + rd[0].ToString() + ", " + rd[1] + " " + rd[2];

                    //int i = 33;
                    // studenti.Add(int.Parse(rd[0].ToString()), "m");
                }

                
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                sqlcon.Close();
            }
            return podaciOStudentu;
            //      }
            //      catch (Exception exc)
            //      {

            //     }

            // return studenti;
        }
    }
}
