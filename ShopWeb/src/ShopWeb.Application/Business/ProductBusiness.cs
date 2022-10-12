using AutoMapper;
using MediatR;
using ShopWeb.Application.Interface;
using ShopWeb.Domain.Commands.Products.Add;
using ShopWeb.Domain.Commands.Products.Update;
using ShopWeb.Domain.Common;
using ShopWeb.Domain.Interfaces;
using ShopWeb.Domain.Queries.Product.Get;
using ShopWeb.Domain.Queries.Product.GetAll;

namespace ShopWeb.Application.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IMediator _mediator;

        public ProductBusiness(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> AddAsync(AddProductCommand command)
        {
            var result = await _mediator.Send(command);
            return result == 1;
        }

        public async Task<bool> UpdateAsync(UpdateProductCommand command)
        {
            var result = await _mediator.Send(command);
            return result == 1;
        }

        public async Task<IList<ProductInventory>> GetAllAsync()
        {
            var result = await _mediator.Send(new GetAllProductsQuery());
            return result;
        }

        public async Task<ProductInventory> GetAsync(Guid id)
        {
            var result = await _mediator.Send(new GetProductQuery { Id = id});
            return result;
        }
    }
}
