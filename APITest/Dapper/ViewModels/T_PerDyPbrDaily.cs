using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockAnalysis.Dapper.ViewModels
{
    public class T_PerDyPbrDaily
    {
        [Key]
        public int PerDyPbrDailyID { get; set; }
        public string StockNO { get; set; }
        public DateTime Date { get; set; }
        public double? DividendYield { get; set; }
        public double? PriceEarningsRatio { get; set; }
        public double? PriceBookRatio { get; set; }
        public DateTime FinancialReportYearQuarter { get; set; }
    }
}
