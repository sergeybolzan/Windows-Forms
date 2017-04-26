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
    public partial class AddSwitchForm : Form
    {
        public AddSwitchForm()
        {
            InitializeComponent();
        }

        //Нажатие на кнопку "Добавить коммутатор"
        private void btnAddSwitch_Click(object sender, EventArgs e)
        {
            WorkWithData.AddNewSwitch(cmbAddress.Text, tbName.Text, tb_IPaddress.Text, cmbVLAN_manag.Text, tbVLANsubscr.Text, cmbModel.Text, tbFirmware.Text, tbFeatures.Text, tbNotes.Text);
        }

        //Обновление комбобоксов при переходе обратно на данное окно (чтобы не закрывая окно можно было увидеть новые данные)
        private void AddSwitchForm_Activated(object sender, EventArgs e)
        {
            WorkWithData.UpdateComboBoxes(cmbAddress, cmbModel, cmbVLAN_manag);
        }
    }
}
