using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace MDI_application
{
    public static class WorkWithData
    {
        public static IEnumerable<string> AddAddressesToListBox()
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                IEnumerable<string> addresses = db.Address.OrderBy(x => x.SwitchAddress).Select(x => x.SwitchAddress).ToList();
                return addresses;
            }
        }
        public static IEnumerable<string> AddModelsToListBox()
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                IEnumerable<string> models = db.Model.OrderBy(x => x.SwitchModel).Select(x => x.SwitchModel).ToList();
                return models;
            }
        }
        public static IEnumerable<int?> AddVLANsToListBox()
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                IEnumerable<int?> vlans = db.VLAN_manag.OrderBy(x => x.SwitchVLAN).Select(x => x.SwitchVLAN).ToList();
                return vlans;
            }
        }

        public static void AddNewAddress(string newAddress, ListBox lbAddresses)
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                Address address = new Address() { SwitchAddress = newAddress };
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
        public static void AddNewModel(string newModel, ListBox lbModels)
        {
            using (SwitchEntities db = new SwitchEntities())
            {

                Model model = new Model() { SwitchModel = newModel };
                Model a = db.Model.Where(x => x.SwitchModel == model.SwitchModel).FirstOrDefault();
                if (a == null)
                {
                    db.Model.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Модель добавлена в базу");
                    var models = db.Model.OrderBy(x => x.SwitchModel).Select(x => x.SwitchModel).ToList();
                    lbModels.DataSource = models;
                }
                else MessageBox.Show("Такая модель коммутатора уже есть в базе");
            }
        }
        public static void AddNewVLAN(int newVLAN, ListBox lbVLANs)
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                VLAN_manag vlan = new VLAN_manag() { SwitchVLAN = newVLAN };
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
    }
}
