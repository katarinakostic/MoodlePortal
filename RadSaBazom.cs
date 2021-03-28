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
    class RadSaBazom
    {
        protected static MySqlConnection sqlcon;
        protected static String connectionString = "datasource=localhost; username=root; password=; database=db_moodle;";

        internal static bool InsertPerson(long personid)
        {
            String query = String.Format("INSERT INTO person(personid) values('{0}')", personid);
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
                ok = true;
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

        internal static bool Obrisi(long personid)
        {
            String query = String.Format("DELETE FROM person WHERE personid='{0}'", personid);
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
