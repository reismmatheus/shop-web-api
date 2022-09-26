using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopWeb.Application.CommandQuery.Product.Command;

namespace ShopWeb.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Create")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult Create([FromBody] CreateProductCommand command)
        {
            _mediator.Send(command);
            return NoContent();
        }
    }
}
