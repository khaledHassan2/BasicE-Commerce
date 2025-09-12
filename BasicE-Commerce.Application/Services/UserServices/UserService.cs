using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.Services.UserServices
{
    public class UserService<TEntity, TKey, TEntityDto, TEntityCreatedDto, TRepository> : Service<TEntity, TKey, TEntityDto, TEntityCreatedDto, TRepository>, IUserService<TEntity, TKey, TEntityDto, TEntityCreatedDto, TRepository> where TEntity : BaseEntity<TKey>
    {
        public UserService(IUnitOfWork unitOfWork, IGenericRepository<TEntity, TKey> repository) : base(unitOfWork, repository)
        {
        }
    }

}
