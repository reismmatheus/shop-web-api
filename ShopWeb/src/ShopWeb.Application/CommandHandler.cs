using MediatR;
using ShopWeb.Infra.Data.UnitOfWork;

namespace ShopWeb.Application
{
    public class CommandHandler
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;
        public CommandHandler(IMediator mediator, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
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
