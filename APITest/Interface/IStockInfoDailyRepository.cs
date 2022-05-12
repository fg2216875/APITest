using StockAnalysis.Dapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Interface
{
    public interface IStockInfoDailyRepository
    {
        public Task<IEnumerable<T_StockInfoDaily>> GetAll();

        public Task<string> Insert(IEnumerable<T_PerDyPbrDaily> StockInfoDaily);

        public Task<string> InsertStockDaily(T_StockInfoDaily data);
    }
}
