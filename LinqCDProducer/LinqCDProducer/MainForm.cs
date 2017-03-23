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
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            var data = XmlHelper.XmlDeserialize<ArrayOfCD>("cd_catalog _1.xml");
            dataGridView1.DataSource = data.CD;

            dataGridView2.DataSource = XmlHelper.XmlDeserialize<ArrayOfPRODUCER>("cd_catalog _2.xml").PRODUCER;

            //var lstCD = ((IEnumerable<ArrayOfCDCD>)dataGridView1.DataSource).ToList(); // получаем список из таблицы

            //2.1.	Список всех артистов, который выпустили свои альбомы после распада СССР.
            //dataGridView3.DataSource = data.CD.Where(art => art.YEAR > 1991).ToList();

            //2.2.	Список стран (без повторений).
            dataGridView3.DataSource = data.CD.GroupBy(art => art.COUNTRY).ToList();
        }

        private void miPrint_Click(object sender, EventArgs e)
        {
           
        }
    }
}
