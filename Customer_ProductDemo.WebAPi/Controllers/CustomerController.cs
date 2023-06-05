using Customer_ProductDemo.Domain.Entities;
using Customer_ProductDemo.ServiceContract.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Customer_ProductDemo.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public CustomerController(IServiceManager service)
        {
            _serviceManager = service;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllCustomer()
        {
            var customers = await _serviceManager.CustomerService.GetAllCustomerAsync(trackChanges: false);

            return Ok(customers);
        }
    }
}
