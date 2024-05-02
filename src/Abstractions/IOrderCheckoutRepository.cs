using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Abstractions
{
    public interface IOrderCheckoutRepository
    {
        public IEnumerable<OrderCheckout> FindALL(Guid userId);
        public OrderCheckout FindOne(Guid id);
        public OrderCheckout CreateOne(OrderCheckout newOrder);
    }
}