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
    }
}
