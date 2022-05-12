using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockAnalysis.Dapper.ViewModels
{
    public class T_StockPriceByVolume
    {
        [Key]
        public int StockPriceByVolumeID { get; set; }
        public string StockNO { get; set; }
        public DateTime? Date { get; set; }
        public decimal? PriceByVolume { get; set; }
        public int? VolumeK { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }
    }
}
