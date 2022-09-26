using MediatR;
using ShopWeb.Infra.Data.ViewModels;

namespace ShopWeb.Application.CommandQuery.Product.Command
{
    public class CreateProductCommand : IRequest<ProductViewModel>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
