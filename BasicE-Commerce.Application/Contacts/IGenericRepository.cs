using BasicE_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.Contacts
{
    public interface IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        
        public void Create(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);

        public IQueryable<TEntity>? Get(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, object>>[]? includeProps = null, bool tracked = true);
        public TEntity? GetById(TKey id);

        public TEntity? GetItem(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, object>>[]? includeProps = null, bool tracked = true);

    }
}
