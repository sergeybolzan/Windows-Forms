using EmailStatistics.Entities;
using EmailStatistics.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailStatistics
{
    public partial class MainForm : Form
    {
        private BackgroundWorker worker;
        private List<UserEvent> userEvents;
        private ServerSettings serverSettings;

        public MainForm()
        {
            InitializeComponent();
            timer.Start();
            worker = new BackgroundWorker();
            userEvents = new List<UserEvent>();

            //serverSettings = new ServerSettings()
            //{
            //    MailServerSettings = new BindingList<MailServerSettings>()
            //    {
            //    new MailServerSettings(){ Name = "MAIL.RU", Address = "smtp.mail.ru", Port = 2525, IsEnabledSSL = true },
            //    new MailServerSettings(){ Name = "Gmail", Address = "smtp.gmail.com", Port = 58, IsEnabledSSL = true },
            //    new MailServerSettings(){ Name = "YANDEX", Address = "smtp.yandex.ru", Port = 25, IsEnabledSSL = true }
            //    },
            //    Account = "ivanitstep@mail.ru",
            //    Password = "ivan123456789"
            //};

            //comboBoxServer.DataSource = serverSettings.MailServerSettings;
            //comboBoxServer.DisplayMember = "Name";

            //tbUserAccount.Text = serverSettings.Account;
            //tbUserPassword.Text = serverSettings.Password;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //using (FileStream file = new FileStream(@"Tree.bin", FileMode.Open))
            //{
            //    tvMain.Nodes.Clear();
            //    BinaryFormatter binFormat = new BinaryFormatter();
            //    tvMain.Nodes.Add((TreeNode)binFormat.Deserialize(file));

            //    Logic.UncheckAllNodes(tvMain.Nodes[0]);

            //    //Добавляем к узлам 3-го уровня контексное меню
            //    foreach (TreeNode node2 in tvMain.Nodes[0].Nodes)
            //    {
            //        foreach (TreeNode node3 in node2.Nodes)
            //        {
            //            node3.ContextMenuStrip = this.contextMenuAddUser;
            //        }
            //    }
            //}
            tvMain.ExpandAll();

            using (FileStream file = new FileStream(@"SMTPServerSettings.bin", FileMode.Open))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                serverSettings = (ServerSettings)binFormat.Deserialize(file);
            }
            comboBoxServer.DataSource = serverSettings.MailServerSettings;
            comboBoxServer.DisplayMember = "Name";
            tbUserAccount.Text = serverSettings.Account;
            tbUserPassword.Text = serverSettings.Password;
        }
        private void btnSaveServerSMTPSettings_Click(object sender, EventArgs e)
        {
            serverSettings.Account = tbUserAccount.Text;
            serverSettings.Password = tbUserPassword.Text;
            using (FileStream file = new FileStream(@"SMTPServerSettings.bin", FileMode.Create))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(file, serverSettings);
            }
        }

        private void cmiAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                tvMain.SelectedNode.Nodes.Add(new TreeNode()
                {
                    Text = addUserForm.UserInfo.Name,
                    Tag = addUserForm.UserInfo.Email,
                });
                tvMain.SelectedNode.Expand();
            }
        }

        private void tvMain_MouseDown(object sender, MouseEventArgs e)
        {
            tvMain.SelectedNode = tvMain.GetNodeAt(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker.WorkerReportsProgress = true;   //включаем чтобы был отчет о прогрессе
            worker.WorkerSupportsCancellation = true; // поддержка отмены
            worker.ProgressChanged += worker_ProgressChanged;
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted; //обрабочтик вызывается после выполнения работы воркером
            worker.RunWorkerAsync(10);
            // if(worker.IsBusy)
        }
        private void button2_Click(object sender, EventArgs e)
        {
            worker.CancelAsync();
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //label1.Text = e.ProgressPercentage.ToString() + "%";
            progressBar1.Value = e.ProgressPercentage;
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                label1.Text = "задача отменна пользователем";
            }
            else
            {
                label1.Text = "задача выполнена: результат " + e.Result;
            }
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            int count = (int)e.Argument;
            // 5 сек
            for (int i = 1; i <= count; i++)
            {
                if(worker.CancellationPending)
                {
                    e.Cancel = true;
                    worker.ReportProgress(0);
                    break;
                }
                Thread.Sleep(1000);
                worker.ReportProgress(i * 10);
            }
            e.Result = 500;  // надо возвратить коллекцию адресов
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //using (FileStream file = new FileStream(@"Tree.bin", FileMode.Create))
            //{
            //    BinaryFormatter binFormat = new BinaryFormatter();
            //    binFormat.Serialize(file, tvMain.Nodes[0]);
            //}

        }


        private void tvMain_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown) // Если изменение состояния узла произошло в коде (а не по нажатию пользователем), то в оператор "if" не заходим.
            {
                Logic.CheckOrUncheckParentNode(e);
                if (e.Node.Nodes.Count > 0)
                {
                    Logic.CheckAllChildNodes(e.Node, e.Node.Checked); // Если узел отметили, то отмечаем все дочерние, и наоборот.
                }

                Logic.selNames = null;
                Logic.selEmails = null;
                tbNames.Text = Logic.GetAllNames(tvMain.Nodes[0]);
                tbEmails.Text = Logic.GetAllEmails(tvMain.Nodes[0]);
            }
        }

        private void btnAddToSchedule_Click(object sender, EventArgs e)
        {
            DateTime dateTime = monthCalendar.SelectionRange.Start;
            dateTime = dateTime.AddHours(dateTimePicker.Value.Hour);
            dateTime = dateTime.AddMinutes(dateTimePicker.Value.Minute);
            userEvents.Add(new UserEvent(dateTime, tbTheme.Text, tbMessageText.Text, tbEmails.Text, tbFileName.Text, new EventServerSettings(new MailServerSettings(comboBoxServer.Text, tbServerAddress.Text, Int32.Parse(tbServerPort.Text), checkBoxIsEnabledSSL.Checked), tbUserAccount.Text, tbUserPassword.Text)));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime = new DateTime(currentDateTime.Year, currentDateTime.Month, currentDateTime.Day, currentDateTime.Hour, currentDateTime.Minute, 0);
            foreach (var userEvent in userEvents)
            {
                if (userEvent.DateTime == currentDateTime)
                    try
                    {
                        Logic.SendMail(userEvent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = openFileDialog.FileName;
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            tbFileName.Text = "";
        }

        private void comboBoxServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxServer.SelectedItem != null)
            {
                MailServerSettings selItem = (MailServerSettings)comboBoxServer.SelectedItem;
                tbServerAddress.Text = selItem.Address;
                tbServerPort.Text = selItem.Port.ToString();
                checkBoxIsEnabledSSL.Checked = selItem.IsEnabledSSL;
            }
        }

    }
}
