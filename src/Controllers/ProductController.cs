using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeCrafters_backend_teamwork.src.Abstractions;
using CodeCrafters_backend_teamwork.src.Databases;
using CodeCrafters_backend_teamwork.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeCrafters_backend_teamwork.src.Controllers;

public class ProductController : CustomizedController
{
    private IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IEnumerable<Product> FindMany()
    {
        return _productService.FindMany();
    }
    [HttpGet("{productId}")]
    public Product? FindOne(Guid productId)
    {
        return _productService.FindOne(productId);
    }
    [HttpPost]
    public IEnumerable<Product> CreateOne([FromBody] Product product)
    {
        return _productService.CreateOne(product);


    }
    [HttpDelete("{productId}")]
    public IEnumerable<Product>? DeleteProduct([FromRoute] Guid productId)
    {
        return _productService.DeleteProduct(productId);
    }
    [HttpPatch("{productId}")]
    public Product UpdateOne(Guid productId, Product updatedProduct)
    {
        return _productService.UpdateOne(productId, updatedProduct);
    }


}
