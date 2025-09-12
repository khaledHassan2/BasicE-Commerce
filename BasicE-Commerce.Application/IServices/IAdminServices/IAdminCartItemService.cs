using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.CartItemDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.IServices.IAdminServices
{
	public interface IAdminCartItemService : IAdminService<CartItem, int, CartItemDTO, CartItemCreatedDTO, ICartItemRepository>
	{
	}
}
