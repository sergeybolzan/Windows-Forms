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
    public partial class AddModelOfSwitchForm : Form
    {
        private ToolStripMenuItem ParentButton_miAddmodel;
        public AddModelOfSwitchForm(ToolStripMenuItem miAddModel)
        {
            InitializeComponent();
            this.ParentButton_miAddmodel = miAddModel;
            lbModels.DataSource = WorkWithData.AddModelsToListBox();
        }

        //Нажатие на кнопку "Добавить модель"
        private void btnAddModel_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbAddModel.Text))
            {
                WorkWithData.AddNewModel(tbAddModel.Text, lbModels);
            }
            else MessageBox.Show("Введите модель коммутатора!");
        }

        //При закрытии формы делаем активным пункт меню главного окна
        private void AddModelOfSwitchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ParentButton_miAddmodel.Enabled = true;
        }
    }
}
