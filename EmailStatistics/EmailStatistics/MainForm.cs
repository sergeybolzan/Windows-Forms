using EmailStatistics.Entities;
using EmailStatistics.Forms;
using EmailStatistics.MailSettings;
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
        private BindingList<UserEvent> userEvents;
        private ServerSettings serverSettings;

        public MainForm()
        {
            InitializeComponent();
            timer.Start();

            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;   //включаем чтобы был отчет о прогрессе
            worker.WorkerSupportsCancellation = true; // поддержка отмены
            worker.ProgressChanged += worker_ProgressChanged;
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted; //обрабочтик вызывается после выполнения работы воркером
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            #region Десериализация
            //Десериализация событий отправки писем.
            Serializing.Deserialize<BindingList<UserEvent>>(@"UserEvents.bin", ref userEvents);

            //Десериализация настроек SMTP сервера.
            Serializing.Deserialize<ServerSettings>(@"SMTPServerSettings.bin", ref serverSettings);

            //Десериализация дерева.
            TreeNode tempNode = new TreeNode();
            Serializing.Deserialize<TreeNode>(@"Tree.bin", ref tempNode);
            //Нарисованные узлы дерева в дизайнере затираем и добавляем десериализованные узлы.
            tvMain.Nodes.Clear();
            tvMain.Nodes.Add(tempNode);
            #endregion


            //Убираем отметки со всех узлов
            TreeViewLogic.UncheckAllNodes(tvMain.Nodes[0]);

            //Добавляем к узлам 3-го уровня контексное меню "Добавить".
            foreach (TreeNode node2 in tvMain.Nodes[0].Nodes)
            {
                foreach (TreeNode node3 in node2.Nodes)
                {
                    node3.ContextMenuStrip = this.contextMenuAddUser;
                }
            }

            //Раскрываем все узлы дерева.
            tvMain.ExpandAll();

            //Заполнение элементов настроек десериализованными данными.
            comboBoxServer.DataSource = serverSettings.MailServerSettings;
            comboBoxServer.DisplayMember = "Name";
            tbUserAccount.Text = serverSettings.Account;
            tbUserPassword.Text = serverSettings.Password;

            //Установка для удобства теперешнего времени.
            dateTimePicker.Value = dateTimePicker.Value.AddHours(DateTime.Now.Hour);
            dateTimePicker.Value = dateTimePicker.Value.AddMinutes(DateTime.Now.Minute);

            //Привязка таблицы к списку событий отправки писем и настройка таблицы.
            MyDataGridView.DataSource = userEvents;
            MyDataGridView.Columns["EventServerSettings"].Visible = false;
            MyDataGridView.Columns["DateTime"].HeaderText = "Время";
            MyDataGridView.Columns["Emails"].HeaderText = "Email адреса";
            MyDataGridView.Columns["MessageTheme"].HeaderText = "Тема письма";
            MyDataGridView.Columns["MessageText"].HeaderText = "Текст письма";
            MyDataGridView.Columns["FileName"].HeaderText = "Файл";
            MyDataGridView.Columns["DateTime"].DefaultCellStyle.Format = "yyyy.MM.dd HH-mm";

            //Подписка на событие таблицы для выделения строки под курсором по нажатию правой кнопки мыши.
            MyDataGridView.MouseDown += MyDataGridView_MouseDown;
        }


        #region Обработчики нажатий по таблице
        // По нажатию правой кнопки мыши по строке, строка выделяется. По нажатию на пустое место таблицы, выделение пропадает.
        private void MyDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = MyDataGridView.HitTest(e.X, e.Y);
                MyDataGridView.ClearSelection();
                if (hti.RowIndex > -1) MyDataGridView.Rows[hti.RowIndex].Selected = true;
            }
        }

        // Удаление события, соответствующего выделенной строке в таблице.
        private void cmiDeleteUserEvent_Click(object sender, EventArgs e)
        {
            int rowToDelete = MyDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (rowToDelete > -1) userEvents.RemoveAt(rowToDelete);
        }
        #endregion


        #region Сериализация
        // Сериализация узлов дерева и событий отправки писем.
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializing.Serialize(@"Tree.bin", tvMain.Nodes[0]);
            Serializing.Serialize(@"UserEvents.bin", userEvents);
        }

        // По нажатию на кнопку "Сохранить" происходит сериализация настроек SMTP сервера.
        private void btnSaveServerSMTPSettings_Click(object sender, EventArgs e)
        {
            serverSettings.Account = tbUserAccount.Text;
            serverSettings.Password = tbUserPassword.Text;
            if (comboBoxServer.SelectedItem != null)
            {
                serverSettings.MailServerSettings[comboBoxServer.SelectedIndex].Address = tbServerAddress.Text;
                int port;
                if (Int32.TryParse(tbServerPort.Text, out port)) serverSettings.MailServerSettings[comboBoxServer.SelectedIndex].Port = port;
            }

            Serializing.Serialize(@"SMTPServerSettings.bin", serverSettings);
        }
        #endregion


        #region Работа с деревом
        // По нажатию на пункт "Добавить" контекстного меню дерева открывается окно для добавления нового получателя.
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

        // Выделение узла дерева, находящегося под курсором мыши во время нажатия.
        private void tvMain_MouseDown(object sender, MouseEventArgs e)
        {
            tvMain.SelectedNode = tvMain.GetNodeAt(e.X, e.Y);
        }

        // После отметки узла дерева изменение состояния родительских и дочерних узлов. Заполнение текстбоксов в соответствии с отмеченными узлами дерева.
        private void tvMain_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown) // Если изменение состояния узла произошло в коде (а не по нажатию пользователем), то в оператор "if" не заходим.
            {
                TreeViewLogic.CheckOrUncheckParentNode(e);
                if (e.Node.Nodes.Count > 0)
                {
                    TreeViewLogic.CheckAllChildNodes(e.Node, e.Node.Checked); // Если узел отметили, то отмечаем все дочерние, и наоборот.
                }

                TreeViewLogic.selNames = null;
                TreeViewLogic.selEmails = null;
                tbNames.Text = TreeViewLogic.GetAllNames(tvMain.Nodes[0]);
                tbEmails.Text = TreeViewLogic.GetAllEmails(tvMain.Nodes[0]);
            }
        }
        #endregion


        #region Отправка письма в отдельном потоке
        /// <summary>
        /// Запуск отдельного потока и передача в поток одного события отпраки письма.
        /// </summary>
        /// <param name="userEvent"></param>
        private void StartBackgroundWorker(UserEvent userEvent)
        {
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync(userEvent);
            }
        }

        // Отмена отправки письма.
        private void btnCancelSending_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy) worker.CancelAsync();
        }

        // Изменение прогрессбара в соответствии с выполнением отдельного потока.
        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        // Результат выполнения отдельного потока.
        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                tbSendingResult.Text = "Отправка отменена пользователем";
            }
            else if (!(e.Error == null))
            {
                tbSendingResult.Text = ("Ошибка: " + e.Error.Message);
            }
            else
            {
                tbSendingResult.Text = "Отправка завершена. Письмо отправлено на " + e.Result;
            }
        }

        // Выполнение отдельного потока.
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //BackgroundWorker worker = (BackgroundWorker)sender;
            UserEvent userEvent = (UserEvent)e.Argument;
            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    worker.ReportProgress(0);
                    break;
                }
                Thread.Sleep(1000);
                worker.ReportProgress(i * 10);
                if (i == 5)
                {
                    try
                    {
                        Mail.SendMail(userEvent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            e.Result = userEvent.Emails; // передача списка емеилов в обработчик окончания выполнения отдельного потока
        }
        #endregion


        // Обработчик нажатия кнопки "Добавить в расписание". Добавление всех данных в список событий отправки писем.
        private void btnAddToSchedule_Click(object sender, EventArgs e)
        {
            DateTime dateTime = monthCalendar.SelectionRange.Start;
            dateTime = dateTime.AddHours(dateTimePicker.Value.Hour);
            dateTime = dateTime.AddMinutes(dateTimePicker.Value.Minute);
            userEvents.Add(new UserEvent(dateTime, tbTheme.Text, tbMessageText.Text, tbEmails.Text, tbFileName.Text, new EventServerSettings(new MailServerSettings(comboBoxServer.Text, tbServerAddress.Text, Int32.Parse(tbServerPort.Text), checkBoxIsEnabledSSL.Checked), tbUserAccount.Text, tbUserPassword.Text)));
            
            //Сортировка списка событий после добавления нового события
            List<UserEvent> sortedList = userEvents.OrderBy(x => x.DateTime).ToList();
            userEvents = new BindingList<UserEvent>(sortedList);
            MyDataGridView.DataSource = userEvents;
        }

        // Обработчик событий таймера с периодом 60 сек.
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            currentDateTime = new DateTime(currentDateTime.Year, currentDateTime.Month, currentDateTime.Day, currentDateTime.Hour, currentDateTime.Minute, 0);
            foreach (var userEvent in userEvents)
            {
                // если событие наступило, то запускаем отправку письма в отдельном потоке.
                if (userEvent.DateTime == currentDateTime) StartBackgroundWorker(userEvent);
            }
            // Событие со временем, меньшим текущего времени, удалится.
            for (int i = 0; i < userEvents.Count; i++)
            {
                if (userEvents[i].DateTime <= currentDateTime)
                {
                    userEvents.Remove(userEvents[i]);
                    i--;
                }
            }

            // Через минуту после отправки письма, либо отмены отправки, меняет значение элементов на дэфолтные.
            if (progressBar1.Value == 100 || tbSendingResult.Text == "Отправка отменена пользователем")
            {
                progressBar1.Value = 0;
                tbSendingResult.Text = "";
            }
        }

        // Добавляем ссылку на файл, который будет вложением к письму.
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = openFileDialog.FileName;
            }
        }

        // Очистка строки со ссылкой на вложенный файл.
        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            tbFileName.Text = "";
        }

        // Отображение настроек в соответствии с выбранным сервером SMTP.
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
