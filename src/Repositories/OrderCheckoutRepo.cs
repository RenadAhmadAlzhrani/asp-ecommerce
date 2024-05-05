using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Reository
{
    public class OrderCheckoutRepo : IOrderCheckoutRepository
    {
        private IEnumerable<OrderCheckout> _orderCheckout;
        public IEnumerable<OrderCheckout> CreateOne()
        {
            _orderCheckout = new DatabaseContext().orderCheckout;  //i need to contain
        }

        public IEnumerable<OrderCheckout> FindMany()
        {
            return _orderCheckout;
        }

        public OrderCheckout FindOne(Guid orderCheckoutId)
        {
            OrderCheckout orderCheckout = _orderCheckout.FirstOrDefault(orderCheckout => orderCheckout.Id ==orderCheckoutId);
        }
    }
}