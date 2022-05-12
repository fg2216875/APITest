using StockAnalysis.Dapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Models.FromJson
{
    public class ToStockPer
    {
        public IEnumerable<T_PerDyPbrDaily> Table { get; set; }
    }

    public class ToStockInfo
    {
        public IEnumerable<T_StockPriceByVolume> StockVolumeTable { get; set; }
    }
}
