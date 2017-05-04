using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Logic
{
    public static class GetDataFromDB
    {
        public static IEnumerable<BranchBank> GetBranchsBanksInfo()
        {
            using (BanksModelContainer db = new BanksModelContainer())
            {
                db.BankSet.Load();
                return db.BranchBankSet.ToList();
            }
        }
        //public static IEnumerable<BranchBank> GetBranchsBanksWithMinminumExchangeRate()
        //{
        //    using (BanksModelContainer db = new BanksModelContainer())
        //    {
        //        db.BankSet.Load();
        //        var minExchangeRate = db.BankSet.Select(x => x.UsdBuy).Min();
        //        return db.BranchBankSet.Where(x => x.Bank.UsdBuy == minExchangeRate).ToList();
        //    }
        //}
    }
}
