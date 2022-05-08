using APITest.Interface;
using APITest.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StockAnalysis.Dapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAnalysis.Dapper.Respotory
{
    public class StockInfoDailyRepository: IStockInfoDailyRepository
    {
        private readonly StockDbContext _StockDb;
        public StockInfoDailyRepository(StockDbContext StockDb)
        {
            _StockDb = StockDb;
        } 
        public async Task<IEnumerable<T_StockInfoDaily>> GetAll()
        {
            string sql = "select * from T_StockInfoDaily";
            using (var conn = _StockDb.CreatConnection())
            {
                var StockInfo = await conn.QueryAsync<T_StockInfoDaily>(sql);
                return StockInfo.ToList();
            }
            //using (var conn = new SqlConnection(_StockDb.GetConnection()))
            //{
            //    conn.Open();
            //    var StockInfo = await conn.QueryAsync<T_StockInfoDaily>(sql);
            //    return StockInfo.ToList();
            //}
        }
        //public void Insert(T_StockInfoDaily StockInfoDaily)
        //{
        //    using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionStr))
        //    {
        //        string strSql = @"INSERT INTO T_StockInfoDaily(StockNO, Date, OpeningPrice, ClosingPrice, 
        //                    TotalVolume, ForeignInvestorsVolume,InvestmentTrustVolume,DealerVolume,InvestorsTotalDiffVolK) VALUES
        //                    (@StockNO, @Date, @OpeningPrice, @ClosingPrice, @TotalVolume, @ForeignInvestorsVolume,
        //                    @InvestmentTrustVolume, @DealerVolume, @InvestorsTotalDiffVolK)";
        //        conn.Execute(strSql, new
        //        {
        //            StockNO = StockInfoDaily.StockNO,
        //            Date = StockInfoDaily.Date,
        //            OpeningPrice = StockInfoDaily.OpeningPrice,
        //            ClosingPrice = StockInfoDaily.ClosingPrice,
        //            TotalVolume = StockInfoDaily.TotalVolume,
        //            ForeignInvestorsVolume = StockInfoDaily.ForeignInvestorsVolume,
        //            InvestmentTrustVolume = StockInfoDaily.InvestmentTrustVolume,
        //            DealerVolume = StockInfoDaily.DealerVolume,
        //            InvestorsTotalDiffVolK = StockInfoDaily.InvestorsTotalDiffVolK
        //        });
        //    }
        //}
    }
}
