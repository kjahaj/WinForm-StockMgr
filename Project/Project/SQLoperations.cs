using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace Project
{
    internal class SQLoperations
    {
        string query;
        List<String> names;


        public SQLoperations()
        {
            names = new List<String>();
        }

        public List<String> totalUsers(MySqlConnection connection)
        {

            query = "SELECT name FROM user";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                names.Add(reader["name"].ToString());
            }
            reader.Close();
            return names;
        }

    }
}

