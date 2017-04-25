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
    public partial class AddAddressForm : Form
    {
        private ToolStripMenuItem ParentButton_miAddAddress;
        public AddAddressForm(ToolStripMenuItem miAddAddress)
        {
            InitializeComponent();
            this.ParentButton_miAddAddress = miAddAddress;
            lbAddresses.DataSource = WorkWithData.AddAddressesToListBox();
        }

        //Нажатие на кнопку "Добавить адрес"
        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbAddAddress.Text))
            {
                WorkWithData.AddNewAddress(tbAddAddress.Text, lbAddresses);
            }
            else MessageBox.Show("Введите адрес!");
        }

        //При закрытии формы делаем активным пункт меню главного окна
        private void AddAddressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ParentButton_miAddAddress.Enabled = true;
        }
    }
}
