using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanksSearchApp
{
    public enum CurrencyTypes
    {
        UsdSell, UsdBuy, EurSell, EurBuy, RurSell, RurBuy
    }
    public class Currency
    {
        public string BankName { get; set; }
        public string BranchAddress { get; set; }
        public DateTime DateTime { get; set; }
        public decimal UsdSell { get; set; }
        public decimal UsdBuy { get; set; }
        public decimal EurSell { get; set; }
        public decimal EurBuy { get; set; }
        public decimal RurSell { get; set; }
        public decimal RurBuy { get; set; }
        public Currency(string bankName, string branchAddress, DateTime dateTime, decimal usdSell, decimal usdBuy, decimal eurSell, decimal eurBuy, decimal rurSell, decimal rurBuy)
        {
            this.BankName = bankName;
            this.BranchAddress = branchAddress;
            this.DateTime = dateTime;
            this.UsdSell = usdSell;
            this.UsdBuy = usdBuy;
            this.EurSell = eurSell;
            this.EurBuy = eurBuy;
            this.RurSell = rurSell;
            this.RurBuy = rurBuy;
        }
    }
}
