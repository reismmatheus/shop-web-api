using MediatR;
using ShopWeb.Domain.Common;

namespace ShopWeb.Domain.Queries.Customer.Get
{
    public class GetCustomerQuery : IRequest<CustomerCommon>
    {
        public Guid Id { get; set; }
    }
}
