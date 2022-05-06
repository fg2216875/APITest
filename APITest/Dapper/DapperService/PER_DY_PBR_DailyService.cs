using StockAnalysis.Dapper.Respotory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAnalysis.Dapper.DapperService
{
    public class PER_DY_PBR_DailyService
    {
        PER_DY_PBR_DailyRepository _PER_DY_PBR_DailyRespotory;

        public PER_DY_PBR_DailyService()
        {
            _PER_DY_PBR_DailyRespotory = new PER_DY_PBR_DailyRepository();
        }
        public PER_DY_PBR_DailyRepository PER_DY_PBR_Daily {
            get { return _PER_DY_PBR_DailyRespotory; }
            set {
                if(_PER_DY_PBR_DailyRespotory != null)
                {
                    _PER_DY_PBR_DailyRespotory = new PER_DY_PBR_DailyRepository();
                }

            }
        }
    }
}
