
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeCrafters_backend_teamwork.src.Controllers
{
    public class OrderItemController : CustomizedController
    {

        public IEnumerable<OrderItem> orderitem;
        [HttpGet]
        public IEnumerable<OrderItem> FindMany()
        {
            return orderitem;
        }
        [HttpGet("{OrderItemId}")]
        public OrderItem FindOne(OrderItem orderitem)
        {
            return orderitem;
        }
        [HttpPost]
        public OrderItem CreateOne(OrderItem orderitem)

        {
            return orderitem;
        }
        [HttpPatch]
        public OrderItem UpdateOne(OrderItem orderitem)
        {
            return orderitem;
        }
        [HttpDelete]
        public IEnumerable<OrderItem> DeleteAll(Guid id)
        {
            orderitem.Where(orderitem => orderitem.Id == id);
            return orderitem;
        }

    }
}