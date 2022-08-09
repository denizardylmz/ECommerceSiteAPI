using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories.ProductRep;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductWriteRepository _productWrite;

        public ProductController(IProductWriteRepository productWrite)
        {
            _productWrite = productWrite;
        }

        [HttpGet]
        public async void Get()
        {
            await _productWrite.AddRangeAsync(new List<Product>()
            {
                new Product()
                    { Id = Guid.NewGuid(), Name = "Product1", Price = 100, Stock = 100, CreatedDate = DateTime.UtcNow },
                new Product()
                    { Id = Guid.NewGuid(), Name = "Product2", Price = 200, Stock = 20, CreatedDate = DateTime.UtcNow },
                new Product()
                    { Id = Guid.NewGuid(), Name = "Product3", Price = 300, Stock = 10, CreatedDate = DateTime.UtcNow }
            });

            await _productWrite.SaveAsync();
        }
    }
}
