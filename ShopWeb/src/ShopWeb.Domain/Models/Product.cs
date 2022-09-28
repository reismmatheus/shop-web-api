using NetDevPack.Domain;

namespace ShopWeb.Domain.Models
{
    public class Product : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
