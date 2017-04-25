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
        }

        private void AddAddressForm_Load(object sender, EventArgs e)
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                var addresses = db.Address.OrderBy(x => x.SwitchAddress).Select(x => x.SwitchAddress).ToList();
                lbAddresses.DataSource = addresses;
            }
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbAddAddress.Text))
            {
                using (SwitchEntities db = new SwitchEntities())
                {

                    Address address = new Address() { SwitchAddress = tbAddAddress.Text };
                    Address a = db.Address.Where(x => x.SwitchAddress == address.SwitchAddress).FirstOrDefault();
                    if (a == null)
                    {
                        db.Address.Add(address);
                        db.SaveChanges();
                        MessageBox.Show("Адрес добавлен в базу");
                        var addresses = db.Address.OrderBy(x => x.SwitchAddress).Select(x => x.SwitchAddress).ToList();
                        lbAddresses.DataSource = addresses;
                    }
                    else MessageBox.Show("Такой адрес уже есть в базе");
                }
            }
            else MessageBox.Show("Введите адрес!");
        }

        private void AddAddressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ParentButton_miAddAddress.Enabled = true;
        }
    }
}
