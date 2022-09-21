using MediatR;
using ShopWeb.Infra.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Application
{
    public abstract class CommandHandler
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public CommandHandler(IMediator mediator, IUnitOfWork unitOfWork)
        {
            this._mediator = mediator;
            _unitOfWork = unitOfWork;
        }

        public bool Commit()
        {
            return _unitOfWork.Commit();
        }

        public void PublishEvents(IList<object> events)
        {
            events.ToList().ForEach(e => _mediator.Publish(e));
        }
    }
}
