using FormCRUD.Models;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCRUD
{
    public class UserRepository
    {
        private DatabaseConnection dbConnection;

        public UserRepository()
        {
            dbConnection = new DatabaseConnection();
        }

        public void AddUser(Users user)
        {
            var connection = dbConnection.GetConnection();
            
            string query = "INSERT INTO users(name,email) VALUES (@Name, @Email)";

            using(var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", user.name);
                command.Parameters.AddWithValue("@Email", user.email);
                command.ExecuteNonQuery();
            }
        }
    }
}
