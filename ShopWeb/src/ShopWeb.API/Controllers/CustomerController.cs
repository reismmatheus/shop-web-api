using Microsoft.AspNetCore.Mvc;
using ShopWeb.Application.Interface;
using ShopWeb.Domain.Commands.Customer.Add;
using ShopWeb.Domain.Commands.Customer.Update;
using ShopWeb.Domain.Commands.Products.Update;
using ShopWeb.Domain.Entity;

namespace ShopWeb.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerBusiness _customerBusiness;
        public CustomerController(ICustomerBusiness customerBusiness)
        {
            _customerBusiness = customerBusiness;
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCustomerCommand command)
        {
            var customer = await _customerBusiness.AddAsync(command);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateCustomerCommand command)
        {
            var customer = await _customerBusiness.UpdateAsync(command);
            return Ok();
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _customerBusiness.GetAllAsync();
            return Ok(customers);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var customer = await _customerBusiness.GetAsync(id);
            return Ok(customer);
        }
    }
}
