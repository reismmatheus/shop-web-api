using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Commands.Purchase.AddWithProducts
{
    public class AddPurchaseWithProductsCommand : IRequest<int>
    {
        public Guid CustomerId { get; set; }
        public IList<ProductQuantity> Products { get; set; }

        public class ProductQuantity
        {
            public Guid ProductId { get; set; }
            public int Quantity { get; set; }
        }
    }
}
