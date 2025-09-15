using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.OrderDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.IServices.IUserServices
{
    public interface IUserOrderService : IUserService<Order, int, UserOrderDTO, OrderCreatedDTO, IOrderRepository>
    {
        public int CreateOrder(OrderCreatedDTO orderCreatedDTO);
    }
}
