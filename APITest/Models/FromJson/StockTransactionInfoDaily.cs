using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAnalysis.Models.FromJson
{
    public class StockTransactionInfoDaily
    {
        public List<Datum> data { get; set; }
    }

    public class Orderbook
    {
        public string ask { get; set; }
        public int askVol { get; set; }
        public string bid { get; set; }
        public int bidVol { get; set; }
        public int askVolK { get; set; }
        public int bidVolK { get; set; }
    }
    public class Datum
    {
        public string ask { get; set; }
        public string bid { get; set; }
        public string change { get; set; }
        public string changePercent { get; set; }
        public string changeStatus { get; set; }
        public string exchange { get; set; }
        public string holdingType { get; set; }
        public bool limitDown { get; set; }
        public string limitDownPrice { get; set; }
        public bool limitUp { get; set; }
        public string limitUpPrice { get; set; }
        public string marketStatus { get; set; }
        public string messageBoardId { get; set; }
        public int previousVolume { get; set; }
        public decimal price { get; set; }
        public decimal regularMarketDayHigh { get; set; }
        public decimal regularMarketDayLow { get; set; }
        public decimal regularMarketOpen { get; set; }
        public string regularMarketPreviousClose { get; set; }
        public DateTime regularMarketTime { get; set; }
        public object relatedSymbol { get; set; }
        public object relatedSymbolName { get; set; }
        public string sectorId { get; set; }
        public string sectorName { get; set; }
        public string symbol { get; set; }
        public string symbolName { get; set; }
        public string systexId { get; set; }
        public string turnoverM { get; set; }
        public int volume { get; set; }
        public string avgPrice { get; set; }
        public int inMarket { get; set; }
        public int outMarket { get; set; }
        public List<Orderbook> orderbook { get; set; }
        public int previousVolumeK { get; set; }
        public int volumeK { get; set; }
        public int totalMarketVolK { get; set; }
        public string inMarketPercentage { get; set; }
        public string outMarketPercentage { get; set; }
        public int sumAskVolK { get; set; }
        public int sumBidVolK { get; set; }
    }
}
