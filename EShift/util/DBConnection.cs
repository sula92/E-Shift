using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift
{
    //Singleton class for Database Connection
    public class DBConnection
    {
        private static DBConnection dbConnnection;
        private MySqlConnection connection;
        
        private DBConnection()
        {
            try
            {
                //Connection string
                connection = new MySqlConnection("DataSource ='localhost'; Database='eshift'; User ID='root'; Password='';");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static DBConnection getInstance()
        {
            return (dbConnnection == null) ? dbConnnection = new DBConnection() : dbConnnection;
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

    }
}
