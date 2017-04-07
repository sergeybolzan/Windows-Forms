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

            //userEvents = new BindingList<UserEvent>();

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
            using (FileStream file = new FileStream(@"Tree.bin", FileMode.Open))
            {
                //Нарисованное узлы дерева в дизайнере затираем и добавляем десериализованные узлы.
                tvMain.Nodes.Clear();
                BinaryFormatter binFormat = new BinaryFormatter();
                tvMain.Nodes.Add((TreeNode)binFormat.Deserialize(file));

                //Убираем отметки со всех узлов
                Logic.UncheckAllNodes(tvMain.Nodes[0]);

                //Добавляем к узлам 3-го уровня контексное меню "Добавить".
                foreach (TreeNode node2 in tvMain.Nodes[0].Nodes)
                {
                    foreach (TreeNode node3 in node2.Nodes)
                    {
                        node3.ContextMenuStrip = this.contextMenuAddUser;
                    }
                }
            }
            //Раскрываем все узлы дерева.
            tvMain.ExpandAll();

            //Десериализация событий отправки писем.
            using (FileStream file = new FileStream(@"UserEvents.bin", FileMode.Open))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                userEvents = (BindingList<UserEvent>)binFormat.Deserialize(file);
            }

            //Десериализация настроек SMTP сервера.
            using (FileStream file = new FileStream(@"SMTPServerSettings.bin", FileMode.Open))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                serverSettings = (ServerSettings)binFormat.Deserialize(file);
            }

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

        /// <summary>
        /// По нажатию правой кнопки мыши по строке, строка выделяется. По нажатию на пустое место таблицы, выделение пропадает.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = MyDataGridView.HitTest(e.X, e.Y);
                MyDataGridView.ClearSelection();
                if (hti.RowIndex > -1) MyDataGridView.Rows[hti.RowIndex].Selected = true;
            }
        }

        /// <summary>
        /// Удаление события, соответствующего выделенной строке в таблице.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiDeleteUserEvent_Click(object sender, EventArgs e)
        {
            int rowToDelete = MyDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (rowToDelete > -1) userEvents.RemoveAt(rowToDelete);
        }

        /// <summary>
        /// Сериализация настроек SMTP сервера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            using (FileStream file = new FileStream(@"SMTPServerSettings.bin", FileMode.Create))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(file, serverSettings);
            }
        }

        /// <summary>
        /// По нажатию на пункт "Добавить" контекстного меню дерева открывается окно для добавления нового получателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Выделение узла дерева, находящегося под курсором мыши во время нажатия.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvMain_MouseDown(object sender, MouseEventArgs e)
        {
            tvMain.SelectedNode = tvMain.GetNodeAt(e.X, e.Y);
        }

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

        /// <summary>
        /// Отмена отправки письма.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelSending_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy) worker.CancelAsync();
        }

        /// <summary>
        /// Изменение прогрессбара в соответствии с выполнением отдельного потока.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// Результат выполнения отдельного потока.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Выполнение отдельного потока.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //BackgroundWorker worker = (BackgroundWorker)sender;
            UserEvent userEvent = (UserEvent)e.Argument;
            for (int i = 1; i <= 10; i++)
            {
                if(worker.CancellationPending)
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

        /// <summary>
        /// Сериализация узлов дерева и событий отправки писем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream file = new FileStream(@"Tree.bin", FileMode.Create))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(file, tvMain.Nodes[0]);
            }

            using (FileStream file = new FileStream(@"UserEvents.bin", FileMode.Create))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(file, userEvents);
            }
        }

        /// <summary>
        /// После отметки узла дерева изменение состояния родительских и дочерних узлов. Заполнение текстбоксов в соответствии с отмеченными узлами дерева.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить в расписание". Добавление всех данных в список событий отправки писем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Обработчик событий таймера с периодом 60 сек.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Добавляем ссылку на файл, который будет вложением к письму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Очистка строки со ссылкой на вложенный файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            tbFileName.Text = "";
        }

        /// <summary>
        /// Отображение настроек в соответствии с выбранным сервером SMTP.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
