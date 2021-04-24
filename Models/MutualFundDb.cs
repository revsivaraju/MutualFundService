using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyMutualFund.Models
{
    public class MutualFundDb : IMutualFundDb
    {
        public static List<DailyMutualFundNav> mutualFundDetailList = new List<DailyMutualFundNav> {
            new DailyMutualFundNav { MutualFundId=1,MutualFundName="ABC",MutualFundValue=100},
            new DailyMutualFundNav { MutualFundId = 2, MutualFundName = "DEF", MutualFundValue = 200 },
            new DailyMutualFundNav { MutualFundId = 3, MutualFundName = "GHI", MutualFundValue = 300 },
            new DailyMutualFundNav { MutualFundId = 4, MutualFundName = "JKL", MutualFundValue = 400 },
            new DailyMutualFundNav { MutualFundId = 5, MutualFundName = "MNO", MutualFundValue = 500 }
            };

        public DailyMutualFundNav MutualFundNav(string mutualFundName)
        {
            return mutualFundDetailList.FirstOrDefault(c => c.MutualFundName.ToLower() == mutualFundName.ToLower());

        }
    }
}
