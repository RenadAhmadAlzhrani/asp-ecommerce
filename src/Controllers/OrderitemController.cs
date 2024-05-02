using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeCrafters_backend_teamwork.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class OrderItemController : CustomizedController
    {


        IEnumerable<OrderItem> orderitem;




    [HttpGet]
    public IEnumerable<OrderItem> FindAll()
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
    public IEnumerable<OrderItem> DeleteAll(string id)
    {
        orderitem.Where(orderitem => orderitem.Id == id);
        return orderitem;
    }
    


    }
}

// rnd









