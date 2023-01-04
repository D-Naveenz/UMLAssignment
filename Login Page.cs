using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20UMLQuestion
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // show loginForm 
            LoginForm loginForm = new LoginForm();
            // maximize loginForm
            loginForm.WindowState = FormWindowState.Maximized;
            loginForm.Show();
            // hide loginPage
            this.Hide();

        }




    }
}
