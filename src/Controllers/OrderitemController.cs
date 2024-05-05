using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeCrafters_backend_teamwork.src.Controllers
{

    public class OrderItemController : CustomizeeController 

    {


        IEnumerable<OrderItem> orderitem;




    [HttpGet]
    public IEnumerable<OrderItem> FindMany()
    {
        return orderitem;
    }
    [HttpGet("{OrderItemId}")]
     public ActionResult<OrderItemReadDto> FindOne(string id)
    {
        return Ok(_orderItemService.FindOne(id));
    }

    [HttpPost]

    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<OrderItemReadDto> CreateOne([FromBody] OrderItemReadDto orderItem)
    {


        if (orderItem is not null)
        {
            var createdOrderItem = _orderItemService.CreateOne(orderItem);
            return CreatedAtAction(nameof(CreateOne), createdOrderItem);
        }
        return BadRequest();
    }

     [HttpPatch("{OrderItemId}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<OrderItemReadDto> UpdateOne(string id, [FromBody] OrderItem orderitem)
    {

        OrderItemReadDto? updatedOrderItem = _orderItemService.UpdateOne(id, orderitem);
        if (updatedOrderItem is not null)
        {
            return CreatedAtAction(nameof(UpdateOne), updatedOrderItem);
        }
        else return BadRequest();
    }

    [HttpDelete("{OrderItemId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult DeleteOne(string id)
    {
        bool isDeleted = _orderItemService.DeleteOne(id);
        if (!isDeleted)
        {
            return NotFound();
        }
        return NoContent();

    }
        }    }









