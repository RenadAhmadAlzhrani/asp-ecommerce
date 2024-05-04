using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CodeCrafters_backend_teamwork.src.Controllers
{
    public class StockController : CustomizedController
    {
        private IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public IEnumerable<Stock> FindMany()
        {
            return _stockService.FindMany();
        }
        [HttpGet("{stockId}")]
        public Stock? FindOne(Guid stockId)
        {
            return _stockService.FindOne(stockId);
        }
        [HttpPost]
        public IEnumerable<Stock> CreateOne([FromBody] Stock stock)
        {
            return _stockService.CreateOne(stock);


        }
        [HttpDelete("{stockId}")]
        public IEnumerable<Stock>? DeleteProduct([FromRoute] Guid stockId)
        {
            return _stockService.DeleteProduct(stockId);
        }
        [HttpPatch("{stockId}")]
        public Stock UpdateOne(Guid stockId, Stock updatedStock)
        {
            return _stockService.UpdateOne(stockId, updatedStock);
        }

    }
}