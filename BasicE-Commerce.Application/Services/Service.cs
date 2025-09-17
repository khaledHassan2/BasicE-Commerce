using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices;
using BasicE_Commerce.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.Services
{
    public class Service<TEntity, TKey, TEntityDto, TEntityCreatedDto, TRepository> : IService<TEntity, TKey, TEntityDto, TEntityCreatedDto, TRepository> where TEntity : BaseEntity<TKey>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<TEntity, TKey> _Repository;

        public Service(IUnitOfWork unitOfWork, IGenericRepository<TEntity, TKey> repository)
        {
            _unitOfWork = unitOfWork;
            _Repository = repository;
        }

        public ICollection<TEntityDto> GetAll()
        {
            var entities = _Repository.Get()?.Where(p=>p.IsDeleted==false);
            var entitiesDTOs = entities.Adapt<ICollection<TEntityDto>>();
            return entitiesDTOs;
        }

        public TEntityDto GetItemById(TKey id)
        {
            var entity = _Repository.GetById(id);
            
            var entityDTO = entity.Adapt<TEntityDto>();
            return entityDTO;
        }
    }
}
