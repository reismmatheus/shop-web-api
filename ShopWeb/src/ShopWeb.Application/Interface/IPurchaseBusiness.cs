using ShopWeb.Domain.Commands.Purchase.Add;
using ShopWeb.Domain.Commands.Purchase.AddWithProducts;
using ShopWeb.Domain.Common;
using ShopWeb.Domain.Entity;
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
        Task<IList<Purchase>> GetAllAsync();
        Task<Purchase> GetAsync(Guid id);
    }
}
