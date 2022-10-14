﻿using Microsoft.AspNetCore.Mvc;
using ShopWeb.Application.Interface;
using ShopWeb.Domain.Commands.Customer.Add;
using ShopWeb.Domain.Commands.Purchase.Add;

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
            var customer = await _purchaseBusiness.AddAsync(command);
            return Ok();
        }
    }
}
