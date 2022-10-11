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
        Task<bool> AddAsync();
        Task<IList<ProductInventory>> GetAllAsync();
    }
}
