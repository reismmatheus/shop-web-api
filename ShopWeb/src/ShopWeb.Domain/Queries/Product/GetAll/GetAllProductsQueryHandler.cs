using MediatR;
using ShopWeb.Domain.Common;
using ShopWeb.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Queries.Product.GetAll
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IList<ProductInventory>>
    {
        private readonly IProductRepository _productRepository;
        public GetAllProductsQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IList<ProductInventory>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var result = new List<ProductInventory>();
            var products = await _productRepository.GetAllAsync();
            foreach (var item in products)
            {
                result.Add(new ProductInventory
                {
                    Id = item.Id,
                    Name = item.Name,
                });
            }
            return result;
        }
    }
}
