// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using CodeCrafters_backend_teamwork.src.Controllers;
// using CodeCrafters_backend_teamwork.src.Entities;

// namespace CodeCrafters_backend_teamwork.src.Service;

public interface IOrderItemRepository
{


    public IEnumerable<OrderItem> FindMany();
    public OrderItem? FindOne(Guid id);
    public OrderItem CreateOne(OrderItem orderItem);
    public OrderItem UpdateOne(OrderItem updatedOrderItem);
    public OrderItem DeleteAll(string id);
    bool DeleteOne(Guid id);
}


//  }