using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StockAnalysis.Dapper.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Models
{
    public class StockDbContext
    {
        private readonly IConfiguration _Configuration;
        private readonly string ConnectionString;
        public StockDbContext(IConfiguration configuration)
        {
            _Configuration = configuration;
            ConnectionString = configuration.GetConnectionString("DefaultConnectionString");
        }
        public IDbConnection CreatConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
