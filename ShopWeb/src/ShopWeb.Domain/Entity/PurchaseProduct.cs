using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Entity
{
    public class PurchaseProduct : Entity
    {
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
