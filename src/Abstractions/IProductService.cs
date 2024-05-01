using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Abstractions;

public interface IProductService
{
    public IEnumerable<Product> FindMany();
    public IEnumerable<Product> CreateOne(Product product);
    public Product? FindOne(int productId);
    public IEnumerable<Product>? DeleteProduct(int productId);
    public Product UpdateOne(int productId, Product updatedProduct);
}
