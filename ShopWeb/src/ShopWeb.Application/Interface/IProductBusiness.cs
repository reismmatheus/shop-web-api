using FluentValidation.Results;
using ShopWeb.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Application.Interface
{
    public interface IProductBusiness
    {
        Task<ProductViewModel> Get(Guid id);
        Task<IList<ProductViewModel>> GetAllAsync();
        Task<ValidationResult> CreateAsync(ProductViewModel product);
    }
}
