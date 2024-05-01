using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.Entities;

namespace CodeCrafters_backend_teamwork.src.Repositories;

public class ProductRepository : IProductRepository
{
    private IEnumerable<Product> _products;

    public ProductRepository()
    {
        _products = new DatabaseContext().products;

    }
    public IEnumerable<Product> FindMany()
    {
        return _products;
    }
    public IEnumerable<Product> CreateOne(Product product)
    {
        _products = _products.Append(product);
        return _products;

    }
    public Product? FindOne(Guid productId)
    {
        Product? product = _products.FirstOrDefault(product => product.Id == productId);
        return product;
    }
    public IEnumerable<Product>? DeleteProduct(Guid productId)
    {
        Product? product = FindOne(productId);
        if (product != null)
        {
            var products = _products.Where((p) => p.Id != productId);
            _products = products;
            return _products;
        }
        return null;
    }
    public Product UpdateOne(Guid productId, Product updatedProduct)
    {

        Product? product = _products.FirstOrDefault(product => product.Id == productId);
        if (product != null)
        {
            product.Name = updatedProduct.Name;
            return product;
        }

        return updatedProduct;

    }
}
