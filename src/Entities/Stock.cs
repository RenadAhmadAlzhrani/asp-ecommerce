using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrafters_backend_teamwork.src.Entities
{
    public class Stock
    {
        [Key, Required]
        public Guid Id { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        [MaxLength(10)]
        public string Size { get; set; }
        [Required, MaxLength(15)]
        public string Color { get; set; }
        [MaxLength(3)]
        public string? Discount { get; set; }

    }
}