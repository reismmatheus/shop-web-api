using MediatR;
using ShopWeb.Domain.Common;
using ShopWeb.Domain.Interfaces;
using ShopWeb.Domain.Queries.Product.GetAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Queries.Product.Get
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductInventory>
    {
        private readonly IProductRepository _productRepository;
        public GetProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<ProductInventory> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
            var result = new ProductInventory
            {
                Id = product.Id,
                Name = product.Name,
            };
            return result;
        }
    }
}
