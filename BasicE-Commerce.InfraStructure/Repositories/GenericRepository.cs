using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BasicE_Commerce.InfraStructure.Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        private readonly BasicEcommerceDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(BasicEcommerceDbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            this._context.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            entity.IsDeleted= true;
            this._context.Update(entity);
        }

        public IQueryable<TEntity>? Get(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, object>>[]? includeProps = null, bool tracked = true)
        {
            IQueryable<TEntity> query = this._dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProps != null)
            {
                foreach (var include in includeProps)
                {
                    query = query.Include(include);
                }
            }
            if (!tracked)
            {
                query = query.AsNoTracking();
            }

            return query;
        }

        public TEntity? GetById(TKey? id)
        {
            return this.GetItem(filter: e => e.Id != null && e.Id.Equals(id), tracked: true);
        }

        public TEntity? GetItem(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, object>>[]? includeProps = null, bool tracked = true)
        {
            return this.Get(filter, includeProps, tracked)?.FirstOrDefault();
        }

        public void Update(TEntity entity)
        {
            var trackedEntity = _dbSet.Find(entity.Id);
            if (trackedEntity != null)
            {
                _context.Entry(trackedEntity).CurrentValues.SetValues(entity);
            }
            else
            {
                // Optionally handle the case where the entity is not found
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
            }
        }
        public void DeleteById(TKey id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _dbSet.Update(entity);
            }
        }
    }
}
