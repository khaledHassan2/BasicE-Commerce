using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.DTOs.OrderDTOs;
using BasicE_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.Services.AdminServices
{
    public class AdminOrderService : AdminService<Order, int, AdminOrderDTO, OrderCreatedDTO, IOrderRepository>
    , IAdminOrderService
    {
        IOrderRepository _repository;
        IUnitOfWork _unitOfWork;
        public AdminOrderService(IUnitOfWork unitOfWork, IOrderRepository repository) : base(unitOfWork, repository)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void UpdateOrderStatus(int orderId, string status)
        {
            Order order = _repository.GetById(orderId);

            if (order != null)
            {
                order.Status = status;
                _repository.Update(order);
                _unitOfWork.Commit();
            }
        }
    }
}
