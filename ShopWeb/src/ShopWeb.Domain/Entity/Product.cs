using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Entity
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
