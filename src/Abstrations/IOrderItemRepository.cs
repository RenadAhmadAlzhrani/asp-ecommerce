using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Controllers;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Service;
 
 public interface IOrderItemRepository
 {
public List<OrderItem>FindAll(OrderItem orderItem);
public OrderItem FindOne(OrderItem orderItem);
public OrderItem CreateOne(OrderItem orderItem);
public OrderItem UpdateOne(OrderItem orderItem);
public OrderItem DeleteAll(string id);
// rnd
 
 }