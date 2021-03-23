using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MoodlePortal
{
    class DbConnection
    {
        static DbConnection connection = null;
        MySqlConnection sqlcon = null;


        private DbConnection()
        {
            this.sqlcon = new MySqlConnection("datasource=localhost; username=root; password=; database=moodleDb");
            try
             {
                 sqlcon.Open();
                 //connLbl.Text = "Connection generated succesfully";

             }
             catch (Exception e)
             {

                 //connLbl.Text = "Connection Error";
             }
        }

        public static MySqlConnection GetConnection()
        {
            if (connection == null)
                connection = new DbConnection();

            return connection.sqlcon;
        }

    }
}