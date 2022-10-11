using Microsoft.AspNetCore.Mvc;
using ShopWeb.Application.Interface;

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
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var products = _productBusiness.GetAllAsync();
            return Ok(products);
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get(Guid id)
        {
            var product = _productBusiness.GetAsync(id);
            return Ok(product);
        }
    }
}
