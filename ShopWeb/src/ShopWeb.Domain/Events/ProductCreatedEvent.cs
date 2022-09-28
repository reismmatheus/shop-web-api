using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShopWeb.Domain.Events
{
    public class ProductCreatedEvent : Event
    {
        public ProductCreatedEvent(Guid id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
            AggregateId = id;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
