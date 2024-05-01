using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Entities;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Controllers;
using CodeCrafters_backend_teamwork.src.Databases;

namespace CodeCrafters_backend_teamwork.src.Services;

public class ProductService : IProductService
{
    private IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public IEnumerable<Product> FindMany()
    {
        return _productRepository.FindMany();
    }
    public IEnumerable<Product> CreateOne(Product product)
    {
        return _productRepository.CreateOne(product);
    }

    public Product? FindOne(Guid productId)
    {
        return _productRepository.FindOne(productId);
    }

    public IEnumerable<Product>? DeleteProduct(Guid productId)
    {
        return _productRepository.DeleteProduct(productId);
    }

    public Product UpdateOne(Guid productId, Product updatedProduct)
    {
        return _productRepository.UpdateOne(productId, updatedProduct);
    }
}
