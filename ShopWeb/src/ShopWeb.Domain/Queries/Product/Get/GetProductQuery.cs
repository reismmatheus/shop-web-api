using MediatR;
using ShopWeb.Domain.Common;
using ShopWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Queries.Product.Get
{
    public class GetProductQuery : IRequest<ProductInventory>
    {
        public Guid Id { get; set; }
    }
}
