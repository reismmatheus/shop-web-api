using ShopWeb.Domain.Entity;
using ShopWeb.Domain.Interfaces;
using ShopWeb.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Infra.Data.Repository
{
    public class PurchaseRepository : Repository<Purchase>, IPurchaseRepository
    {
        private readonly ShopWebContext _context;
        public PurchaseRepository(ShopWebContext context) : base(context)
        {
            _context = context;
        }
    }
}