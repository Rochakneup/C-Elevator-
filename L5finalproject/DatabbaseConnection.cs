using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace L5finalproject
{
    internal class DatabbaseConnection
    {
        string url = "datasource=localhost; Database=elevatordata ; port=3306; User=root; Password=root";
        MySqlConnection conn = null;

        private void connect()
        {
           
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
                conn.Close();
                MessageBox.Show("Connect with database server successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
