using NetDevPack.Data;
using ShopWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Interface
{
    public interface IProductRepository : IRepository<Product>, IRepositoryDefault<Product>
    {
    }
}
