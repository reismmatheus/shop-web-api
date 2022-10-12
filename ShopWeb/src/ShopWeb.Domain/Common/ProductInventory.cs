using ShopWeb.Domain.Interfaces.CommandQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Common
{
    public class ProductInventory : IResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
