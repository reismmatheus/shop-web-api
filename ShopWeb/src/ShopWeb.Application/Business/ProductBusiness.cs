using AutoMapper;
using MediatR;
using ShopWeb.Application.Interface;
using ShopWeb.Domain.Common;
using ShopWeb.Domain.Interfaces;
using ShopWeb.Domain.Queries.Product;

namespace ShopWeb.Application.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IQueryDispatcher _queryDispatcher;

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ProductBusiness(IMediator mediator/*, IMapper mapper*/)
        {
            _mediator = mediator;
            // _mapper = mapper;
        }

        public async Task<bool> AddAsync()
        {
            //var command = _mapper.Map<CreateProductCommand>(product);
            //var result = await _mediator.Send(command);
            return true;
        }

        public async Task<IList<ProductInventory>> GetAllAsync()
        {
            var result = await _mediator.Send(new GetAllProductsQuery());
            return result;
        }
    }
}
