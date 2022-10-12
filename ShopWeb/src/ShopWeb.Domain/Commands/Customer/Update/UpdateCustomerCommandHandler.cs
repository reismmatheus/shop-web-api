using MediatR;
using ShopWeb.Domain.Commands.Customer.Add;
using ShopWeb.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Commands.Customer.Update
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, int>
    {
        private readonly ICustomerRepository _customerRepository;
        public UpdateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<int> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Entity.Customer { Id = request.Id, Name = request.Name, Email = request.Email, BirthDate = request.BirthDate };
            await _customerRepository.UpdateAsync(customer);
            return 1;
        }
    }
}
