using Microsoft.EntityFrameworkCore;
using ShopWeb.Domain.Interface;
using ShopWeb.Domain.Models;
using ShopWeb.Infra.Data.Context;
using ShopWeb.Infra.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Infra.Data.Repository
{
    public class RepositoryDefault<TEntity> : IRepositoryDefault<TEntity> where TEntity : EntityDefault
    {
        protected readonly ShopWebContext _context;
        public RepositoryDefault(ShopWebContext context)
        {
            _context = context;
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            entity.CreatedIn = DateTime.UtcNow;
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            entity.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<IList<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            return await _context.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IList<TEntity>> GetItemAsync(Expression<Func<TEntity, bool>> wherePredicate)
        {
            return await _context.Set<TEntity>().Where(wherePredicate).ToListAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            entity.UpdatedIn = DateTime.UtcNow;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

