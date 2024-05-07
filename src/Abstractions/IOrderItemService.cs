using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Entities;
using CodeCrafters_backend_teamwork.src.Service.cs;

namespace CodeCrafters_backend_teamwork.src.Abstrations
{
    public interface IOrderItemService
    {
        public IEnumerable<OrderItemReadDto> FindMany();
        public OrderItemReadDto? FindOne(Guid id);
        public OrderItemReadDto CreateOne(OrderItemReadDto OrderItem);
        public OrderItemReadDto? UpdateOne(Guid id, OrderItem orderItem);
    }
}