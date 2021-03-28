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
    class RadSaBazomStudent : RadSaBazom
    {
        //public static MySqlConnection sqlcon;
        //public static String connectionString = "datasource=localhost; username=root; password=; database=moodleDb;";
        public static bool nadjiStudenta(int br_indeksa)
        {

            String query = String.Format("SELECT * FROM studenti WHERE br_indeksa='{0}'", br_indeksa);
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

                //MySqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();
                //sqlcon.Close();
                ok=true;
                //reader.Close();

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

                //MySqlDataReader rd = cmd.ExecuteReader();
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                String podaciOStudentu = "Broj indeksa=" + rd[0].ToString() + ", " + rd[1] + " " + rd[2];
                studenti.Add(int.Parse(rd[0].ToString()), podaciOStudentu);
                //int i = 33;
                    // studenti.Add(int.Parse(rd[0].ToString()), "m");
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
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                //if (sqlcon.Close())
                //    sqlcon.Open();
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    podaciOStudentu = "Broj indeksa=" + rd[0].ToString() + ", " + rd[1] + " " + rd[2];
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
            return podaciOStudentu;
        }

        internal static void sacuvajFotografiju(byte[] img, int br_indeksa)
        {
            //UPDATE studenti SET ime="kaca" WHERE br_indeksa=639
            String query = String.Format("UPDATE studenti SET fotografija='{0}' WHERE br_indeksa='{1}'", img, br_indeksa);

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

        //vraca tip naloga da bismo znali na koju stranu da preusmerimo nakon uspesnog logovanja
        //1-za admina, 2-za studenta, 3-za nastavnika
     /*   internal static int GetAccountType(String username)
        {
            //SELECT account_type FROM `login` WHERE username="admin"
            String query = String.Format("SELECT account_type FROM `login` WHERE username='{0}'", username);
            sqlcon = new MySqlConnection(connectionString);
            int acc_type=-1; //ako vrati -1 nije lepo izvrsena provera

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                    acc_type = int.Parse(rd[0].ToString());

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
            return acc_type;
        } */
        
     /*   internal static String getSalt(String username)
        {
            String salt = "";

            String query = String.Format("SELECT password FROM `login` WHERE username='{0}'", username);
            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    String pass = rd[0].ToString();
                    int len = pass.Length;
                    salt = pass.Substring(0, 8) + pass.Substring(len - 8, 8);
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

            return salt;

        } */
    }
}
