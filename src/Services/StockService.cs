using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.DTOs;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Services
{
    public class StockService : IStockService
    {
        private IStockRepository _stockRepository;
        private readonly IMapper _mapper;

        public StockService(IStockRepository stockRepository, IMapper mapper)
        {
            _stockRepository = stockRepository;
            _mapper=mapper;
        }

        public IEnumerable<StockReadDto> FindMany()
    {
        IEnumerable<Stock> Stocks = _stockRepository.FindMany();
        return Stocks.Select(_mapper.Map<StockReadDto>);
    }
    public StockReadDto CreateOne(StockCreateDto newStock)
    {
        Stock stock = _mapper.Map<Stock>(newStock);
         _stockRepository.CreateOne(stock);
         return _mapper.Map<StockReadDto>(stock);
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