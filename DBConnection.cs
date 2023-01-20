using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace InventoryManagementsSystem
{
    class DBConnection
    {
        private string connection;
        public bool isConnected;

        public bool connector(string server, string username, string password, string database, string command)
        {
            MySql.Data.MySqlClient.MySqlConnection connectDB;

            isConnected = true;
            connection = $"server={server};uid={username};pwd={password};database={database}";
           
            try
            {
                connectDB = new MySql.Data.MySqlClient.MySqlConnection();
                connectDB.ConnectionString = connection;
                connectDB.Open();
                isConnected = true;
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            return isConnected;
        }
    }
}
