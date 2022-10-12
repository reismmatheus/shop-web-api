using MediatR;
using ShopWeb.Domain.Common;
using ShopWeb.Domain.Interfaces;
using ShopWeb.Domain.Queries.Product.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Queries.Customer.Get
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, CustomerCommon>
    {
        private readonly ICustomerRepository _customerRepository;
        public GetCustomerQueryHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerCommon> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(request.Id);
            var result = new CustomerCommon
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                BirthDate = customer.BirthDate
            };
            return result;
        }
    }
}