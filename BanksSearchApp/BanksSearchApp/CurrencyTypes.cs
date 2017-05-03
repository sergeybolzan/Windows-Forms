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
    public struct Currency
    {
        public decimal UsdSell;
        public decimal UsdBuy;
        public decimal EurSell;
        public decimal EurBuy;
        public decimal RurSell;
        public decimal RurBuy;
        public Currency(decimal UsdSell, decimal UsdBuy, decimal EurSell, decimal EurBuy, decimal RurSell, decimal RurBuy)
        {
            this.UsdSell = UsdSell;
            this.UsdBuy = UsdBuy;
            this.EurSell = EurSell;
            this.EurBuy = EurBuy;
            this.RurSell = RurSell;
            this.RurBuy = RurBuy;
        }
    }
}
