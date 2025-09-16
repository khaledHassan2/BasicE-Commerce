using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.OrderDTOs;
using BasicE_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.IServices.IAdminServices
{
	public interface IAdminOrderService : IAdminService<Order, int, AdminOrderDTO, OrderCreatedDTO, IOrderRepository>
	{
		public void UpdateOrderStatus(int orderId, string status);
    }
}
