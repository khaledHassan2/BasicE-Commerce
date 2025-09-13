using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.DTOs.CategoryDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.Services.UserServices
{
    public class UserCategoryService : UserService<Category, int, UserCategoryDTO, CategoryCreatedDTO, ICategoryRepository>
     , IUserCategoryService
    {
        public UserCategoryService(IUnitOfWork unitOfWork, IGenericRepository<Category, int> repository) : base(unitOfWork, repository)
        {
        }
    }
}
