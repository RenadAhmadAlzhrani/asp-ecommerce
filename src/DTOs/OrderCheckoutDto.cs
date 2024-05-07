using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrafters_backend_teamwork.src.DTOs
{
    public class OrderCheckoutReadDto
    {
         public Guid Id {get ; set;}
        public int PaymentId {get ; set;}
        public int UsersId {get ; set;}
        public int ShippingId {get ; set;}
        public required string Status {get ; set;}
        public double TotalPrice {get ; set;}
    }


     public class OrderCheckoutUpdateDto
     {public Guid Id {get ; set;}
        public int PaymentId {get ; set;}
        public int UsersId {get ; set;}
        public int ShippingId {get ; set;}
        public required string Status {get ; set;}
        public double TotalPrice {get ; set;}}
}