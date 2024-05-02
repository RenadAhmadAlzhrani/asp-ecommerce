using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeCrafters_backend_teamwork.src.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderCheckoutController  
    {
        private IOrderCheckoutService _orderCheckoutService;
        public OrderCheckoutController (IOrderCheckoutService orderCheckoutService)
        {
            _orderCheckoutService = orderCheckoutService ;
        }

        [HttpGet]
        public IEnumerable<OrderCheckout> FindAll([FromQuery] Guid usersId )
        
        {
            return _orderCheckoutService.FindAll(usersId);
        }

        [HttpGet("{id}")]
        public OrderCheckout FindOne(Guid id)
        {
            return _orderCheckoutService.FindOne(id);
        }

        [HttpPost]
        public OrderCheckout CreateOne([FromBody] OrderCheckout newOrderCheckout)
        {
            return _orderCheckoutService.CreateOne(newOrderCheckout);
        }

    }
}