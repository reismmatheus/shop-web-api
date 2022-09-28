using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopWeb.Application.Interface;
using ShopWeb.Application.ViewModels;
using ShopWeb.Domain.Commands;

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

        [HttpPost("Get/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Get([FromBody] Guid id)
        {
            var result = await _productBusiness.Get(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Create([FromBody] ProductViewModel product)
        {
            var result = await _productBusiness.CreateAsync(product);
            return Ok(result);
        }
    }
}
