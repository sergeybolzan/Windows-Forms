using System;
using System.Collections.Generic;
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
                //string name = node.Attributes[0].Value;
                //int age = int.Parse(node["Age"].InnerText);
                //bool programmer = bool.Parse(node["Programmer"].InnerText);
                //listBox1.Items.Add(new Employee(name, age, programmer));
            }
        }
    }
}
