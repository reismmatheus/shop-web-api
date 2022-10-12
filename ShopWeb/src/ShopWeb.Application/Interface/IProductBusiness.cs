using ShopWeb.Domain.Commands.Products.Add;
using ShopWeb.Domain.Commands.Products.Update;
using ShopWeb.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Application.Interface
{
    public interface IProductBusiness
    {
        Task<bool> AddAsync(AddProductCommand command);
        Task<bool> UpdateAsync(UpdateProductCommand command);
        Task<IList<ProductInventory>> GetAllAsync();
        Task<ProductInventory> GetAsync(Guid id);
    }
}
