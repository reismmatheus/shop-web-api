using Microsoft.AspNetCore.Mvc;
using ShopWeb.Application.Business;
using ShopWeb.Application.Interface;
using ShopWeb.Domain.Commands.Customer.Add;
using ShopWeb.Domain.Commands.Purchase.Add;
using ShopWeb.Domain.Commands.Purchase.AddWithProducts;
using ShopWeb.Domain.Entity;

namespace ShopWeb.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PurchaseController : Controller
    {
        private readonly IPurchaseBusiness _purchaseBusiness;
        public PurchaseController(IPurchaseBusiness purchaseBusiness)
        {
            _purchaseBusiness = purchaseBusiness;
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddPurchaseCommand command)
        {
            var purchase = await _purchaseBusiness.AddAsync(command);
            return Ok();
        }

        [HttpPost("Products")]
        public async Task<IActionResult> AddWithProduct(AddPurchaseWithProductsCommand command)
        {
            var purchase = await _purchaseBusiness.AddWithProductsAsync(command);
            return Ok();
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var purchases = await _purchaseBusiness.GetAllAsync();
            return Ok(purchases);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var purchase = await _purchaseBusiness.GetAsync(id);
            return Ok(purchase);
        }
    }
}
