using Microsoft.AspNetCore.Mvc;
using ShopWeb.Application.Interface;
using ShopWeb.Domain.Commands.Products.Add;
using ShopWeb.Domain.Commands.Products.Update;

namespace ShopWeb.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductBusiness _productBusiness;
        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductCommand command)
        {
            var products = await _productBusiness.AddAsync(command);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Add(Guid id, UpdateProductCommand command)
        {
            var products = await _productBusiness.UpdateAsync(command);
            return Ok();
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productBusiness.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var product = await _productBusiness.GetAsync(id);
            return Ok(product);
        }
    }
}
