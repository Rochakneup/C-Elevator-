using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5finalproject
{
    internal class DatabaseCommands
    {
        public void InsertData(DateTime log_date, string Action_log)
        {
            string connectionString = "datasource=localhost; Database=elevatordata ; port=3306; User=root; Password=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Your SQL query to insert the record
                string query = "INSERT INTO action_log ( log_date, Actions_log) VALUES (@log_date, @Action_log)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@log_date", log_date);
                    cmd.Parameters.AddWithValue("@Action_log", Action_log); // Use @actionLog as the parameter name
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void deleteRecords()
        {
            string connectionString = "datasource=localhost; Database=elevatordata; port=3306; User=root; Password=root";
            string query = "DELETE  FROM action_log ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {


                    connection.Open();
                    int rowsDeleted = command.ExecuteNonQuery();

                    if (rowsDeleted > 0)
                    {
                        MessageBox.Show(rowsDeleted + " record(s) deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No records were deleted.");
                    }
                }
            }
        }







    }
}
