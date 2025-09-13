using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.CartDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.IServices.IAdminServices
{
	public interface IAdminCartService : IAdminService<Cart, int, AdminCartDTO, CartCreatedDTO, ICartRepository>
	{
	}
}
