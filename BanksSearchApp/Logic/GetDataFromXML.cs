using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Logic
{
    public static class GetDataFromXML
    {
        public static void LoadBanks()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"http://www.obmennik.by/xml/kurs.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                Bank bank = new Bank();
                bank.Id = Int32.Parse(node["idbank"].InnerText);
                bank.DateTime = Convert.ToDateTime(node["date"].InnerText + " " + node["time"].InnerText);
                bank.UsdSell = Double.Parse(node["usd"].FirstChild.InnerText, CultureInfo.InvariantCulture);
                bank.UsdBuy = Double.Parse(node["usd"].LastChild.InnerText, CultureInfo.InvariantCulture);
                bank.EurSell = Double.Parse(node["eur"].FirstChild.InnerText, CultureInfo.InvariantCulture);
                bank.EurBuy = Double.Parse(node["eur"].LastChild.InnerText, CultureInfo.InvariantCulture);
                bank.RurSell = Double.Parse(node["rur"].FirstChild.InnerText, CultureInfo.InvariantCulture);
                bank.RurBuy = Double.Parse(node["rur"].LastChild.InnerText, CultureInfo.InvariantCulture);

                using (BanksModelContainer db = new BanksModelContainer())
                {
                    Bank findBank = db.BankSet.Find(bank.Id);
                    if (findBank != null)
                    {



                        db.BankSet.Add(bank);
                        db.SaveChanges();
                    }
                }

                //string name = node.Attributes[0].Value;
                //int age = int.Parse(node["Age"].InnerText);
                //bool programmer = bool.Parse(node["Programmer"].InnerText);
                //listBox1.Items.Add(new Employee(name, age, programmer));
            }
        }
    }
}
