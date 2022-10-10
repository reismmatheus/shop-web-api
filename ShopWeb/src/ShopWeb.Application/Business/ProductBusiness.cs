using AutoMapper;
using MediatR;
using ShopWeb.Application.Interface;

namespace ShopWeb.Application.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ProductBusiness(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync()
        {
            //var command = _mapper.Map<CreateProductCommand>(product);
            //var result = await _mediator.Send(command);
            return true;
        }
    }
}
