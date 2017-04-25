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

        private void btnAddSwitch_Click(object sender, EventArgs e)
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                int idAddress = db.Address.Where(x => x.SwitchAddress == cmbAddress.Text).Select(x => x.ID).FirstOrDefault();
                int selectedVLAN = Int32.Parse(cmbVLAN_manag.Text);
                int idVLAN_manag = db.VLAN_manag.Where(x => x.SwitchVLAN == selectedVLAN).Select(x => x.ID).FirstOrDefault();
                int idModel = db.Model.Where(x => x.SwitchModel == cmbModel.Text).Select(x => x.ID).FirstOrDefault();
                Switch newSwitch = new Switch()
                {
                    Address_ID = idAddress,
                    Name = tbName.Text,
                    IP_address = tb_IPaddress.Text,
                    VLAN_manag_ID = idVLAN_manag,
                    VLAN_subscriber = tbVLANsubscr.Text,
                    Model_ID = idModel,
                    Firmware = tbFirmware.Text,
                    Features = tbFeatures.Text,
                    Notes = tbNotes.Text
                };
                db.Switch.Add(newSwitch);
                db.SaveChanges();
            }
        }

        private void AddSwitchForm_Activated(object sender, EventArgs e)
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                var addresses = db.Address.OrderBy(x => x.SwitchAddress).Select(x => x.SwitchAddress).ToList();
                cmbAddress.DataSource = addresses;
                var models = db.Model.OrderBy(x => x.SwitchModel).Select(x => x.SwitchModel).ToList();
                cmbModel.DataSource = models;
                cmbModel.SelectedItem = "D-Link DES-3200-28";
                var vlans = db.VLAN_manag.OrderBy(x => x.SwitchVLAN).Select(x => x.SwitchVLAN).ToList();
                cmbVLAN_manag.DataSource = vlans;
            }

        }
    }
}
