using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20UMLQuestion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            //MessageBox.Show("This is the login form");
        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //MySqlConnection cnn = new DBConnection().getConnection();
            //cnn.Open();

            //String sql = "SELECT * FROM employee WHERE username = '" + userNameBox.Text + "' AND password = '" + passwordBox.Text + "'";

            //MySqlCommand cmd = new MySqlCommand(sql, cnn);
            //MySqlDataReader reader = cmd.ExecuteReader();
            bool tmp = true;

            if (tmp)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.WindowState = FormWindowState.Maximized;
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
