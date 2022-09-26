using AutoMapper;
using MediatR;
using ShopWeb.Infra.Data.Interface;
using ShopWeb.Infra.Data.UnitOfWork;
using ShopWeb.Infra.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Application.CommandQuery.Product.Command
{
    public class CreateProductCommandHandler : CommandHandler, IRequestHandler<CreateProductCommand, ProductViewModel>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper, IMediator mediator, IUnitOfWork unitOfWork) : base(mediator, unitOfWork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductViewModel> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Domain.Product
            {
                Name = request.Name,
                Price = request.Price
            };

            var insertProject = await _productRepository.AddAsync(product);

            Commit();
            // PublishEvents(product)

            var result = _mapper.Map<ProductViewModel>(insertProject);

            return result;
        }
    }
}
