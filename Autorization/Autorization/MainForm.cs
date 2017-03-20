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
            tbLogin.GotFocus += tbLogin_GotFocus;
            tbLogin.LostFocus += tbLogin_LostFocus;
            tbPassword.GotFocus += tbPassword_GotFocus;
            tbPassword.LostFocus += tbPassword_LostFocus;
        }
        /// <summary>
        /// При фокусе на элементе tbLogin дефолтное значение стирается
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbLogin_GotFocus(object sender, EventArgs e)
        {
            if (tbLogin.Text == "Имя пользователя")
            {
                tbLogin.ForeColor = Color.Black;
                tbLogin.Text = "";
            }
        }
        /// <summary>
        /// При потере фокуса элементом tbLogin, если ничего не введено, в нем отображается дефолтное значение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbLogin_LostFocus(object sender, EventArgs e)
        {
            if (tbLogin.Text == "")
            {
                tbLogin.ForeColor = Color.DarkGray;
                tbLogin.Text = "Имя пользователя";
            }
        }
        /// <summary>
        /// При фокусе на элементе tbPassword дефолтное значение стирается
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPassword_GotFocus(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Пароль")
            {
                tbPassword.ForeColor = Color.Black;
                tbPassword.Text = "";
                tbPassword.PasswordChar = '*';
            }
        }
        /// <summary>
        /// При потере фокуса элементом tbPassword, если ничего не введено, в нем отображается дефолтное значение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPassword_LostFocus(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.ForeColor = Color.DarkGray;
                tbPassword.Text = "Пароль";
                tbPassword.PasswordChar = '\0';
            }
        }
        /// <summary>
        /// Действие по нажатию на кнопку "Войти". Появляется текст "идет проверка" и прогрессбар, который заполняется на половину.
        /// Если введенные данные имеются в базе, прогрессбар полностью заполняется и происходит вход в главное окно (вызывается перегруженный метод ShowDialog, в который передается фамилия и имя).
        /// Если введенных данных нету в базе, прогрессбар меняет цвет и полностью заполняется, текст меняется и меняет цвет. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    this.Visible = false;
                    MainApplicationForm maForm = new MainApplicationForm();
                    maForm.ShowDialog(GetDataOnLogin(tbLogin.Text));

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
        /// <summary>
        /// По нажатию на линк "Забыли пароль?", родительское окно становится невидимым и открывается окно для восстановления пароля.
        /// После закрытия окна для восстановления пароля родительское окно становится видимым
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoveryPasswordForm rpForm = new RecoveryPasswordForm();
            this.Visible = false;
            rpForm.ShowDialog();
            progressBar1.Visible = false;
            labelTextOfProgressBar.Visible = false;
            this.Visible = true;
        }
        /// <summary>
        /// По нажатию на линк "Регистрация", родительское окно становится невидимым и открывается окно для регистрации.
        /// После закрытия окна для регистрации родительское окно становится видимым
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationNewUserForm rnuForm = new RegistrationNewUserForm();
            this.Visible = false;
            rnuForm.ShowDialog();
            progressBar1.Visible = false;
            labelTextOfProgressBar.Visible = false;
            this.Visible = true;
        }
        /// <summary>
        /// Метод для копирования значений "Логин - пароль" из базы данных в словарь
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Метод для получения из базы данных фамилии и имени по логину.
        /// </summary>
        /// <param name="Login"></param>
        /// <returns></returns>
        private string GetDataOnLogin(string Login)
        {
            string Data = null;
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
                SqlCommand command = new SqlCommand(String.Format("SELECT LastName, FirstName FROM Users JOIN UsersInfo ON Id=UserId WHERE Name='{0}'", Login), connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Data = reader[0].ToString().Trim() + " " + reader[1].ToString().Trim();
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
            return Data;
        }

    }
    /// <summary>
    /// Класс для изменения цвета прогрессбара
    /// </summary>
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        /// <summary>
        /// Метод для изменения цвета прогрессбара
        /// </summary>
        /// <param name="pBar"></param>
        /// <param name="state">1 - зеленый цвет, 2 - красный, 3 - желтый</param>
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }

}
