using MediatR;

namespace ShopWeb.Domain.Queries.Purchase.GetAll
{
    public class GetAllPurchaseQuery : IRequest<IList<Entity.Purchase>>
    {
    }
}
