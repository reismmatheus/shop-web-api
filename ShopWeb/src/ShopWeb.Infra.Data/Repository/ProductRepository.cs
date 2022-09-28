using ShopWeb.Domain.Models;
using ShopWeb.Infra.Data.Context;
using ShopWeb.Infra.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Infra.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ShopWebContext _context;
        public ProductRepository(ShopWebContext context) : base(context)
        {
            _context = context;
        }
    }
}
