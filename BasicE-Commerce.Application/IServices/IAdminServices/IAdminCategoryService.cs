using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.CategoryDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.IServices.IAdminServices
{
	public interface IAdminCategoryService : IAdminService<Category, int , AdminCategoryDTO, CategoryCreatedDTO, ICategoryRepository>
	{

	}
}
