using MediatR;
using ShopWeb.Domain.Commands.Customer.Add;
using ShopWeb.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Commands.Purchase.Add
{
    public class AddPurchaseCommandHandler : IRequestHandler<AddPurchaseCommand, int>
    {
        private readonly IPurchaseRepository _purchaseRepository;
        public AddPurchaseCommandHandler(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }
        public async Task<int> Handle(AddPurchaseCommand request, CancellationToken cancellationToken)
        {
            var purchase = new Entity.Purchase { CustomerId = request.CustomerId };
            await _purchaseRepository.AddAsync(purchase);
            return 1;
        }
    }
}