using Dapper;
using Microsoft.Data.SqlClient;
using StockAnalysis.Dapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAnalysis.Dapper.Respotory
{
    public class PER_DY_PBR_DailyRepository
    {

        //public void Insert(T_PerDyPbrDaily PerDyPbrDailyInfo)
        //{
        //    using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionStr))
        //    {
        //        string strSql = @"INSERT INTO T_PerDyPbrDaily(StockNO, Date, DividendYield, 
        //                    PriceEarningsRatio, PriceBookRatio, FinancialReportYearQuarter) VALUES
        //                    (@StockNO, @Date, @DividendYield, @PriceEarningsRatio, @PriceBookRatio, @FinancialReportYearQuarter)";
        //        conn.Execute(strSql,new {
        //            StockNO = PerDyPbrDailyInfo.StockNO,Date =PerDyPbrDailyInfo.Date ,
        //            DividendYield =PerDyPbrDailyInfo.DividendYield,
        //            PriceEarningsRatio = PerDyPbrDailyInfo.PriceEarningsRatio,
        //            PriceBookRatio = PerDyPbrDailyInfo.PriceBookRatio,
        //            FinancialReportYearQuarter = PerDyPbrDailyInfo.FinancialReportYearQuarter
        //        });
        //    }
        //}
        

        //public IEnumerable<FundamentalDaily> GetByDate(DateTime date)
        //{
        //    return _conn.Query<FundamentalDaily>(
        //        "select * from FundamentalDaily where date=@date", new { date }
        //    );
        //}

        //public bool IsExist(DateTime date)
        //{
        //    return _conn.ExecuteScalar<bool>(
        //        "select count(1) from FundamentalDaily where date=@date",
        //        new { date }
        //    );
        //}
    }
}
