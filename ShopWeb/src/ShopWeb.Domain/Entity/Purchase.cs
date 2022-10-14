using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Domain.Entity
{
    public class Purchase : Entity
    {
        public Guid CustomerId { get; set; }
        public ICollection<PurchaseProduct> PurchaseProducts { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
