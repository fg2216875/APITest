using APITest.Interface;
using APITest.Models.FromJson;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockAnalysis.Dapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockTradeController : ControllerBase
    {
        private readonly IStockPriceByVolumeRepository _StockPriceByVolume;
        public StockTradeController(IStockPriceByVolumeRepository StockVolume)
        {
            _StockPriceByVolume = StockVolume;
        }

        [HttpPost]
        public async Task<IActionResult> CreateStockVolume(ToStockInfo StockVolumeTable)
        {
            try
            {
                var data = StockVolumeTable.StockVolumeTable.Select(x => new T_StockPriceByVolume
                {
                    Date = x.Date,
                    StockNO = x.StockNO,
                    PriceByVolume = x.PriceByVolume,
                    VolumeK = x.VolumeK,
                    CreateDate = DateTime.Now
                });
                var result = await _StockPriceByVolume.InsertStockVolume(data);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
