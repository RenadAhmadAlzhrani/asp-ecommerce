using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrafters_backend_teamwork.src.Abstrations
{
    public interface IOrderItemService 
    {

    public IEnumerable<OrderItemReadDto> FindMany();
     var orderItems = _orderItemRepository.FindMany();
    public OrderItemReadDto? FindOne (Guid id); 
    OrderItem ? orderItem =_orderItemRepository.FindOne(id);
    public OrderItemReadDto CreateOne(OrderItemReadDto OrderItem);
    public OrderItemReadDto? UpdateOne(Guid id, OrderItem orderItem);
    var updatOrderItem = _orderItemRepository.FindOne(id);

    }
}