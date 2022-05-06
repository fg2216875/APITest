using Dapper;
using Microsoft.Data.SqlClient;
using StockAnalysis.Dapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAnalysis.Dapper.Respotory
{
    public class StockPriceByVolumeRepository
    {
        //public void Insert(T_StockPriceByVolume StockPriceByVolumes)
        //{
        //    using (SqlConnection conn = new SqlConnection(DBConnection.ConnectionStr))
        //    {
        //        string strSql = @"INSERT INTO T_StockPriceByVolume(StockNO, Date, PriceByVolume,VolumeK) VALUES
        //                    (@StockNO, @Date, @PriceByVolume, @VolumeK)";
        //        conn.Execute(strSql, new
        //        {
        //            StockNO = StockPriceByVolumes.StockNO,
        //            Date = StockPriceByVolumes.Date,
        //            PriceByVolume = StockPriceByVolumes.PriceByVolume,
        //            VolumeK = StockPriceByVolumes.VolumeK,
        //        });
        //    }
        //}
    }
}
