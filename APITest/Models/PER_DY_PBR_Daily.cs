using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAnalysis.Models
{
    public class PER_DY_PBR_Daily
    {
        //"證券代號","證券名稱","殖利率(%)","股利年度","本益比","股價淨值比","財報年/季"
        [Name("日期")]
        public string Date { get; set; }
        [Name("殖利率(%)")]
        public double? DividendYield { get; set; }
        [Name("本益比")]
        public double? PriceEarningsRatio { get; set; }
        [Name("股價淨值比")]
        public double? PriceBookRatio { get; set; }
        [Name("財報年/季")]
        public DateTime FinancialReportYearQuarter { get; set; }
    }
}
