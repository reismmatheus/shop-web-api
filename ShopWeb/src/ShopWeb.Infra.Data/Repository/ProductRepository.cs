using NetDevPack.Data;
using ShopWeb.Domain.Interface;
using ShopWeb.Domain.Models;
using ShopWeb.Infra.Data.Context;
using ShopWeb.Infra.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Infra.Data.Repository
{
    public class ProductRepository : RepositoryDefault<Product>, IProductRepository
    {
        private readonly ShopWebContext _context;
        public ProductRepository(ShopWebContext context) : base(context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
