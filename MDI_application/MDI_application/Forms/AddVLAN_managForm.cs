using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_application.Forms
{
    public partial class AddVLAN_managForm : Form
    {
        private ToolStripMenuItem ParentButton_miAddVLAN;
        public AddVLAN_managForm(ToolStripMenuItem miAddVLAN)
        {
            InitializeComponent();
            this.ParentButton_miAddVLAN = miAddVLAN;
            lbVLANs.DataSource = WorkWithData.AddVLANsToListBox();
        }

        //Нажатие на кнопку "Добавить VLAN"
        private void btnAddVLAN_Click(object sender, EventArgs e)
        {
            int parseVLAN;
            if (Int32.TryParse(tbAddVLAN.Text, out parseVLAN) && parseVLAN > 0 && parseVLAN < 4097)
            {
                WorkWithData.AddNewVLAN(parseVLAN, lbVLANs);
            }
            else MessageBox.Show("Введите значение от 1 до 4096!");
        }

        //При закрытии формы делаем активным пункт меню главного окна
        private void AddVLAN_managForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ParentButton_miAddVLAN.Enabled = true;
        }
    }
}
