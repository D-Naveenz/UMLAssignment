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

namespace _20UMLQuestion
{
    public partial class AddAudit : Form
    {
        public AddAudit()
        {
            InitializeComponent();
        }

        private void addAuditBtn_Click(object sender, EventArgs e)
        {

            String sql = "INSERT INTO audit (audit_id, date, description, store_id) VALUES ('" + auditIDBox.Text + "', '" + dateBox.Text + "', '" + descriptionBox.Text + "', '" + storeIDBox.Text + "')";

            try
            {
                //open connection
                MySqlConnection cnn = new DBConnection().getConnection();
                cnn.Open();

                //create mysql command
                MySqlCommand cmd = new MySqlCommand(sql, cnn);

                //Execute query
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Audit Added");
                }
                else
                {
                    MessageBox.Show("Audit Not Added");
                }

                //close connection
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void modifyAuditBtn_Click(object sender, EventArgs e)
        {
            String sql = "UPDATE audit SET date = '" + dateBox.Text + "', description = '" + descriptionBox.Text + "', store_id = '" + storeIDBox.Text + "' WHERE audit_id = '" + auditIDBox.Text + "'";

            try
            {
                //open connection
                MySqlConnection cnn = new DBConnection().getConnection();
                cnn.Open();

                //create mysql command
                MySqlCommand cmd = new MySqlCommand(sql, cnn);

                //Execute query
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Audit Modified");
                }
                else
                {
                    MessageBox.Show("Audit Not Modified");
                }

                //close connection
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteAuditBtn_Click(object sender, EventArgs e)
        {
            String sql = "DELETE FROM audit WHERE audit_id = '" + auditIDBox.Text + "'";

            try
            {
                //open connection
                MySqlConnection cnn = new DBConnection().getConnection();
                cnn.Open();

                //create mysql command
                MySqlCommand cmd = new MySqlCommand(sql, cnn);

                //Execute query
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Audit Deleted");
                }
                else
                {
                    MessageBox.Show("Audit Not Deleted");
                }

                //close connection
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
