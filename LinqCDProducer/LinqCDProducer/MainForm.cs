using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TestMenu
{
    public partial class MainForm : Form
    {
        private ArrayOfCD data;
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            data = XmlHelper.XmlDeserialize<ArrayOfCD>("cd_catalog _1.xml");
            dataGridView1.DataSource = data.CD;

            dataGridView2.DataSource = XmlHelper.XmlDeserialize<ArrayOfPRODUCER>("cd_catalog _2.xml").PRODUCER;

            //var lstCD = ((IEnumerable<ArrayOfCDCD>)dataGridView1.DataSource).ToList(); // получаем список из таблицы

            //2.1.	Список всех артистов, который выпустили свои альбомы после распада СССР.
            //dataGridView3.DataSource = data.CD.Where(art => art.YEAR > 1991).ToList();

            //2.2.	Список стран (без повторений).
            //dataGridView3.DataSource = data.CD.GroupBy(art => art.COUNTRY).ToList();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem1.Text;
            dataGridView3.DataSource = data.CD.Where(art => art.YEAR > 1991).ToList();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem2.Text;
            dataGridView3.DataSource = data.CD.GroupBy(art => art.COUNTRY).ToList();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem3.Text;

        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem4.Text;

        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem5.Text;

        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem6.Text;

        }

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem7.Text;

        }

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem8.Text;

        }

        private void ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem9.Text;

        }

        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem10.Text;

        }
    }
}
