using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Application.CommandQuery.Product.Command
{
    public class CreateProductCommandHandler : ProductCommand
    {
        public CreateProductCommandHandler(Guid id, string name, decimal value)
        {
            Id = id;
            Name = name;
            Value = value;
        }
    }
}
