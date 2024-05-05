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
    public Product? FindOne(Guid productId);
    public IEnumerable<Product>? DeleteProduct(Guid productId);
    public Product UpdateOne(Guid productId, Product updatedProduct);
}
