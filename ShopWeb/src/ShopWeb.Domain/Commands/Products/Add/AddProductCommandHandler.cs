using MediatR;
using ShopWeb.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Commands.Products.Add
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, int>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediator _mediator;
        public AddProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<int> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            // await _productRepository.AddAsync();
            return 1;
        }
    }
}
