using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Abstractions
{
    public interface IOrderCheckoutRepository
    {
        public IEnumerable<OrderCheckout> FindMany();
        public OrderCheckout? FindOne(Guid id);
        public IEnumerable<OrderCheckout> CreateOne(OrderCheckout newOrderCheckout);
        // public OrderCheckout UpdateStatus(string status , OrderCheckout updatedStatus);
        public OrderCheckout UpdateOne(Guid orderCheckoutId, OrderCheckout updatedCheckout);
        public IEnumerable<OrderCheckout>? DeleteOne(Guid orderCheckoutId);


    }
}