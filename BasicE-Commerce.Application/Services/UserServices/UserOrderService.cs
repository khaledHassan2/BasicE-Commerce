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
        public int CreateOrder(OrderCreatedDTO orderCreatedDTO)
        {
            var order = orderCreatedDTO.Adapt<Order>();
            _orderRepository.Create(order);
            _unitOfWork.Commit();
            return order.Id;
        }

        public List<UserOrderDTO> getOrdersByUserId(int? userId)
        {
            var orders = _orderRepository.Get(filter: e => e.UserId == userId)?.Where(o=>o.IsDeleted==false);
            var ordersDto = orders.Adapt<List<UserOrderDTO>>();
            return ordersDto;
        }
        public void DeleteOrder(int orderId)
        {
            _orderRepository.DeleteById(orderId);
            _unitOfWork.Commit();
        }
    }
}
