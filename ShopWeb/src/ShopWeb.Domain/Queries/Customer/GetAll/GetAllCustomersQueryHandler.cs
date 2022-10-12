using MediatR;
using ShopWeb.Domain.Common;
using ShopWeb.Domain.Interfaces;

namespace ShopWeb.Domain.Queries.Customer.GetAll
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, IList<CustomerCommon>>
    {
        private readonly ICustomerRepository _customerRepository;
        public GetAllCustomersQueryHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<IList<CustomerCommon>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            var result = new List<CustomerCommon>();
            var customers = await _customerRepository.GetAllAsync();
            foreach (var item in customers)
            {
                result.Add(new CustomerCommon
                {
                    Id = item.Id,
                    Name = item.Name,
                    Email = item.Email,
                    BirthDate = item.BirthDate
                });
            }
            return result;
        }
    }
}
