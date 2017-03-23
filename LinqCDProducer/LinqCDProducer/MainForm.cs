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

namespace LinqCDProducer
{
    public partial class MainForm : Form
    {
        private ArrayOfCD dataCD;
        private ArrayOfPRODUCER dataProducer;
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            dataCD = XmlHelper.XmlDeserialize<ArrayOfCD>("cd_catalog _1.xml");
            dataGridView1.DataSource = dataCD.CD;

            dataProducer = XmlHelper.XmlDeserialize<ArrayOfPRODUCER>("cd_catalog _2.xml");
            dataGridView2.DataSource = dataProducer.PRODUCER;

            //var lstCD = ((IEnumerable<ArrayOfCDCD>)dataGridView1.DataSource).ToList(); // получаем список из таблицы
        }

        // Список всех артистов, который выпустили свои альбомы после распада СССР
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem1.Text;
            dataGridView3.DataSource = dataCD.CD.Where(art => art.YEAR > 1991).Select(art => new { art.ARTIST, art.YEAR }).ToList();
        }
        // Список стран (без повторений)
        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem2.Text;
            dataGridView3.DataSource = dataCD.CD.GroupBy(gr => gr.COUNTRY).Select(gr => new { COUNTRY = gr.Key }).ToList();
        }
        // Список наименований альбомов, выпущенных в США, упорядоченных по году выпуска
        private void ToolStripMenuItem3_Click(object sender, EventArgs e) 
        {
            label1.Text = ToolStripMenuItem3.Text;
            dataGridView3.DataSource = dataCD.CD.Where(t => t.COUNTRY == "USA").OrderBy(t => t.YEAR).Select(t => new { t.TITLE, t.YEAR }).ToList();
        }
        // Суммарная стоимость альбомов за страну
        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem4.Text;
            dataGridView3.DataSource = dataCD.CD.GroupBy(gr => gr.COUNTRY).Select(gr => new { COUNTRY = gr.Key, SUMPRICE = gr.Sum(s => s.PRICE) }).ToList();
        }
        // Список: компания и количество альбомов за год, года упорядочены по возрастанию
        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem5.Text;
            dataGridView3.DataSource = dataCD.CD.OrderBy(o => o.YEAR).GroupBy(gr => new { gr.COMPANY, gr.YEAR }).Select(gr => new { COMPANY = gr.Key.COMPANY, ALBUMCOUNT = gr.Count(), YEAR = gr.Key.YEAR }).ToList();
        }
        // Наименование альбомов и имя продюсера, получившего самое большое вознаграждение за вклад в развитие
        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem6.Text;
            var maxFEE = dataProducer.PRODUCER.Select(p => p.FEE).Max();
            dataGridView3.DataSource = dataCD.CD.Join(dataProducer.PRODUCER, c => c.PRODUCER, p => p.ID, (c, p) => new { cd = c, producer = p }).Where(w => w.producer.FEE == maxFEE).Select(j => new { j.cd.TITLE, j.producer.NAME, j.producer.FEE }).ToList();
        }
        // Количество альбомов каждого продюсера в период  между годами выхода альбома 1988 – 1990 гг.
        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem7.Text;
            dataGridView3.DataSource = dataCD.CD.Join(dataProducer.PRODUCER, c => c.PRODUCER, p => p.ID, (c, p) => new { cd = c, producer = p }).Where(w => w.cd.YEAR >= 1988 & w.cd.YEAR <= 1990).GroupBy(gr => gr.producer.NAME).Select(gr => new { NAME = gr.Key, ALBUMCOUNT = gr.Count() }).ToList();
        }
        // Фамилия продюсера получившего вознаграждение последним
        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem8.Text;
            var maxDate = dataProducer.PRODUCER.Select(p => p.DATE).Max();
            dataGridView3.DataSource = dataProducer.PRODUCER.Where(p => p.DATE == maxDate).Select(p => new { SECONDNAME = p.NAME.Split(' ')[1] }).ToList();
        }
        // Информация о самом дешевом альбоме (название альбома, исполнителя и продюсера)
        private void ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem9.Text;
            var minPrice = dataCD.CD.Select(c => c.PRICE).Min();
            dataGridView3.DataSource = dataCD.CD.Join(dataProducer.PRODUCER, c => c.PRODUCER, p => p.ID, (c, p) => new { cd = c, producer = p }).Where(w => w.cd.PRICE == minPrice).Select(s => new { s.cd.TITLE, s.cd.ARTIST, PRODUCER = s.producer.NAME }).ToList();
        }
        // Полная информация об альбомах, отсортированная по следующим критериям: год выхода альбома, стоимость  альбома, наименование альбома
        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            label1.Text = ToolStripMenuItem10.Text;
            dataGridView3.DataSource = dataCD.CD.Join(dataProducer.PRODUCER, c => c.PRODUCER, p => p.ID, (c, p) => new { cd = c, producer = p }).OrderBy(c => c.cd.YEAR).ThenBy(c => c.cd.PRICE).ThenBy(c => c.cd.TITLE).Select(s => new { s.cd.TITLE, s.cd.ARTIST, s.cd.COUNTRY, s.cd.COMPANY, s.cd.PRICE, s.cd.YEAR, PRODUCER = s.producer.NAME }).ToList();
        }
    }
}
