using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using System;

namespace Project
{
    internal class DBConnect
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        string connectionString;

        public DBConnect()
        {
            server = "localhost";
            database = "csdatabase";
            uid = "root";
            password = "Albani@123";
            connectionString = $"Server={server};Database={database};User ID={uid};Password={password};";
            connection = new MySqlConnection(connectionString);
        }

        public void connectDB()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        public void closeConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

