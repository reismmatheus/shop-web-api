using MediatR;
using ShopWeb.Application.Interface;
using ShopWeb.Domain.Commands.Purchase.Add;
using ShopWeb.Domain.Commands.Purchase.AddWithProducts;
using ShopWeb.Domain.Common;
using ShopWeb.Domain.Queries.Product.Get;
using ShopWeb.Domain.Queries.Product.GetAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Application.Business
{
    public class PurchaseBusiness : IPurchaseBusiness
    {
        private readonly IMediator _mediator;
        public PurchaseBusiness(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> AddAsync(AddPurchaseCommand command)
        {
            var result = await _mediator.Send(command);
            return result == 1;
        }

        public async Task<bool> AddWithProductsAsync(AddPurchaseWithProductsCommand command)
        {
            var result = await _mediator.Send(command);
            return result == 1;
        }

        //public async Task<IList<ProductInventory>> GetAllAsync()
        //{
        //    var result = await _mediator.Send(new GetAllProductsQuery());
        //    return result;
        //}

        //public async Task<ProductInventory> GetAsync(Guid id)
        //{
        //    var result = await _mediator.Send(new GetProductQuery { Id = id });
        //    return result;
        //}
    }
}
