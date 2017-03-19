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
    public partial class RecoveryPasswordForm : Form
    {
        public RecoveryPasswordForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<string> myDict = GetListEmail();
            foreach (var item in myDict)
            {
                if (item == tbEnterEmail.Text)
                {
                    if (tbNewPassword.Text.Length < 6 || tbRepeatNewPassword.Text.Length <6)
                    {
                        MessageBox.Show("Длина пароля не может быть меньше 6 символов", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (tbNewPassword.Text != tbRepeatNewPassword.Text)
                    {
                        MessageBox.Show("Введенные пароли не совпадают", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ChangeUserPassword();
                    MessageBox.Show("Пароль успешно изменен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Такого адреса электронной почты несуществует", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<string> GetListEmail()
        {
            List<string> myDict = new List<string>();

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
                SqlCommand command = new SqlCommand("SELECT Email FROM Users", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    myDict.Add(reader[0].ToString().Trim());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return myDict;
        }

        private void ChangeUserPassword()
        {
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
                SqlCommand command = new SqlCommand(String.Format(@"UPDATE Users SET Password={0} WHERE Email='{1}'", tbNewPassword.Text, tbEnterEmail.Text), connection);
                command.ExecuteNonQuery();
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
