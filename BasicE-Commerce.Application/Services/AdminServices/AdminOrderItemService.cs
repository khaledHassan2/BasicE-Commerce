using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.DTOs.OrderItemDTOs;
using BasicE_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.Services.AdminServices
{
    public class AdminOrderItemService : AdminService<OrderItem, int, OrderItemDTO, OrderItemCreatedDTO, IOrderItemRepository>
        , IAdminOrderItemService
    {
        public AdminOrderItemService(IUnitOfWork unitOfWork, IOrderItemRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
