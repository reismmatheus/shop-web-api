using AutoMapper;
using ShopWeb.Domain.Models;
using ShopWeb.Infra.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Infra.Data.Mapping
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Product, ProductViewModel>()
                .ConstructUsing(x => new ProductViewModel { Id = x.Id, Name = x.Name, Price = x.Price });
        }
    }
}
