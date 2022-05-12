using StockAnalysis.Dapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Interface
{
    public interface IStockPriceByVolumeRepository
    {
        public Task<string> InsertStockVolume(IEnumerable<T_StockPriceByVolume> data);
    }
}
