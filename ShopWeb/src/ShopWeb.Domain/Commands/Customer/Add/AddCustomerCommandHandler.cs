using MediatR;
using ShopWeb.Domain.Commands.Products.Add;
using ShopWeb.Domain.Entity;
using ShopWeb.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Commands.Customer.Add
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, int>
    {
        private readonly ICustomerRepository _customerRepository;
        public AddCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<int> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Entity.Customer { Name = request.Name, Email = request.Email, BirthDate = request.BirthDate };
            await _customerRepository.AddAsync(customer);
            return 1;
        }
    }
}
