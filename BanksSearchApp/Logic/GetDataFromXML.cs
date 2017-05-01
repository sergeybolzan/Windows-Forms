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
        public static void UpdateBanksInfo()
        {
            using (BanksModelContainer db = new BanksModelContainer())
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"http://www.obmennik.by/xml/kurs.xml");
                foreach (XmlNode node in doc.DocumentElement)
                {
                    int id = Int32.Parse(node["idbank"].InnerText);
                    Bank bank = db.BankSet.Find(id);
                    if (bank != null)
                    {
                        bank.DateTime = Convert.ToDateTime(node["date"].InnerText + " " + node["time"].InnerText);
                        bank.UsdSell = Decimal.Parse(node["usd"].FirstChild.InnerText, CultureInfo.InvariantCulture);
                        bank.UsdBuy = Decimal.Parse(node["usd"].LastChild.InnerText, CultureInfo.InvariantCulture);
                        bank.EurSell = Decimal.Parse(node["eur"].FirstChild.InnerText, CultureInfo.InvariantCulture);
                        bank.EurBuy = Decimal.Parse(node["eur"].LastChild.InnerText, CultureInfo.InvariantCulture);
                        bank.RurSell = Decimal.Parse(node["rur"].FirstChild.InnerText, CultureInfo.InvariantCulture);
                        bank.RurBuy = Decimal.Parse(node["rur"].LastChild.InnerText, CultureInfo.InvariantCulture);
                    }
                }
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Метод для загрузки данных из файла "banks.xml" в таблицу BranchBankSet базы данных
        /// </summary>
        public static void GetBranchsBanksInfo()
        {
            using (BanksModelContainer db = new BanksModelContainer())
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"banks.xml");
                XmlNodeList departmenNodes = doc.GetElementsByTagName("departmen");
                foreach (XmlNode departmenNode in departmenNodes)
                {
                    BranchBank branchBank = new BranchBank();
                    branchBank.Address = departmenNode["address"].InnerText;
                    branchBank.Latitude = Double.Parse(departmenNode["latitude"].InnerText);
                    branchBank.Longitude = Double.Parse(departmenNode["longitude"].InnerText);
                    branchBank.BankId = 1; // чтобы не выбрасывалось исключение
                    db.BranchBankSet.Add(branchBank);
                }
                db.SaveChanges();
            }

        }
    }
}
