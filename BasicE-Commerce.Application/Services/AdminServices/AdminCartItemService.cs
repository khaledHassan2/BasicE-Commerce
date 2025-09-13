using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.DTOs.CartItemDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.Services.AdminServices
{
    public class AdminCartItemService : 
        AdminService<CartItem, int, AdminCartItemDTO, CartItemCreatedDTO,ICartItemRepository>,
        IAdminCartItemService
    {
        public AdminCartItemService(IUnitOfWork unitOfWork, ICartItemRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
