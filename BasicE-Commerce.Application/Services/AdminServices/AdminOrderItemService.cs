using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.DTOs.OrderItemDTOs;
using BasicE_Commerce.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.Services.AdminServices
{
    public class AdminOrderItemService : AdminService<OrderItem, int, AdminOrderItemDTO, OrderItemCreatedDTO, IOrderItemRepository>
        , IAdminOrderItemService
    {
        IOrderItemRepository _orderItemRepository;
        public AdminOrderItemService(IUnitOfWork unitOfWork, IOrderItemRepository repository) : base(unitOfWork, repository)
        {
            _orderItemRepository = repository;
        }

        public List<orderItemDetailsDTO> GetOrderItemByOrderId(int orderId)
        {
          var orderItems=  _orderItemRepository.Get(filter: e => e.OrderId == orderId,includeProps: [e=>e.Product])?.Where(o=>o.IsDeleted==false).ToList();
          return orderItems.Adapt<List<orderItemDetailsDTO>>();
        }
    }
}
