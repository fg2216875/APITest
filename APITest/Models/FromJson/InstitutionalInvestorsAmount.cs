using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAnalysis.Models.FromJson
{
    public class InstitutionalInvestorsAmount
    {
        public InvestorsAmount data { get; set; }
    }
    public class InvestorsAmount
    {
        public List<InstitutionalInvestors> list { get; set; }
        public DateTime refreshedTs { get; set; }
    }
    public class InstitutionalInvestors
    {
        public int dealerBuyVolK { get; set; }
        public int dealerDiffVolK { get; set; }
        public int dealerSellVolK { get; set; }
        public int foreignBuyVolK { get; set; }
        public int foreignDiffVolK { get; set; }
        public int foreignSellVolK { get; set; }
        public int investmentTrustBuyVolK { get; set; }
        public int investmentTrustDiffVolK { get; set; }
        public int investmentTrustSellVolK { get; set; }
        public object periodSum { get; set; }
        public int totalBuyVolK { get; set; }
        public int totalDiffVolK { get; set; }
        public int totalSellVolK { get; set; }
    }
}
