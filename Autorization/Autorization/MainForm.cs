using Autorization.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
            labelTextOfProgressBar.Text = "Идет проверка:";
            labelTextOfProgressBar.ForeColor = Color.Green;
            labelTextOfProgressBar.Visible = true;

            ModifyProgressBarColor.SetState(progressBar1, 1);
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            for (int i = 0; i < 50; i++)
            {
                progressBar1.PerformStep();
                this.Update();
                Thread.Sleep(10);
            }

            Dictionary<string, string> myDict = GetListLoginPassword();
            foreach (var item in myDict)
            {
                if (tbLogin.Text == item.Key && tbPassword.Text == item.Value)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        progressBar1.PerformStep();
                        this.Update();
                        Thread.Sleep(10);
                    }
                    MainApplicationForm maForm = new MainApplicationForm();
                    this.Visible = false;
                    maForm.ShowDialog();
                    progressBar1.Visible = false;
                    labelTextOfProgressBar.Visible = false;
                    this.Visible = true;
                    return;
                }
            }
            labelTextOfProgressBar.Text = "Проверьте введенные данные!";
            labelTextOfProgressBar.ForeColor = Color.Red;
            progressBar1.Value = 100;
            ModifyProgressBarColor.SetState(progressBar1, 2);
        }

        private Dictionary<string, string> GetListLoginPassword()
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();

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
                SqlCommand command = new SqlCommand("SELECT Name, Password FROM Users", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    myDict.Add(reader[0].ToString().Trim(), reader[1].ToString().Trim());
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
    }

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }

}
