using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories.CustomerRep;
using ETicaretAPI.Application.Repositories.OrderRep;
using ETicaretAPI.Application.Repositories.ProductRep;
using ETicaretAPI.Application.ViewModels.Products;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IProductReadRepository _productRead;
        private readonly IProductWriteRepository _productWrite;
        
        public TestController(IProductReadRepository productRead,
            IProductWriteRepository productWrite)
        {
            _productRead = productRead;
            _productWrite = productWrite;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_productRead.GetAll(false));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _productRead.GetByIdAsync(id, false));
        }


        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Product model) //Normally, We dont use entity while getting request.
        {
            await _productWrite.AddAsync(new Product()
            {
                Name = model.Name,
                Price = model.Price,
                Stock = model.Stock
            });
            await _productWrite.SaveAsync();
            return Ok(StatusCode((int)HttpStatusCode.Created));
        }


        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Product model)
        {
            Product product = await _productRead.GetByIdAsync(model.Id);
            product.Stock = model.Stock;
            product.Name = model.Name;
            product.Price = model.Price;
            await _productWrite.SaveAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _productWrite.RemoveAsync(id);
            await _productWrite.SaveAsync();

            return Ok();
        }
    }
}
