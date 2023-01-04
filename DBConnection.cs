using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20UMLQuestion
{
    internal class DBConnection
    {
        // create and return db connection for sql quairies
        public MySqlConnection getConnection()
        {
            SqlConnection cnn;
            string server = "localhost";
            string database = "umlassignment";
            string user = "root";
            string password = "";

            string connectionString = "Server=" + server + ";Database=" + database + ";Uid=" + user + ";Password=" + password + ";";
            
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
