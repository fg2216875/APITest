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
    public class StockPriceByVolumeRepository: IStockPriceByVolumeRepository
    {
        private readonly StockDbContext _StockDB;
        public StockPriceByVolumeRepository(StockDbContext StockDB)
        {
            _StockDB = StockDB;
        }
        public async Task<string> InsertStockVolume(IEnumerable<T_StockPriceByVolume> data)
        {
            string json = JsonConvert.SerializeObject(new { Table = data });
            DataSet DS = JsonConvert.DeserializeObject<DataSet>(json);
            using (var conn = _StockDB.CreatConnection())
            {
                conn.Open();
                using(var trans = conn.BeginTransaction())
                {
                    try
                    {
                        using(var bulk = new SqlBulkCopy((SqlConnection)conn,SqlBulkCopyOptions.KeepIdentity, (SqlTransaction)trans))
                        {
                            bulk.DestinationTableName = "T_StockPriceByVolume";
                            bulk.BatchSize = 1000;
                            bulk.BulkCopyTimeout = 60;

                            bulk.ColumnMappings.Add("StockNO", "StockNO");
                            bulk.ColumnMappings.Add("Date", "Date");
                            bulk.ColumnMappings.Add("PriceByVolume", "PriceByVolume");
                            bulk.ColumnMappings.Add("VolumeK", "VolumeK");
                            bulk.ColumnMappings.Add("CreateDate", "CreateDate");
                            await bulk.WriteToServerAsync(DS.Tables[0]);
                            trans.Commit();
                            return "Success";
                        }
                    }catch(Exception ex)
                    {
                        trans.Rollback();
                        return "False InsertStockVolume";
                    }
                }
                //string strSql = @"INSERT INTO T_StockPriceByVolume(StockNO, Date, PriceByVolume,VolumeK) VALUES
                //            (@StockNO, @Date, @PriceByVolume, @VolumeK)";
                //conn.Execute(strSql, new
                //{
                //    StockNO = StockPriceByVolumes.StockNO,
                //    Date = StockPriceByVolumes.Date,
                //    PriceByVolume = StockPriceByVolumes.PriceByVolume,
                //    VolumeK = StockPriceByVolumes.VolumeK,
                //});
            }
        }
    }
}
