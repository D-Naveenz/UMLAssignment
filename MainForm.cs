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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAudit addAudit = new AddAudit();
            addAudit.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDelivery addDelivery = new AddDelivery();
            addDelivery.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment();
            addDepartment.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddStore addStore = new AddStore();
            addStore.Show();
            this.Hide();
        }
    }
}
