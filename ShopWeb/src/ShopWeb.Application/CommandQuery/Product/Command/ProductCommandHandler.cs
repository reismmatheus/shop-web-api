using MediatR;
using ShopWeb.Infra.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Application.CommandQuery.Product.Command
{
    public class ProductCommandHandler : CommandHandler
    {
        public ProductCommandHandler(IMediator mediator, IUnitOfWork unitOfWork) : base(mediator, unitOfWork)
        {
        }
    }
}
