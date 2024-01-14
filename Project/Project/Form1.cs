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
    public partial class Form1 : Form
    {
        DBConnect conn;
        LogIn login;

        public Form1()
        {
            InitializeComponent();
            emailValidityLabel.Hide();
            Fullscreen();
            conn = new DBConnect();
            conn.connectDB();
            dbStatus();
            conn.closeConnection();
        }

        public void Fullscreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }


        public void dbStatus()
        {
            if (conn.connection.State == ConnectionState.Closed)
            {
                statusDB.Text = "NOT CONNECTED";
                statusDB.ForeColor = Color.Red;
            }
            else
            {
                statusDB.Text = "CONNECTED";
                statusDB.ForeColor = Color.Green;
               
            }
        }

        public void validate()
        {
            
            login = new LogIn();
            if (login.checkUsername() == false)
            {
                emailValidityLabel.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validate();
            validate_id();
        }

        private void validate_id () 
        {
            int userType = login.id_type;
           
            switch (userType)
            {
                case 1:
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                    break;
                case 2:
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Closed += (s, args) => this.Close();
                    form3.Show();
                    break;
                default:
                    break;
            }

        }
    }
}
