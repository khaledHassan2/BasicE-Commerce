using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.DTOs.OrderItemDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.Services.UserServices
{
    public class UserOrderItemService : UserService<OrderItem, int, UserOrderItemDTO, OrderItemCreatedDTO, IOrderItemRepository>,
        IUserOrderItemService
    {
        public UserOrderItemService(IUnitOfWork unitOfWork, IGenericRepository<OrderItem, int> repository) : base(unitOfWork, repository)
        {
        }
    }
}
