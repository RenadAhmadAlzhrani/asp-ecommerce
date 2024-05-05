using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrafters_backend_teamwork.src.Entities
{
    public class Stock
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string? Discount { get; }  
    

        public Stock(string size, string color, string discount)
        {
            Id = Guid.NewGuid();
            ProductId = Guid.NewGuid();
            Size = size;
            Color = color;
            Discount = discount;
        }
    }
}