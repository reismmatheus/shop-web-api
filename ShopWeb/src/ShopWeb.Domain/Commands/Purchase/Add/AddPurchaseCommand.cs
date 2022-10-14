using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Commands.Purchase.Add
{
    public class AddPurchaseCommand : IRequest<int>
    {
        public Guid CustomerId { get; set; }
    }
}
