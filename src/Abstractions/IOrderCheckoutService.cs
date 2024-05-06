using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Abstractions
{
    public interface IOrderCheckoutService
    {
        public IEnumerable<OrderCheckout> FindMany();
        public OrderCheckout? FindOne(Guid orderCheckoutId);
        public IEnumerable<OrderCheckout> CreateOne(OrderCheckout newOrderCheckout);
        public OrderCheckout UpdateOne(Guid ordercheckoutId, OrderCheckout updateOrdercheckout);
        public IEnumerable<OrderCheckout>? DeleteOne(Guid orderCheckoutId);
    }
}