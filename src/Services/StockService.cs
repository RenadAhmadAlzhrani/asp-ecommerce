using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Services
{
    public class StockService : IStockService
    {
        private IStockRepository _stockRepository;

        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public IEnumerable<Stock> FindMany()
    {
        return _stockRepository.FindMany();
    }
    public IEnumerable<Stock> CreateOne(Stock stock)
    {
        return _stockRepository.CreateOne(stock);
    }

    public Stock? FindOne(Guid stockId)
    {
        return _stockRepository.FindOne(stockId);
    }

    public IEnumerable<Stock>? DeleteProduct(Guid stockId)
    {
        return _stockRepository.DeleteProduct(stockId);
    }

    public Stock UpdateOne(Guid stockId, Stock updatedStock)
    {
        return _stockRepository.UpdateOne(stockId, updatedStock);
    }
    }


}