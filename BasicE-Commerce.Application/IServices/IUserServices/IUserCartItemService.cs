using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.CartItemDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.IServices.IUserServices
{
    internal interface IUserCartItemService : IUserService<CartItem, int, UserCartItemDTO, CartItemCreatedDTO, ICartItemRepository>
    {
    }
}
