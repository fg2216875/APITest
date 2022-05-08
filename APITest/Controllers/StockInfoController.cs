using APITest.Interface;
using APITest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        //[HttpPost]
        //public void PER_DY_PBR(int ROCyear, int Month, string StockNO)
        //{
            
        //}
    }
}
