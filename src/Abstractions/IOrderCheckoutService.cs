using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Abstractions
{
    public interface IOrderCheckoutService
    {
        public IEnumerable<OrderCheckout> FindAll(Guid usersId);
        public OrderCheckout FindOne(Guid id);
        public OrderCheckout CreateOne(OrderCheckout newOrderCheckout);
        public OrderCheckout UpdateOne(string status , OrderCheckout orderCheckout);
        public OrderCheckout DeleteOne(Guid id);
    }
}