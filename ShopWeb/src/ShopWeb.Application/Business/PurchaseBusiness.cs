using MediatR;
using ShopWeb.Application.Interface;
using ShopWeb.Domain.Commands.Purchase.Add;
using ShopWeb.Domain.Commands.Purchase.AddWithProducts;
using ShopWeb.Domain.Common;
using ShopWeb.Domain.Entity;
using ShopWeb.Domain.Queries.Product.Get;
using ShopWeb.Domain.Queries.Product.GetAll;
using ShopWeb.Domain.Queries.Purchase.GetAll;
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

        public async Task<IList<Purchase>> GetAllAsync()
        {
            var result = await _mediator.Send(new GetAllPurchaseQuery());
            return result;
        }

        public async Task<Purchase> GetAsync(Guid id)
        {
            return default;
            //var result = await _mediator.Send(new GetProductQuery { Id = id });
            //return result;
        }
    }
}
