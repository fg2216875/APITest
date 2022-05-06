using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAnalysis.Models.FromJson
{
    public class PriceByVolumeInfo
    {
        public PriceInfo data { get; set; }
    }

    public class PriceInfo
    {
        public DateTime date { get; set; }
        public object support { get; set; }
        public object resistance { get; set; }
        public List<PriceByVolume> priceByVolumes { get; set; }
        public Pagination pagination { get; set; }
    }

    public class Pagination
    {
        public int resultsTotal { get; set; }
        public object nextOffset { get; set; }
    }

    public class PriceByVolume
    {
        public decimal price { get; set; }
        public object priceFrom { get; set; }
        public object priceTo { get; set; }
        public int volumeK { get; set; }

    }
 
}
