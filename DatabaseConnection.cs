using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCRUD
{
    public class DatabaseConnection
    {
        private MySqlConnection connection;

        public DatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ConnectionString;
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {

                    connection.Open();
                }
                return connection; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
             
        }
    }
}
