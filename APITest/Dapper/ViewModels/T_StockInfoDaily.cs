using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockAnalysis.Dapper.ViewModels
{
    public class T_StockInfoDaily
    {
        [Key]
        public int StockInfoDailyID { get; set; }
        public string StockNO { get; set; }
        public DateTime? Date { get; set; }
        public decimal? OpeningPrice { get; set; }
        public decimal? ClosingPrice { get; set; }
        public int? TotalVolume { get; set; }
        public int? ForeignInvestorsVolume { get; set; }
        public int? InvestmentTrustVolume { get; set; }
        public int? DealerVolume { get; set; }
        public int? InvestorsTotalDiffVolK { get; set; }
    }
}
