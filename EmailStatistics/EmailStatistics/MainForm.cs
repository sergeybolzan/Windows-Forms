using EmailStatistics.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
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

        public MainForm()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
        }

        private void cmiAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                tvMain.SelectedNode.Nodes.Add(new TreeNode()
                {
                    Text = addUserForm.UserInfo.Name,
                    Tag = addUserForm.UserInfo.Email
                });
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
            //    binFormat.Serialize(file, tvMain.Nodes.Cast<TreeNode>().ToList());
            //}
            using (FileStream file = new FileStream(@"Tree.bin", FileMode.Create))
            {
                IFormatter binFormat = new BinaryFormatter();
                tvMain.Serialize(file, binFormat);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //using (FileStream file = new FileStream(@"Tree.bin", FileMode.Open))
            //{
            //    BinaryFormatter binFormat = new BinaryFormatter();
            //    //tvMain = (TreeView)binFormat.Deserialize(file);
            //    var obj = (IEnumerable<TreeNode>)binFormat.Deserialize(file);
            //    if (obj == null)
            //    {
            //        obj = new TreeNode[0];
            //    }
            //    if (obj.Count() > 0)
            //    {
            //        TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
            //        tvMain.Nodes.AddRange(nodeList);
            //    }
            //}

            using (FileStream file = new FileStream(@"Tree.bin", FileMode.Open))
            {
                IFormatter binFormat = new BinaryFormatter();
                tvMain.Deserialize(file, binFormat);
            }
        }


    }
}
