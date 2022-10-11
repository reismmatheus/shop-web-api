using Microsoft.EntityFrameworkCore;
using ShopWeb.Domain.Entity;
using ShopWeb.Domain.Interfaces;
using ShopWeb.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly ShopWebContext _context;
        public Repository(ShopWebContext context)
        {
            _context = context;
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            entity.CreatedIn = DateTime.UtcNow;
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            entity.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<IList<TEntity>> GetAllAsync()
        {
            return _context.Set<TEntity>().AsNoTracking().ToList();
        }

        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            return await _context.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            entity.UpdatedIn = DateTime.UtcNow;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

