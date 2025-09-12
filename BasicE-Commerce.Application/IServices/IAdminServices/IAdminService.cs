using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.IServices.IAdminServices
{
    public interface IAdminService<TEntity, TKey, TEntityDto, TEntityCreatedDto, TRepository> : IService<TEntity, TKey, TEntityDto, TEntityCreatedDto, TRepository>
    {
        public void Create(TEntityCreatedDto entity);
        public void Update(TEntityDto entity);
        public void Delete(TKey id);
    }
}
