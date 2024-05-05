using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrafters_backend_teamwork.src.Entities
{
    public class OrderItem
{
    public string Id { get; set; } 
    public string OrderCheckoutId { get; set; } 
    public string StockId { get; set; } 
    public int Quantity { get; set; }


    public OrderItem(Guid id, int orderCheckoutId, int stockId, int quantity)
    {
        Id = id;
        OrderCheckoutId = orderCheckoutId;
        StockId = stockId;
        Quantity = quantity;

    }

}
}