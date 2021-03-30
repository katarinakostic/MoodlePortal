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

        public static bool Insert(Student student, byte[] foto)
        {
            String query = String.Format("INSERT INTO studenti(br_indeksa, ime, prezime, email, fotografija, godina_upisa, godina_studija) values('{0}', '{1}','{2}', '{3}', '{4}', '{5}', '{6}')", student.Person_id, student.Ime, student.Prezime, student.Email, @foto, student.godina_upisa, student.godina_studija);
            //sqlcon = DbConnection.GetConnection();
            sqlcon = new MySqlConnection(connectionString);
            bool ok = false;
            try
            {
                sqlcon.Open();
           //     sqlcon.Parameters.Add(new MySqlParameter("@IMG", foto))
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);

                //MySqlDataReader reader = cmd.ExecuteReader();
                //cmd.Parameters.Add(new MySqlParameter("@foto", foto));
                //cmd.Parameters.Add("@foto", MySqlDbType.TinyBlob);
                //cmd.Parameters["@foto"].Value = foto;
                cmd.Parameters.Add(new MySqlParameter("@foto", foto));
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

        internal static bool UpdateStudent(long person_id, Dictionary<string, bool> update, string newName, string newSurname, string newEmail, int godinaStudija, ref Student student)
        {
            String queryName;
            String querySurname;
            String queryEmail;
            String queryYear;
            //sqlcon = DbConnection.GetConnection();
            sqlcon = new MySqlConnection(connectionString);
            bool ok = false;
            try
            {
                sqlcon.Open();
                //     sqlcon.Parameters.Add(new MySqlParameter("@IMG", foto))
                if(update["ime"])
                {
                    queryName = String.Format("UPDATE studenti SET ime='{0}' WHERE br_indeksa='{1}'", newName, person_id);
                    MySqlCommand cmd = new MySqlCommand(queryName, sqlcon);
                    student.Ime = newName;
                    cmd.ExecuteNonQuery();

                }
                if(update["prezime"])
                {
                    querySurname = String.Format("UPDATE studenti SET prezime='{0}' WHERE br_indeksa='{1}'", newSurname, person_id);
                    MySqlCommand cmd = new MySqlCommand(querySurname, sqlcon);
                    student.Prezime = newSurname;
                    cmd.ExecuteNonQuery();
                }
                if (update["email"])
                {
                    queryEmail = String.Format("UPDATE studenti SET email='{0}' WHERE br_indeksa='{1}'", newEmail, person_id);
                    MySqlCommand cmd = new MySqlCommand(queryEmail, sqlcon);
                    student.Email = newEmail;
                    cmd.ExecuteNonQuery();
                }
                if (update["godinaStudija"])
                {
                    queryYear = String.Format("UPDATE studenti SET godina_studija='{0}' WHERE br_indeksa='{1}'", godinaStudija, person_id);
                    MySqlCommand cmd = new MySqlCommand(queryYear, sqlcon);
                    cmd.ExecuteNonQuery();
                }


                //sqlcon.Close();
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
    

        internal static List<Student> SpisakStudenata()
        {
            String query = "SELECT * FROM studenti";
            List<Student> studenti = new List<Student>();

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
                    long br_indeksa = (long)rd["br_indeksa"];
                    String ime = rd["ime"].ToString();
                    String prezime = rd["prezime"].ToString();
                    String email = rd["email"].ToString();
                    int godina_upisa = (int)rd["godina_upisa"];
                    int godina_studija = (int)rd["godina_studija"];
                    // byte[] foto=null;

                    // if (!Convert.IsDBNull(rd["fotografija"]))
                    //  {
                    byte[] foto = (byte[])rd["fotografija"];
                    //}


                    Student s = new Student(br_indeksa, ime, prezime, email, foto, godina_upisa, godina_studija);
                    studenti.Add(s);
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

        internal static Student podaciOStudentu(int br_indeksa)
        {
            String query = String.Format("SELECT * FROM studenti WHERE br_indeksa = '{0}' ", br_indeksa);
            Student podaciOStudentu = null;
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
                    //podaciOStudentu = "Broj indeksa=" + rd[0].ToString() + ", " + rd[1] + " " + rd[2];
                    podaciOStudentu = new Student(Int64.Parse(rd[0].ToString()), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), (byte[])rd["fotografija"], (int)rd["godina_upisa"], (int)rd["godina_studija"]);
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

        internal static byte[] NadjiSliku(long person_id)
        {
            String query = String.Format("SELECT fotografija FROM studenti WHERE br_indeksa = '{0}' ", person_id);
            byte[] img = null;
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
                    img = (byte[])rd[0];
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
            return img;
        }
    }
}
