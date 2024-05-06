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
        private IEnumerable<OrderCheckout> _checkouts = [];

        public OrderCheckoutRepo()
        {
            _checkouts = new DatabaseContext().orderCheckouts;
        }

        public IEnumerable<OrderCheckout> CreateOne(OrderCheckout newOrderCheckout)
        {
           _checkouts =_checkouts.Append(newOrderCheckout);
            return _checkouts;
        }

         public OrderCheckout? FindOne(Guid orderCheckoutId)
        {
            return _checkouts.FirstOrDefault((orderCheckout) => orderCheckout.Id == orderCheckoutId);
        }

        public IEnumerable<OrderCheckout> FindMany()
        {
            return _checkouts;
        }

        public IEnumerable<OrderCheckout>? DeleteOne(Guid orderCheckoutId) 
        {

           _checkouts.Where((o) => o.Id != orderCheckoutId);
            return _checkouts;

        }


        public OrderCheckout UpdateOne(Guid orderCheckoutId, OrderCheckout updatedCheckout)
        {

            OrderCheckout? orderCheckout =_checkouts.FirstOrDefault(orderCheckout => orderCheckout.Id == orderCheckoutId);
            if (orderCheckout != null)
            {
                orderCheckout.Id = updatedCheckout.Id;
                return orderCheckout;
            }

            return updatedCheckout;

        }    
  }
}