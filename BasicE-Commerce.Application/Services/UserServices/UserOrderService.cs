using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.DTOs.OrderDTOs;
using BasicE_Commerce.Models;
using Mapster;

namespace BasicE_Commerce.Application.Services.UserServices
{
    public class UserOrderService : UserService<Order, int, UserOrderDTO, OrderCreatedDTO, IOrderRepository>
    , IUserOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UserOrderService(IUnitOfWork unitOfWork, IOrderRepository repository) : base(unitOfWork, repository)
        {
            _orderRepository = repository;
            _unitOfWork = unitOfWork;
        }

        public void CreateOrder(OrderCreatedDTO orderCreatedDTO)
        {
            var order = orderCreatedDTO.Adapt<Order>();
            _orderRepository.Create(order);
            _unitOfWork.Commit();
        }
    }
}
