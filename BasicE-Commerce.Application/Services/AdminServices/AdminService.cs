using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.Services.AdminServices
{
    public class AdminService<TEntity, TKey, TEntityDto, TEntityCreatedDto, TRepository> : 
        Service<TEntity, TKey, TEntityDto, TEntityCreatedDto, TRepository>, 
        IAdminService<TEntity, TKey, TEntityDto, TEntityCreatedDto, TRepository> 
        where TEntity : BaseEntity<TKey> where TRepository : IGenericRepository<TEntity, TKey>
    {
        private readonly IUnitOfWork _unitOfWork;
        TRepository _Repository;
        public AdminService(IUnitOfWork unitOfWork, TRepository repository) : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _Repository = repository;
        }

        public void Create(TEntityCreatedDto entity)
        {
            var model = entity.Adapt<TEntity>();
            _Repository.Create(model);
            _unitOfWork.Commit();
            
        }

        public void Delete(TKey id)
        {
            var model = _Repository.GetById(id);
            if(model is not null)
            {
                model.IsDeleted = true;
                _Repository.Update(model);
                _unitOfWork.Commit();
            }
            
        }

        public void Update(TEntityDto entity)
        {
            var model = entity.Adapt<TEntity>();
            _Repository.Update(model);
            _unitOfWork.Commit();
        }
    }
}
