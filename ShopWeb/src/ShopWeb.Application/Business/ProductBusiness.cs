using AutoMapper;
using FluentValidation.Results;
using NetDevPack.Mediator;
using ShopWeb.Application.Interface;
using ShopWeb.Application.ViewModels;
using ShopWeb.Domain.Commands;
using ShopWeb.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Application.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly IMediatorHandler _mediatorHandler;
        public ProductBusiness(IMapper mapper, IProductRepository productRepository, IMediatorHandler mediatorHandler)
        {
            _mapper = mapper;
            _productRepository = productRepository;
            _mediatorHandler = mediatorHandler;
        }

        public async Task<ProductViewModel> Get(Guid id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductViewModel>(product);
        }

        public async Task<IList<ProductViewModel>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<IList<ProductViewModel>>(products);
        }

        public async Task<ValidationResult> CreateAsync(ProductViewModel product)
        {
            var comand = _mapper.Map<CreateProductCommand>(product);
            return await _mediatorHandler.SendCommand(comand);
        }
    }
}
