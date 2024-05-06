using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Services
{
 public class OrderCheckoutService
    {
        private IOrderCheckoutRepository _orderCheckoutRepo;

        public OrderCheckoutService(IOrderCheckoutRepository orderCheckoutRepository)
        {
            _orderCheckoutRepo = orderCheckoutRepository;
        }

        public IEnumerable<OrderCheckout> CreateOne(OrderCheckout newOrderCheckout)
        {
            return _orderCheckoutRepo.CreateOne(newOrderCheckout);
        }

        public IEnumerable<OrderCheckout> FindMany()
        {
            return _orderCheckoutRepo.FindMany();
        }


        public OrderCheckout? FindOne(Guid orderCheckoutId)
        {
            return _orderCheckoutRepo.FindOne(orderCheckoutId);
        }


        public OrderCheckout UpdateOne(Guid orderCheckoutId, OrderCheckout updatedCheckout)
        {
            return _orderCheckoutRepo.UpdateOne(orderCheckoutId, updatedCheckout);
        }

        public IEnumerable<OrderCheckout>? DeleteOne(Guid orderCheckoutId)
        {
            return _orderCheckoutRepo.DeleteOne(orderCheckoutId);
        }
    }
}