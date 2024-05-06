using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrafters_backend_teamwork.src.Entities
{
    public class Stock
    {
        public Guid Id { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string? Discount { get; }  
    
    }
}