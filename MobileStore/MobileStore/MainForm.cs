﻿using System;
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
        BindingList<string> options;
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            //phones = new BindingList<Phone>()
            //{
            //    new Phone("Apple", "IOS", 2.2, 700, "Apple.jpg", new BindingList<string>(){"WiFi", "GPS", "3D-Touch"}),
            //    new Phone("Samsung", "Android", 2.5, 650, "Samsung.jpg", new BindingList<string>(){"WiFi", "GPS", "NFC"}),
            //    new Phone("Huawei", "Android", 2.0, 600, "Huawei.jpg", new BindingList<string>(){"WiFi", "GPS"}),
            //    new Phone("Xiaomi", "Android", 2.5, 400, "Xiaomi.jpg", new BindingList<string>())
            //};
            //listBoxPhones.DataSource = phones;

            //options = new BindingList<string>() { "WiFi", "GPS", "3D-Touch", "NFC", "LTE", "Bluetooth", "QuickCharge", "FM" };
            


            using (FileStream file = new FileStream(@"OptionList.bin", FileMode.Open))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                options = (BindingList<string>)binFormat.Deserialize(file);
            }
            checkedListBoxOptions.DataSource = options;

            using (FileStream file = new FileStream(@"PhonesList.bin", FileMode.Open))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                phones = (BindingList<Phone>)binFormat.Deserialize(file);
            }
            listBoxPhones.DataSource = phones;

        }

        private void listBoxPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxPhones.SelectedItem != null)
            {
                Phone selPhone = (Phone)listBoxPhones.SelectedItem;
                pictureBox1.ImageLocation = selPhone.PathToImage;
                tbModel1.Text = selPhone.Model;
                tbModel2.Text = selPhone.Model;
                tbOS1.Text = selPhone.OperatingSystem;
                tbOS2.Text = selPhone.OperatingSystem;
                tbProcessor1.Text = selPhone.Processor.ToString();
                tbProcessor2.Text = selPhone.Processor.ToString();
                tbPrice1.Text = selPhone.Price.ToString();
                tbPrice2.Text = selPhone.Price.ToString();
                tbPicture.Text = selPhone.PathToImage;
                listBoxOptions.DataSource = selPhone.Options;
                for (int i = 0; i < options.Count; i++)
                {
                    checkedListBoxOptions.SetItemChecked(i, false);
                    for (int j = 0; j < selPhone.Options.Count; j++)
                    {
                        if (options[i] == selPhone.Options[j]) checkedListBoxOptions.SetItemChecked(i, true);
                    }
                }
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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (listBoxPhones.SelectedItem != null)
            {
                Phone selPhone = (Phone)listBoxPhones.SelectedItem;
                selPhone.Model = tbModel2.Text;
                selPhone.OperatingSystem = tbOS2.Text;
                double a;
                if (Double.TryParse(tbProcessor2.Text, out a)) selPhone.Processor = a;
                if (Double.TryParse(tbPrice2.Text, out a)) selPhone.Price = a;
                selPhone.PathToImage = tbPicture.Text;
                selPhone.Options.Clear();
                for (int i = 0; i < checkedListBoxOptions.CheckedItems.Count; i++)
                {
                    selPhone.Options.Add(checkedListBoxOptions.CheckedItems[i].ToString());
                }
                listBoxPhones.DataSource = null;
                listBoxPhones.DataSource = phones;
            }
        }

        private void btnAddOption_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbOptionName.Text) && !checkedListBoxOptions.Items.Contains(tbOptionName.Text))
            {
                options.Add(tbOptionName.Text);
                using (FileStream file = new FileStream(@"OptionList.bin", FileMode.Create))
                {
                    BinaryFormatter binFormat = new BinaryFormatter();
                    binFormat.Serialize(file, options);
                }
            }
        }

        private void btnDeleteOption_Click(object sender, EventArgs e)
        {
            if(checkedListBoxOptions.SelectedItem != null)
            {
                string selOption = (string)checkedListBoxOptions.SelectedItem;
                options.Remove(selOption);
                checkedListBoxOptions.DataSource = options;
                using (FileStream file = new FileStream(@"OptionList.bin", FileMode.Create))
                {
                    BinaryFormatter binFormat = new BinaryFormatter();
                    binFormat.Serialize(file, options);
                }
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            tbModel2.Clear();
            tbOS2.Clear();
            tbProcessor2.Clear();
            tbPrice2.Clear();
            tbPicture.Clear();
        }

        private void btnAddNewPhone_Click(object sender, EventArgs e)
        {
            Phone newPhone = new Phone();
            newPhone.Model = tbModel2.Text;
            newPhone.OperatingSystem = tbOS2.Text;
            double a;
            if (Double.TryParse(tbProcessor2.Text, out a)) newPhone.Processor = a;
            if (Double.TryParse(tbPrice2.Text, out a)) newPhone.Price = a;
            newPhone.PathToImage = tbPicture.Text;
            newPhone.Options = new BindingList<string>();
            for (int i = 0; i < checkedListBoxOptions.CheckedItems.Count; i++)
            {
                newPhone.Options.Add(checkedListBoxOptions.CheckedItems[i].ToString());
            }
            phones.Add(newPhone);
        }
    }
}