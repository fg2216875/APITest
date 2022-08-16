using APITest.Interface;
using APITest.Models;
using APITest.Models.FromJson;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StockAnalysis.Dapper.DapperService;
using StockAnalysis.Dapper.Respotory;
using StockAnalysis.Dapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockInfoController : ControllerBase
    {
        private readonly IStockInfoDailyRepository _StockInfoDailyRepository;
        public StockInfoController(IStockInfoDailyRepository StockInfo)
        {
            _StockInfoDailyRepository = StockInfo;
        }

        [HttpGet]
        public async Task<IActionResult> GetTest()
        {
            try
            {
                var result = await _StockInfoDailyRepository.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{StockNO}/Info")]
        public async Task<IActionResult> GetStockInfo(string StockNO)
        {
            try
            {
                var result = await _StockInfoDailyRepository.GetStockInfo(StockNO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateStockInfo([FromBody] ToStockPer data)
        {
            try
            {
                var result = await _StockInfoDailyRepository.Insert(data.Table);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("Daily")]
        public async Task<IActionResult> CreateStockDaily([FromBody] T_StockInfoDaily data)
        {
            try
            {
                data.CreateDate = DateTime.Now;
                var result = await _StockInfoDailyRepository.InsertStockDaily(data);
                return Ok(result);
            }catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        //[HttpPost]
        //public void PER_DY_PBR(int ROCyear, int Month, string StockNO)
        //{
        //    StockInfoService _StockInfoService = new StockInfoService();
        //    PER_DY_PBR_DailyService _PER_DY_PBR_DailyService = new PER_DY_PBR_DailyService();
        //    List<T_PerDyPbrDaily> T_PerDyPbrDailyList = new List<T_PerDyPbrDaily>();

        //    string DateFormat = ROCyear.ToString() + Month.ToString("#00") + "01";
        //    DateTime Date = DateTime.ParseExact(DateFormat, "yyyyMMdd", null, System.Globalization.DateTimeStyles.AllowWhiteSpaces);
        //    var StockInfo = _StockInfoService.GetStockInfoAsync(StockNO, Date);

        //    T_PerDyPbrDailyList = StockInfo.Select(x => new T_PerDyPbrDaily
        //    {
        //        StockNO = StockNO,
        //        Date = _StockInfoService.TransferToDate(x.Date),
        //        DividendYield = x.DividendYield,
        //        PriceEarningsRatio = x.PriceEarningsRatio,
        //        PriceBookRatio = x.PriceBookRatio,
        //        FinancialReportYearQuarter = x.FinancialReportYearQuarter.AddYears(1911)
        //    }).ToList();
        //}
    }
}
