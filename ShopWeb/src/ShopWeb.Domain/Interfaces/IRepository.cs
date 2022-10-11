using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ShopWeb.Domain.Entity;

namespace ShopWeb.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity.Entity
    {
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(Guid id);
        Task<TEntity?> GetByIdAsync(Guid id);
        Task<IList<TEntity>> GetAllAsync();
    }
}
