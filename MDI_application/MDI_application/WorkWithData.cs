using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace MDI_application
{
    /// <summary>
    /// Статический класс для работы с БД с помощью Entity Framework
    /// </summary>
    public static class WorkWithData
    {
        #region Методы для заполнения данными (адрес, модель, VLAN) листбоксов, находящихся на окнах добавления соответственно адреса, модели, VLAN-а
        /// <summary>
        /// Метод, возвращающий список адресов из таблицы БД Address
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> AddAddressesToListBox()
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                IEnumerable<string> addresses = db.Address.OrderBy(x => x.SwitchAddress).Select(x => x.SwitchAddress).ToList();
                return addresses;
            }
        }

        /// <summary>
        /// Метод, возвращающий список моделей из таблицы БД Model
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> AddModelsToListBox()
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                IEnumerable<string> models = db.Model.OrderBy(x => x.SwitchModel).Select(x => x.SwitchModel).ToList();
                return models;
            }
        }

        /// <summary>
        /// Метод, возвращающий список VLAN-ов из таблицы БД VLAN_manag
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<int?> AddVLANsToListBox()
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                IEnumerable<int?> vlans = db.VLAN_manag.OrderBy(x => x.SwitchVLAN).Select(x => x.SwitchVLAN).ToList();
                return vlans;
            }
        }
        #endregion


        #region Методы для добавления новых данных (адрес, модель, VLAN) в соответствующие таблицы БД
        /// <summary>
        /// Добавление нового адреса в таблицу БД Address
        /// </summary>
        /// <param name="newAddress">Строка с новым адресом</param>
        /// <param name="lbAddresses">Листбокс со всеми адресами</param>
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

        /// <summary>
        /// Добавление новой модели в таблицу БД Model
        /// </summary>
        /// <param name="newModel">Строка с новым названием модели</param>
        /// <param name="lbModels">Листбокс со всеми моделями</param>
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

        /// <summary>
        /// Добавление нового VLAN-а в таблицу БД VLAN_manag
        /// </summary>
        /// <param name="newVLAN">Значение нового VLAN-а</param>
        /// <param name="lbVLANs">Листбокс со всеми VLAN-ами</param>
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
        #endregion


        #region Методы для окна добавления нового коммутатора
        /// <summary>
        /// Добавление нового коммутатора на основе заполненных данных
        /// </summary>
        /// <param name="address"></param>
        /// <param name="name"></param>
        /// <param name="ipaddress"></param>
        /// <param name="VLAN_manag"></param>
        /// <param name="VLAN_subscr"></param>
        /// <param name="model"></param>
        /// <param name="firmware"></param>
        /// <param name="features"></param>
        /// <param name="notes"></param>
        public static void AddNewSwitch(string address, string name, string ipaddress, string VLAN_manag, string VLAN_subscr, string model, string firmware, string features, string notes)
        {
            using (SwitchEntities db = new SwitchEntities())
            {
                int idAddress = db.Address.Where(x => x.SwitchAddress == address).Select(x => x.ID).FirstOrDefault();
                int selectedVLAN = Int32.Parse(VLAN_manag);
                int idVLAN_manag = db.VLAN_manag.Where(x => x.SwitchVLAN == selectedVLAN).Select(x => x.ID).FirstOrDefault();
                int idModel = db.Model.Where(x => x.SwitchModel == model).Select(x => x.ID).FirstOrDefault();
                Switch newSwitch = new Switch()
                {
                    Address_ID = idAddress,
                    Name = name,
                    IP_address = ipaddress,
                    VLAN_manag_ID = idVLAN_manag,
                    VLAN_subscriber = VLAN_subscr,
                    Model_ID = idModel,
                    Firmware = firmware,
                    Features = features,
                    Notes = notes
                };
                db.Switch.Add(newSwitch);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Обновление данных в комбобоксах
        /// </summary>
        /// <param name="cmbAddress"></param>
        /// <param name="cmbModel"></param>
        /// <param name="cmbVLAN_manag"></param>
        public static void UpdateComboBoxes(ComboBox cmbAddress, ComboBox cmbModel, ComboBox cmbVLAN_manag)
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
        #endregion
    }
}
