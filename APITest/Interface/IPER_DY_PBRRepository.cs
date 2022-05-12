using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Interface
{
    public interface IPER_DY_PBRRepository
    {
        public Task<string> Insert(string StockInfoDaily);
    }
}
