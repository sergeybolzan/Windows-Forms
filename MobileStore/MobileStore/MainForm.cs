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
            //    new Phone("Iphone", "IOS", 2.2, 700),
            //    new Phone("Samsung", "Android", 2.5, 650),
            //    new Phone("Huawei", "Android", 2.0, 600),
            //    new Phone("Xiaomi", "Android", 2.5, 400)
            //};

            //using (FileStream file = new FileStream(@"PhonesList.bin", FileMode.Create))
            //{
            //    BinaryFormatter binFormat = new BinaryFormatter();
            //    binFormat.Serialize(file, phones);
            //}


            using (FileStream file = new FileStream(@"PhonesList.bin", FileMode.Open))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                phones = (BindingList<Phone>)binFormat.Deserialize(file);
            }
            listPhones.DataSource = phones;

        }
    }
}
