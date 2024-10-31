
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class ProductsController : ODataController
{
    private static readonly List<Product> Products = new List<Product>
    {
        new Product { Id = 1, Name = "Product A", Price = 10.0m },
        new Product { Id = 2, Name = "Product B", Price = 20.0m },
        new Product { Id = 3, Name = "Product C", Price = 30.0m }
    };

    [EnableQuery]
    public IActionResult Get()
    {
        return Ok(Products.AsQueryable());
    }

    [EnableQuery]
    public IActionResult Get(int key)
    {
        var product = Products.FirstOrDefault(p => p.Id == key);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }
}
