using ShopWeb.Domain.Entity;

namespace ShopWeb.Domain.Interfaces
{
    public interface IPurchaseRepository : IRepository<Purchase>
    {
        Task<IList<Purchase>> GetAllWithProducts();
    }
}
