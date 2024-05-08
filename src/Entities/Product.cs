using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrafters_backend_teamwork.src.Entities;
public class Product
{
    [Key, Required]
    public Guid Id { get; set; }
    [Required]
    public Guid CategoryId { get; set; }
    [MaxLength(50), Required]
    public string Name { get; set; }
     [MaxLength(700)]
    public string? Image { get; set; }
    [Required]
    public double Price { get; set; }
    public List<Stock>? Stock { get; set; }
}
