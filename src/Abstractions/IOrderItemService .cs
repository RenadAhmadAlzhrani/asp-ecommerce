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
        public OrderItemReadDto? FindOne(Guid orderItemId);
        public OrderItemReadDto CreateOne(OrderItemReadDto orderItem);
        public OrderItemReadDto? UpdateOne(Guid orderItemId, OrderItem orderItem);
    }
}