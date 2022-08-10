using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories.CustomerRep;
using ETicaretAPI.Application.Repositories.OrderRep;
using ETicaretAPI.Application.Repositories.ProductRep;
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

        private readonly ICustomerReadRepository _customerRead;
        
        private readonly IOrderWriteRepository _orderWrite;
        private readonly IOrderReadRepository _orderRead;
        
        public TestController(
            IOrderWriteRepository orderWrite, 
            IOrderReadRepository orderRead, 
            IProductReadRepository productRead, 
            ICustomerReadRepository customerRead)
        {
            _orderWrite = orderWrite;
            _orderRead = orderRead;
            _productRead = productRead;
            _customerRead = customerRead;
        }

        [HttpGet]
        public async Task Get()
        {
            var order =  await _orderRead.GetByIdAsync("c19b0934-3db5-4934-a2ca-837484ee22ce");

            order.Address = "Bursa";

            await _orderWrite.SaveAsync();
            
            Console.WriteLine();
        }
    }
}
