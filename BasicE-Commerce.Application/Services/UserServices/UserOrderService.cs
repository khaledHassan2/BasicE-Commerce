using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.DTOs.OrderDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.Services.UserServices
{
    public class UserOrderService : UserService<Order, int, UserOrderDTO, OrderCreatedDTO, IOrderRepository>
    , IUserOrderService
    {
        public UserOrderService(IUnitOfWork unitOfWork, IGenericRepository<Order, int> repository) : base(unitOfWork, repository)
        {
        }
    }
}
