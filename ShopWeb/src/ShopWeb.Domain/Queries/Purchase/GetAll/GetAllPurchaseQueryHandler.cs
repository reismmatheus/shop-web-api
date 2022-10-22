using MediatR;
using ShopWeb.Domain.Common;
using ShopWeb.Domain.Entity;
using ShopWeb.Domain.Interfaces;
using ShopWeb.Domain.Queries.Product.GetAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Queries.Purchase.GetAll
{
    public class GetAllPurchaseQueryHandler : IRequestHandler<GetAllPurchaseQuery, IList<Entity.Purchase>>
    {
        private readonly IPurchaseRepository _purchaseRepository;
        public GetAllPurchaseQueryHandler(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }
        public async Task<IList<Entity.Purchase>> Handle(GetAllPurchaseQuery request, CancellationToken cancellationToken)
        {
            var result = await _purchaseRepository.GetAllWithProducts();
            return result;
        }
    }
}
