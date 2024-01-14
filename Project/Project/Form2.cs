using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            Fullscreen();
            Load += Form2_Load;
        }
        public void Fullscreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            SetActivePanel(dashboard1);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            dashboardbtn.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void manageusersbtn_MouseHover(object sender, EventArgs e)
        {
            manageusersbtn.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void stockbtn_MouseHover(object sender, EventArgs e)
        {
            stockbtn.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void financebtn_MouseHover(object sender, EventArgs e)
        {
            financebtn.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            SetActivePanel(dashboard1);
        }

        public void SetActivePanel(UserControl control)
        {
            dashboard1.Visible = false;
            manageUsers1.Visible = false;
            stock1.Visible = false;
            finance1.Visible = false;

            control.Visible = true;

        }

        private void manageusersbtn_Click(object sender, EventArgs e)
        {
            SetActivePanel(manageUsers1);
        }

        private void stockbtn_Click(object sender, EventArgs e)
        {
            SetActivePanel(stock1);
        }

        private void financebtn_Click(object sender, EventArgs e)
        {
            SetActivePanel(finance1);
        }
    }
}
