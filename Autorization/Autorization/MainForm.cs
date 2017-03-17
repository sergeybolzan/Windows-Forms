using Autorization.Entities;
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
        //    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        //    builder.DataSource = @"(LocalDB)\v11.0";
        //    builder.AttachDBFilename = Environment.CurrentDirectory + @"\registration.mdf";
        //    builder.IntegratedSecurity = true;
        //    builder.ConnectTimeout = 5;

        //    SqlConnection connection = new SqlConnection();
        //    connection.ConnectionString = builder.ConnectionString;
        //    try
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand("SELECT * FROM Users", connection);
        //        SqlDataReader reader = command.ExecuteReader();
        //        string temp = null;
        //        while (reader.Read())
        //        {
        //            for (int i = 0; i < reader.FieldCount; i++)
        //            {
        //                temp += reader[i] + " ";
        //            }
        //            temp += "\n";
        //        }
        //        reader.Close();
        //        MessageBox.Show(temp);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoveryPasswordForm rpForm = new RecoveryPasswordForm();
            this.Visible = false;
            rpForm.ShowDialog();
            this.Visible = true;

        }

        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationNewUserForm rnuForm = new RegistrationNewUserForm();
            this.Visible = false;
            rnuForm.ShowDialog();
            this.Visible = true;

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            MainApplicationForm maForm = new MainApplicationForm();
            this.Visible = false;
            maForm.ShowDialog();
            this.Visible = true;

        }

    }
}
