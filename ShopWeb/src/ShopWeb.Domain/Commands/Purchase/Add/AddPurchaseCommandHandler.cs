using MediatR;
using ShopWeb.Domain.Commands.Customer.Add;
using ShopWeb.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Commands.Purchase.Add
{
    public class AddPurchaseCommandHandler : IRequestHandler<AddPurchaseCommand, int>
    {
        private readonly ICustomerRepository _customerRepository;
        public AddPurchaseCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<int> Handle(AddPurchaseCommand request, CancellationToken cancellationToken)
        {
            var customer = new Entity.Customer { Name = request.Name, Email = request.Email, BirthDate = request.BirthDate };
            await _customerRepository.AddAsync(customer);
            return 1;
        }
    }
}