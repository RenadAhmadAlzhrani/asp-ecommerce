using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrafters_backend_teamwork.src.Entities;
public class Product
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public string Name { get; set; }

    public string Image { get; set; }
    public double Price { get; set; }

    public Product(string name, string image, double price)
    {
        Id = Guid.NewGuid();
        CategoryId = Guid.NewGuid();
        Name = name;
        Image = image;
        Price = price;
    }
}
