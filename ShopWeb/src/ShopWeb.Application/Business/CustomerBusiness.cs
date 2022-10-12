using MediatR;
using ShopWeb.Application.Interface;
using ShopWeb.Domain.Commands.Customer.Add;
using ShopWeb.Domain.Commands.Customer.Update;
using ShopWeb.Domain.Commands.Products.Update;
using ShopWeb.Domain.Common;
using ShopWeb.Domain.Queries.Customer.Get;
using ShopWeb.Domain.Queries.Customer.GetAll;
using ShopWeb.Domain.Queries.Product.Get;
using ShopWeb.Domain.Queries.Product.GetAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Application.Business
{
    public class CustomerBusiness : ICustomerBusiness
    {
        private readonly IMediator _mediator;
        public CustomerBusiness(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> AddAsync(AddCustomerCommand command)
        {
            var result = await _mediator.Send(command);
            return result == 1;
        }

        public async Task<bool> UpdateAsync(UpdateCustomerCommand command)
        {
            var result = await _mediator.Send(command);
            return result == 1;
        }

        public async Task<IList<CustomerCommon>> GetAllAsync()
        {
            var result = await _mediator.Send(new GetAllCustomersQuery());
            return result;
        }

        public async Task<CustomerCommon> GetAsync(Guid id)
        {
            var result = await _mediator.Send(new GetCustomerQuery { Id = id });
            return result;
        }
    }
}
