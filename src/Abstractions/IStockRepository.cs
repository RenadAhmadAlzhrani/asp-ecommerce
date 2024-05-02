using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Abstractions
{
    public interface IStockRepository
    {
        public IEnumerable<Stock> FindMany();
        public IEnumerable<Stock> CreateOne(Stock stock);
        public Stock? FindOne(Guid stockId);
        public IEnumerable<Stock>? DeleteProduct(Guid stockId);
        public Stock UpdateOne(Guid stockId, Stock updatedStock);
    }
}