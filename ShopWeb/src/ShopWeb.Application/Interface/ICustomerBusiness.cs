using ShopWeb.Domain.Commands.Customer.Add;
using ShopWeb.Domain.Commands.Customer.Update;
using ShopWeb.Domain.Commands.Products.Add;
using ShopWeb.Domain.Commands.Products.Update;
using ShopWeb.Domain.Common;
using ShopWeb.Domain.Queries.Product.Get;
using ShopWeb.Domain.Queries.Product.GetAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Application.Interface
{
    public interface ICustomerBusiness
    {
        Task<bool> AddAsync(AddCustomerCommand command);
        Task<bool> UpdateAsync(UpdateCustomerCommand command);
        Task<IList<CustomerCommon>> GetAllAsync();
        Task<CustomerCommon> GetAsync(Guid id);
    }
}
