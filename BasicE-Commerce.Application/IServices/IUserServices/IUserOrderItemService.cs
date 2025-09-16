using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.OrderDTOs;
using BasicE_Commerce.DTOs.OrderItemDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.IServices.IUserServices
{
    public interface IUserOrderItemService : IUserService<OrderItem, int, UserOrderItemDTO, OrderItemCreatedDTO, IOrderItemRepository>
    {
        public void CreateOrderItem(OrderItemCreatedDTO orderItemCreatedDTO);
        public List<orderItemDetailsDTO> GetOrderItemByOrderId(int orderId);
    }
}
