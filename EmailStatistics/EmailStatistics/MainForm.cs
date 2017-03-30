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
        private string selNames = null;
        private string selEmails = null;
        private List<UserEvent> userEvents;

        public MainForm()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            userEvents = new List<UserEvent>();
            timer.Start();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            //using (FileStream file = new FileStream(@"Tree.bin", FileMode.Open))
            //{
            //    tvMain.Nodes.Clear();
            //    BinaryFormatter binFormat = new BinaryFormatter();
            //    tvMain.Nodes.Add((TreeNode)binFormat.Deserialize(file));

            //    UncheckAllNodes(tvMain.Nodes[0]);

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
                TreeNode parent = e.Node.Parent;
                while (parent != null) // Выполняем цикл, пока не дойдем до корневого узла
                {
                    if (e.Node.Checked) // Если узел отметили, и все соседние узлы также отмечены, то отмечаем и родителя
                    {
                        bool state = true;
                        foreach (TreeNode item in parent.Nodes)
                        {
                            if (!item.Checked) state = false;
                        }
                        if (state == true) parent.Checked = true;
                    }
                    else // А если отметку с узла сняли, то и с родителя также снимаем отметку
                    {
                        parent.Checked = false;
                    }
                    parent = parent.Parent; // Для выполнения цикла, пока не дойдем до корневого узла
                }
                if (e.Node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(e.Node, e.Node.Checked); // Если узел отметили, то отмечаем все дочерние, и наоборот.
                }

                selNames = null;
                selEmails = null;
                tbNames.Text = GetAllNames(tvMain.Nodes[0]);
                tbEmails.Text = GetAllEmails(tvMain.Nodes[0]);
            }
        }

        private string GetAllNames(TreeNode selTN)
        {
            for (int i = 0; i < selTN.Nodes.Count; i++)
            {
                GetAllNames(selTN.Nodes[i]);
                if (selTN.Nodes[i].Level >= 3 && selTN.Nodes[i].Checked)
                {
                    selNames += selTN.Nodes[i].Text + "; ";
                }
            }
            return selNames;
        }

        private string GetAllEmails(TreeNode selTN)
        {
            for (int i = 0; i < selTN.Nodes.Count; i++)
            {
                GetAllEmails(selTN.Nodes[i]);
                if (selTN.Nodes[i].Level >= 3 && selTN.Nodes[i].Checked)
                {
                    selEmails += selTN.Nodes[i].Tag + "; ";
                }
            }
            return selEmails;
        }
        /// <summary>
        /// Рекурсивный метод установки всех дочерних узлов узла treeNode в состояние nodeChecked
        /// </summary>
        /// <param name="treeNode">Узел, состояние дочерних узлов которого необходимо изменить</param>
        /// <param name="nodeChecked">Состояние, в которое будут изменяться дочерние узлы</param>
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }
        /// <summary>
        /// Снимает все отметки с узла treeNode и с его дочерних узлов
        /// </summary>
        /// <param name="treeNode"></param>
        private void UncheckAllNodes(TreeNode treeNode)
        {
            treeNode.Checked = false;
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = false;
                if (node.Nodes.Count > 0)
                {
                    this.UncheckAllNodes(node);
                }
            }
        }

        private void btnAddToSchedule_Click(object sender, EventArgs e)
        {
            DateTime DT = monthCalendar.SelectionRange.Start;
            DT = DT.AddHours(dateTimePicker.Value.Hour);
            DT = DT.AddMinutes(dateTimePicker.Value.Minute);
            userEvents.Add(new UserEvent(DT, tbMessageText.Text, tbTheme.Text));
            //добавить файл
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            DT = new DateTime(DT.Year, DT.Month, DT.Day, DT.Hour, DT.Minute, 0);
            foreach (var item in userEvents)
            {
                if (item.DateTime == DT) return; // Отправляем сообщения, поставить таймер 60000
            }
        }
    }
}
