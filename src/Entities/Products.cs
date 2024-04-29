using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrafters_backend_teamwork.src.Entities;
public class Product
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }

    public string Image { get; set; }
    public double Price { get; set; }

    public Product(int id, int categoryId, string name, string image, double price)
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        Image = image;
        Price = price;
    }
}
