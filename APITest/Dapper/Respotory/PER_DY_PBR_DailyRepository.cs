using APITest.Interface;
using APITest.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using StockAnalysis.Dapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StockAnalysis.Dapper.Respotory
{
    public class PER_DY_PBR_DailyRepository
    {
        //public async Task<string> Insert(string Json)
        //{
        //    using (var conn = _StockDb.CreatConnection())
        //    {
        //        //string strSql = @"INSERT INTO T_StockInfoDaily(StockNO, Date, OpeningPrice, ClosingPrice, 
        //        //        TotalVolume, ForeignInvestorsVolume,InvestmentTrustVolume,DealerVolume,InvestorsTotalDiffVolK) VALUES
        //        //        (@StockNO, @Date, @OpeningPrice, @ClosingPrice, @TotalVolume, @ForeignInvestorsVolume,
        //        //        @InvestmentTrustVolume, @DealerVolume, @InvestorsTotalDiffVolK)";
        //        using (var trans = conn.BeginTransaction())
        //        {
        //            try
        //            {
        //                using (SqlBulkCopy bulk = new SqlBulkCopy((SqlConnection)conn, SqlBulkCopyOptions.KeepIdentity, (SqlTransaction)trans))
        //                {
        //                    DataSet DS = JsonConvert.DeserializeObject<DataSet>(Json);
        //                    bulk.DestinationTableName = "T_PerDyPbrDaily";
        //                    bulk.BatchSize = 1000;
        //                    bulk.BulkCopyTimeout = 60;

        //                    bulk.ColumnMappings.Add("StockNO", "StockNO");
        //                    bulk.ColumnMappings.Add("Date", "Date");
        //                    bulk.ColumnMappings.Add("DividendYield", "DividendYield");
        //                    bulk.ColumnMappings.Add("PriceEarningsRatio", "PriceEarningsRatio");
        //                    bulk.ColumnMappings.Add("PriceBookRatio", "PriceBookRatio");
        //                    bulk.ColumnMappings.Add("FinancialReportYearQuarter", "FinancialReportYearQuarter");

        //                    await bulk.WriteToServerAsync(DS.Tables[0]);
        //                    trans.Commit();
        //                    return "Succes";
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                trans.Rollback();
        //                return "False";
        //            }
        //        }

        //    }
        //}

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
