using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.CategoryDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.IServices.IUserServices
{
    public interface IUserCategoryService : IUserService<Category,int,UserCategoryDTO,CategoryCreatedDTO,ICategoryRepository>
    {
    }
}
