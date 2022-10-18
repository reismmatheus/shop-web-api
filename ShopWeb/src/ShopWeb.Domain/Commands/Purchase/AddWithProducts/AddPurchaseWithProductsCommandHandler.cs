using MediatR;
using ShopWeb.Domain.Commands.Purchase.Add;
using ShopWeb.Domain.Entity;
using ShopWeb.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Commands.Purchase.AddWithProducts
{
    public class AddPurchaseWithProductsCommandHandler : IRequestHandler<AddPurchaseWithProductsCommand, int>
    {
        private readonly IPurchaseProductRepository _purchaseProductRepository;
        private readonly IPurchaseRepository _purchaseRepository;
        public AddPurchaseWithProductsCommandHandler(IPurchaseRepository purchaseRepository, IPurchaseProductRepository purchaseProductRepository)
        {
            _purchaseRepository = purchaseRepository;
            _purchaseProductRepository = purchaseProductRepository;
        }
        public async Task<int> Handle(AddPurchaseWithProductsCommand request, CancellationToken cancellationToken)
        {
            var purchase = new Entity.Purchase { CustomerId = request.CustomerId };
            await _purchaseRepository.AddAsync(purchase);
            var purchaseProducts = new List<PurchaseProduct>();

            foreach (var item in request.Products)
            {
                purchaseProducts.Add(new PurchaseProduct { ProductId = item.ProductId, Quantity = item.Quantity, PurchaseId = purchase.Id });
            }
            await _purchaseProductRepository.AddRangeAsync(purchaseProducts);
            return 1;
        }
    }
}
