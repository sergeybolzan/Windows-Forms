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
        }

        private void AddVLAN_managForm_Load(object sender, EventArgs e)
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                var VLANs = db.VLAN_manag.OrderBy(x => x.SwitchVLAN).Select(x => x.SwitchVLAN).ToList();
                lbVLANs.DataSource = VLANs;
            }
        }

        private void btnAddVLAN_Click(object sender, EventArgs e)
        {
            int parseVLAN;
            if (Int32.TryParse(tbAddVLAN.Text, out parseVLAN) && parseVLAN > 0 && parseVLAN < 4097)
            {
                using (SwitchEntities db = new SwitchEntities())
                {

                    VLAN_manag vlan = new VLAN_manag() { SwitchVLAN = parseVLAN };
                    VLAN_manag a = db.VLAN_manag.Where(x => x.SwitchVLAN == vlan.SwitchVLAN).FirstOrDefault();
                    if (a == null)
                    {
                        db.VLAN_manag.Add(vlan);
                        db.SaveChanges();
                        MessageBox.Show("VLAN добавлен в базу");
                        var VLANs = db.VLAN_manag.OrderBy(x => x.SwitchVLAN).Select(x => x.SwitchVLAN).ToList();
                        lbVLANs.DataSource = VLANs;
                    }
                    else MessageBox.Show("Такой VLAN уже есть в базе");
                }
            }
            else MessageBox.Show("Введите значение от 1 до 4096!");

        }

        private void AddVLAN_managForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ParentButton_miAddVLAN.Enabled = true;
        }
    }
}
