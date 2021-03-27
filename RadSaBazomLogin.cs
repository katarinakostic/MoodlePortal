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
    class RadSaBazomLogin : RadSaBazom
    {
        internal static String getSalt(String username)
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

        }

        //proveri da li postoji nalog sa unetim username-om
        internal static bool findUser(string username)
        {
            String query = String.Format("SELECT EXISTS( select * from login where username='{0}')", username);
            sqlcon = new MySqlConnection(connectionString);
            bool exists = false;

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                    if (int.Parse(reader[0].ToString()) > 0)
                        exists = true;

                //n = int.Parse(reader[0].ToString());
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

        internal static int GetAccountType(String username)
        {
            //SELECT account_type FROM `login` WHERE username="admin"
            String query = String.Format("SELECT account_type FROM `login` WHERE username='{0}'", username);
            sqlcon = new MySqlConnection(connectionString);
            int acc_type = -1; //ako vrati -1 nije lepo izvrsena provera

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
        }
        internal static bool checkUser(String username, String pass)
        {
            //SELECT EXISTS( select * from login where username='admin' )
            //exists vraca 0 ako ne postoji i 1 ako postoji!
            String query = String.Format("SELECT EXISTS( select * from login where username='{0}' AND password='{1}')", username, pass);
            sqlcon = new MySqlConnection(connectionString);
            //int n = 0;
            bool exists = false;

            try
            {
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                    if (int.Parse(reader[0].ToString()) > 0)
                        exists = true;

                //n = int.Parse(reader[0].ToString());
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
    }
}
