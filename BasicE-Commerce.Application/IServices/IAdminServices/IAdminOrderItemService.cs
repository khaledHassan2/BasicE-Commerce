using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.OrderItemDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.IServices.IAdminServices
{
	public interface IAdminOrderItemService : IAdminService<OrderItem, int, AdminOrderItemDTO, OrderItemCreatedDTO, IOrderItemRepository>
	{
		public List<AdminOrderItemDTO> GetOrderItemByOrderId(int orderId);

    }
}
