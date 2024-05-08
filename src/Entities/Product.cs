using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrafters_backend_teamwork.src.Entities;
public class Product
{
    public Guid Id { get; set; }
    [Required]
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public string? Image { get; set; }
    public double Price { get; set; }
    public List<Stock>? Stock { get; set; }
}
