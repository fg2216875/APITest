using APITest.Interface;
using APITest.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using StockAnalysis.Dapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StockAnalysis.Dapper.Respotory
{
    public class StockInfoDailyRepository : IStockInfoDailyRepository
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
        }
        public async Task<string> Insert(IEnumerable<T_PerDyPbrDaily> data)
        {
            using (var conn = _StockDb.CreatConnection())
            {
                //string strSql = @"INSERT INTO T_StockInfoDaily(StockNO, Date, OpeningPrice, ClosingPrice, 
                //        TotalVolume, ForeignInvestorsVolume,InvestmentTrustVolume,DealerVolume,InvestorsTotalDiffVolK) VALUES
                //        (@StockNO, @Date, @OpeningPrice, @ClosingPrice, @TotalVolume, @ForeignInvestorsVolume,
                //        @InvestmentTrustVolume, @DealerVolume, @InvestorsTotalDiffVolK)";
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlBulkCopy bulk = new SqlBulkCopy((SqlConnection)conn, SqlBulkCopyOptions.KeepIdentity, (SqlTransaction)trans))
                        {
                            string json = JsonConvert.SerializeObject(new { Table = data });
                            DataSet DS = JsonConvert.DeserializeObject<DataSet>(json);
                            bulk.DestinationTableName = "T_PerDyPbrDaily";
                            bulk.BatchSize = 1000;
                            bulk.BulkCopyTimeout = 60;

                            bulk.ColumnMappings.Add("StockNO", "StockNO");
                            bulk.ColumnMappings.Add("Date", "Date");
                            bulk.ColumnMappings.Add("DividendYield", "DividendYield");
                            bulk.ColumnMappings.Add("PriceEarningsRatio", "PriceEarningsRatio");
                            bulk.ColumnMappings.Add("PriceBookRatio", "PriceBookRatio");
                            bulk.ColumnMappings.Add("FinancialReportYearQuarter", "FinancialReportYearQuarter");
                            bulk.ColumnMappings.Add("CreateDate", "CreateDate");
                            await bulk.WriteToServerAsync(DS.Tables[0]);
                            trans.Commit();
                            return "Succes";
                        }
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        return "False";
                    }
                }

            }
        }

        public async Task<string> InsertStockDaily(T_StockInfoDaily data)
        {
            using (var conn = _StockDb.CreatConnection())
            {
                string strSql = @"INSERT INTO T_StockInfoDaily(StockNO, Date, OpeningPrice, ClosingPrice, 
                            TotalVolume, ForeignInvestorsVolume,InvestmentTrustVolume,DealerVolume,InvestorsTotalDiffVolK,CreateDate) VALUES
                            (@StockNO, @Date, @OpeningPrice, @ClosingPrice, @TotalVolume, @ForeignInvestorsVolume,
                            @InvestmentTrustVolume, @DealerVolume, @InvestorsTotalDiffVolK,@CreateDate)";
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        //await conn.ExecuteAsync(strSql, new
                        //{
                        //    StockNO = data.StockNO,
                        //    Date = data.Date,
                        //    OpeningPrice = data.OpeningPrice,
                        //    ClosingPrice = data.ClosingPrice,
                        //    TotalVolume = data.TotalVolume,
                        //    ForeignInvestorsVolume = data.ForeignInvestorsVolume,
                        //    InvestmentTrustVolume = data.InvestmentTrustVolume,
                        //    DealerVolume = data.DealerVolume,
                        //    InvestorsTotalDiffVolK = data.InvestorsTotalDiffVolK
                        //}, trans);
                        await conn.ExecuteAsync(strSql, data, trans);
                        trans.Commit();
                        return "Success InsertStockDaily";
                    }
                    catch(Exception ex)
                    {
                        trans.Rollback();
                        return "False InsertStockDaily";
                    }
                }
            }
        }
    }
}
