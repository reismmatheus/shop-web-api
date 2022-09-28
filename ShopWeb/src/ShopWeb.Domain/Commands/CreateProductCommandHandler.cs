using AutoMapper;
using MediatR;
using NetDevPack.Messaging;
using ShopWeb.Domain.Events;
using ShopWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Commands
{
    public class CreateProductCommandHandler : CommandHandler, IRequestHandler<CreateProductCommand, ValidationResult>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper, IMediator mediator/*, IUnitOfWork unitOfWork*/) /*: base(mediator, unitOfWork)*/
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ValidationResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Price = request.Price
            };

            product.AddDomainEvent(new ProductCreatedEvent(product.Id, product.Name, product.Price));

            await _productRepository.AddAsync(product);

            return await Commit(_productRepository.Unit);
        }
    }
}
