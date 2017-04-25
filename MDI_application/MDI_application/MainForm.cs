using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDI_application.Forms;

namespace MDI_application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Resize += MainForm_Resize;
        }

        //Упорядочивание при изменении размера главного окна
        void MainForm_Resize(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }


        #region Меню - Окно
        //Окно - Каскадом
        private void miCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        //Окно - Горизонтально
        private void miHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        //Окно - Вертикально
        private void miVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        //Окно - Минимизировать
        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Minimized;
            }
        }

        //Окно - Максимизировать
        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Maximized;
            }
        }
        #endregion


        #region Меню - Задачи
        //Задачи - Список коммутаторов
        private void miSwitches_Click(object sender, EventArgs e)
        {
            SwitchesForm switchesForm = new SwitchesForm();
            switchesForm.MdiParent = this;
            switchesForm.WindowState = FormWindowState.Maximized;
            switchesForm.Show();
        }

        //Задачи - Добавить коммутатор
        private void miAddSwitch_Click(object sender, EventArgs e)
        {
            AddSwitchForm addSwitchForm = new AddSwitchForm();
            addSwitchForm.MdiParent = this;
            addSwitchForm.Show();
        }
        
        //Задачи - Добавить адрес
        private void miAddAddress_Click(object sender, EventArgs e)
        {
            AddAddressForm addAddressForm = new AddAddressForm(miAddAddress);
            addAddressForm.MdiParent = this;
            addAddressForm.Show();
            miAddAddress.Enabled = false;
        }

        //Задачи - Добавить модель
        private void miAddModel_Click(object sender, EventArgs e)
        {
            AddModelOfSwitchForm addModelOfSwitchForm = new AddModelOfSwitchForm(miAddModel);
            addModelOfSwitchForm.MdiParent = this;
            addModelOfSwitchForm.Show();
            miAddModel.Enabled = false;
        }

        //Задачи - Добавить VLAN
        private void miAddVLAN_manag_Click(object sender, EventArgs e)
        {
            AddVLAN_managForm addVLAN_managForm = new AddVLAN_managForm(miAddVLAN_manag);
            addVLAN_managForm.MdiParent = this;
            addVLAN_managForm.Show();
            miAddVLAN_manag.Enabled = false;
        }
        #endregion
    }
}
