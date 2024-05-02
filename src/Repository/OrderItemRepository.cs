// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using CodeCrafters_backend_teamwork.src.Controllers;
// using CodeCrafters_backend_teamwork.src.Databases;
// using CodeCrafters_backend_teamwork.src.Entities;
// using CodeCrafters_backend_teamwork.src.Service;

// namespace CodeCrafters_backend_teamwork.src.Repository
// {
//    public class OrderItemRepository : IOrderItemRepository
//     {
//         IEnumerable<OrderItem> Orderitem;

//         public OrderItemRepository()
//         {
//             orderitem = new DatabaseContext().OrderItem;

//         }
//         public IEnumerable<OrderItem> FindAll()
//         {
//             return orderitem;
//         }
//         public OrderItem FindOne(OrderItem orderitem)
//         {
//             return orderitem;
//         }
//         public OrderItem CreateOne(OrderItem orderitem)
//         {
//             return orderitem;
//         }
//         public OrderItem UpdateOne(OrderItem orderitem)
//         {
//             return orderitem;
//         }
//         public IEnumerable<OrderItem> DeleteAll(string id)
//     {
//         orderitem.Where(orderitem => orderitem.Id == id);
//         return orderItem;
//     }

//         public List<OrderItem> FindAll(OrderItem orderItem)
//         {
//             throw new NotImplementedException();
//         }

//         OrderItem IOrderItemRepository.DeleteAll(string id)
//         {
//             throw new NotImplementedException();
//         }
//     } }
//     // rnd