using EmailStatistics.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("En"); //Ru-ru
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("En"); //Ru-ru
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


    }
}
