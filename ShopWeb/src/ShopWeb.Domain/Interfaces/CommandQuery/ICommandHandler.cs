using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Interfaces.CommandQuery
{
    public interface ICommand
    { }

    public interface ICommandHandler
    { }

    public interface ICommandHandler<T> : ICommandHandler where T : ICommand
    {
        Task Handle(T command);
    }

    public interface ICommandDispatcher
    {
        void Send<T>(T command) where T : ICommand;
    }
}
