using ShopWeb.Domain.Commands.Purchase.Add;
using ShopWeb.Domain.Commands.Purchase.AddWithProducts;
using ShopWeb.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Application.Interface
{
    public interface IPurchaseBusiness
    {
        Task<bool> AddAsync(AddPurchaseCommand command);
        Task<bool> AddWithProductsAsync(AddPurchaseWithProductsCommand command);
        Task<IList<ProductInventory>> GetAllAsync();
        Task<ProductInventory> GetAsync(Guid id);
    }
}
