using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Controllers;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.Entities;
using CodeCrafters_backend_teamwork.src.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CodeCrafters_backend_teamwork.src.Repository
{
    public class OrderItemRepository : IOrderItemRepository
    {

        private DbSet<OrderItem> _orderItems { get; set; }
        private DatabaseContext _databaseContext;

        public OrderItemRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _orderItems = databaseContext.OrderItems;
        }

        public IEnumerable<OrderItem> FindMany()
        {
            return _orderItems;
        }
        public OrderItem? FindOne(Guid id)
        {
            OrderItem? orderItem = _orderItems.FirstOrDefault(orderItem => orderItem.Id == id);
            if (orderItem is not null)
            {
                return orderItem;
            }

            else return null;
        }

        public OrderItem CreateOne(OrderItem orderItem)
        {
            _orderItems.Add(orderItem);
            _databaseContext.SaveChanges();
            return orderItem;
        }

        public OrderItem? UpdateOne(OrderItem updatedOrderItem)
        {
            // var orderItems = _orderItems.Select(orderItem =>
            // {
            //     if (orderItem.Id == updatedOrderItem.Id)

            //     {
            //         return updatedOrderItem;
            //     }
            //     return orderItem;
            // });
            // _orderItems = orderItems;
            // return updatedOrderItem;
            return null;
        }

        public bool DeleteOne(Guid id)
        {
            OrderItem? orderItem = FindOne(id);
            if (orderItem is null) return false;

            _orderItems.Remove(orderItem);
            _databaseContext.SaveChanges();
            return true;

        }

    }
}
