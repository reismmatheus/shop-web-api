using MediatR;
using ShopWeb.Domain.Commands.Products.Add;
using ShopWeb.Domain.Entity;
using ShopWeb.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Commands.Products.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, int>
    {
        private readonly IProductRepository _productRepository;
        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<int> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product { Id = request.Id, Name = request.Name, Price = request.Price };
            await _productRepository.UpdateAsync(product);
            return 1;
        }
    }
}
