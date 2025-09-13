using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.DTOs.CartItemDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.Services.UserServices
{
    public class UserCartItemService :
        UserService<CartItem, int, UserCartItemDTO, CartItemCreatedDTO,ICartItemRepository>,
        IUserCartItemService
    {
        public UserCartItemService(IUnitOfWork unitOfWork, ICartItemRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
