using Microsoft.AspNetCore.Mvc;
using src.store.domain.entities;

namespace src.store.application.controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController
{
    [HttpGet]
    public Product GetProduct()
    {
        var product = new Product("Camisa", "Camisa de rua", [], [],
            [], 200);
        return product;
    }
}