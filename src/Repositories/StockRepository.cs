using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Entities;
using CodeCrafters_backend_teamwork.src.Databases;

namespace CodeCrafters_backend_teamwork.src.Repositories
{
    public class StockRepository : IStockRepository
    {
        private IEnumerable<Stock> _stocks;

        public StockRepository()
        {
            _stocks = new DatabaseContext().stocks;

        }
        public IEnumerable<Stock> FindMany()
        {
            return _stocks;
        }
        public IEnumerable<Stock> CreateOne(Stock stock)
        {
            _stocks = _stocks.Append(stock);
            return _stocks;

        }
        public Stock? FindOne(Guid stockId) //doesn't work
        {
            Stock? stock = _stocks.FirstOrDefault(stock => stock.Id == stockId);
            return stock;

            //  Stock? stock = _stocks.FirstOrDefault(stock => stock.Id.Equals(stockId));
            //     return stock;
        }
        public IEnumerable<Stock>? DeleteProduct(Guid stockId) // also 
        {
            Stock? stock = FindOne(stockId);
            if (stock != null)
            {
                var stocks = _stocks.Where((s) => s.Id != stockId);
                //var stocks = _stocks.Where((s) => !s.Id.Equals(stockId));
                _stocks = stocks;
                return _stocks;
            }
            return null;
        }
        public Stock UpdateOne(Guid stockId, Stock updatedStock)
        {

            Stock? stock = _stocks.FirstOrDefault(stock => stock.Id == stockId);
            if (stock != null)
            {
                stock.Id = updatedStock.Id;
                return stock;
            }

            return updatedStock;

        }
    }
}