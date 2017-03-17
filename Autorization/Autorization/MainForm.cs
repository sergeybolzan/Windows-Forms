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

namespace Autorization
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                SqlConnectionStringBuilder conString = new SqlConnectionStringBuilder();
                conString.DataSource = @"(LocalDB)\v11.0";
                conString.AttachDBFilename = Environment.CurrentDirectory + @"\registration.mdf";
                conString.IntegratedSecurity = true;
                connection.ConnectionString = conString.ConnectionString;
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Users", connection);
                SqlDataReader reader = command.ExecuteReader();
                string temp = null;
                while (reader.Read() != false)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        temp += reader[i] + " ";
                    }
                    temp += "\n";
                }
                reader.Close();
                MessageBox.Show(temp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
