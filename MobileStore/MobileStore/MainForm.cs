using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStore
{
    public partial class MainForm : Form
    {
        BindingList<Phone> phones;
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            //phones = new BindingList<Phone>()
            //{
            //    new Phone("Apple", "IOS", 2.2, 700),
            //    new Phone("Samsung", "Android", 2.5, 650),
            //    new Phone("Huawei", "Android", 2.0, 600),
            //    new Phone("Xiaomi", "Android", 2.5, 400)
            //};

        }

        private void listBoxPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxPhones.SelectedItem != null)
            {
                Phone selPhone = (Phone)listBoxPhones.SelectedItem;
                tbModel.Text = selPhone.Model;
                tbOS.Text = selPhone.OperatingSystem;
                tbProcessor.Text = selPhone.Processor.ToString();
                tbPrice.Text = selPhone.Price.ToString();
            }
        }

        private void btnDeletePhone_Click(object sender, EventArgs e)
        {
            if (listBoxPhones.SelectedItem != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы точно хотите удалить элемент?", "Удалить элемент?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Phone selPhone = (Phone)listBoxPhones.SelectedItem;
                    phones.Remove(selPhone);
                    listBoxPhones.DataSource = phones;
                }
            }
            else MessageBox.Show("Нечего удалять", "Список пуст", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            if (listBoxPhones.SelectedItem != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы точно хотите очистить список?", "Очистить список?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    listBoxPhones.DataSource = null;
                }
            }
            else MessageBox.Show("Нечего очищать", "Список пуст", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Загрузить список из файла?", "Загрузить список?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                using (FileStream file = new FileStream(@"PhonesList.bin", FileMode.Open))
                {
                    BinaryFormatter binFormat = new BinaryFormatter();
                    phones = (BindingList<Phone>)binFormat.Deserialize(file);
                }
                listBoxPhones.DataSource = phones;
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Сохранить список в файл?", "Сохранить список?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {

                using (FileStream file = new FileStream(@"PhonesList.bin", FileMode.Create))
                {
                    BinaryFormatter binFormat = new BinaryFormatter();
                    binFormat.Serialize(file, phones);
                }
            }
        }
    }
}
