using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Controllers;
using CodeCrafters_backend_teamwork.src.Entities;
using CodeCrafters_backend_teamwork.src.Service;

namespace CodeCrafters_backend_teamwork.src.Repository
{
   public class OrderItemRepository : IOrderItemRepository
    {

    private IEnumerable<OrderItem> _orderItems { get; set; }

    public OrderItemRepository()
    {
        _orderItems = new DatabaseContext().OrderItems;
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
        _orderItems.Append(orderItem);
        return orderItem;
    }

    public OrderItem UpdateOne(OrderItem updatedOrderItem)
    {
        var orderItems = _orderItems.Select(orderItem =>
        {
            if (orderItem.Id == updatedOrderItem.Id)

            {
                return updatedOrderItem;
            }
            return orderItem;
        });
        _orderItems = orderItems;
        return updatedOrderItem;


    }

    public bool DeleteOne(Guid id)
    {
        OrderItem? orderItem = FindOne(id);
        if (orderItem is null) return false;

        var orderItems = _orderItems.Where(orderItem => orderItem.Id != id);
        _orderItems = orderItems;
        return true;

    }



}}
