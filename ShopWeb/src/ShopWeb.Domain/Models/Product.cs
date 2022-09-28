using NetDevPack.Domain;

namespace ShopWeb.Domain.Models
{
    public class Product : EntityDefault, IAggregateRoot
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
