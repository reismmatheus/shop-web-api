using MediatR;
using ShopWeb.Application.CommandQuery.Product.ViewModel;
using ShopWeb.Infra.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Application.CommandQuery.Product.Command
{
    public class ProductCommandHandler : CommandHandler//, IRequestHandler<CreateProductCommandHandler, ProductViewModel>
    {
        public ProductCommandHandler(IMediator mediator, IUnitOfWork unitOfWork) : base(mediator, unitOfWork)
        {
        }

        //public async Task<bool> Handle(CreateProductCommandHandler request, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<ProductViewModel> Handle(CreateProductCommandHandler request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
