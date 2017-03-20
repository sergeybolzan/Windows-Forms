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

namespace Autorization.Entities
{
    public partial class RegistrationNewUserForm : Form
    {
        public RegistrationNewUserForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "" || tbPassword.Text == "" || tbRepeatPassword.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("Заполните поля, отмеченные звездочкой!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbPassword.Text.Length < 6 || tbRepeatPassword.Text.Length < 6)
            {
                MessageBox.Show("Длина пароля не может быть меньше 6 символов", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbPassword.Text != tbRepeatPassword.Text)
            {
                MessageBox.Show("Введенные пароли не совпадают", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (FindName(tbLogin.Text)) MessageBox.Show("halo");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool FindName(string name)
        {
            bool result = false;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(LocalDB)\v11.0";
            builder.AttachDBFilename = Environment.CurrentDirectory + @"\registration.mdf";
            builder.IntegratedSecurity = true;
            builder.ConnectTimeout = 5;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = builder.ConnectionString;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"FindName", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Name";
                param.SqlDbType = SqlDbType.NChar;
                param.Size = 20;
                param.Value = name;
                command.Parameters.Add(param);

                // Выходной параметр.
                param = new SqlParameter();
                param.ParameterName = "@Result";
                param.SqlDbType = SqlDbType.Bit;
                param.Direction = ParameterDirection.Output;
                command.Parameters.Add(param);

                command.ExecuteNonQuery();
                result = (bool)command.Parameters["@Result"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}
