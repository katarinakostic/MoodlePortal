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
        internal static bool nadjiNastavnika(int jmbg)  //provera da li je nastavnik vec u bazi
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

        internal static bool Insert(int jmbg, string ime, string prezime, string email)
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

        internal static bool InsertLoginData(int jmbg, string username, string pass, int acc_type)
        {
            String query = String.Format("INSERT INTO login(id_naloga, username, password, account_type) values('{0}', '{1}', '{2}', '{3}')", jmbg, username, pass, acc_type);
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

        internal static string podaciONastavniku(int jmbg)
        {
            String query = String.Format("SELECT * FROM nastavnik WHERE jmbg_nastavnika = '{0}' ", jmbg);
            String podaciONastavniku = "";
            
            sqlcon = new MySqlConnection(connectionString);

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    podaciONastavniku = "Jmbg=" + rd[0].ToString() + ", " + rd[1] + " " + rd[2];
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
    }
}
