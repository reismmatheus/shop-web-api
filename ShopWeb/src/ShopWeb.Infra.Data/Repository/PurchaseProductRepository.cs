using ShopWeb.Domain.Entity;
using ShopWeb.Domain.Interfaces;
using ShopWeb.Infra.Data.Context;

namespace ShopWeb.Infra.Data.Repository
{
    public class PurchaseProductRepository : Repository<PurchaseProduct>, IPurchaseProductRepository
    {
        private readonly ShopWebContext _context;
        public PurchaseProductRepository(ShopWebContext context) : base(context)
        {
            _context = context;
        }
    }
}
