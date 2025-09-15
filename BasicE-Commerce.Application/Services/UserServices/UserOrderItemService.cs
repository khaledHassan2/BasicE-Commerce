using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.DTOs.OrderItemDTOs;
using BasicE_Commerce.Models;
using Mapster;

namespace BasicE_Commerce.Application.Services.UserServices
{
    public class UserOrderItemService : UserService<OrderItem, int, UserOrderItemDTO, OrderItemCreatedDTO, IOrderItemRepository>,
        IUserOrderItemService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderItemRepository _repository;
        public UserOrderItemService(IUnitOfWork unitOfWork, IOrderItemRepository repository) : base(unitOfWork, repository)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void CreateOrderItem(OrderItemCreatedDTO orderItemCreatedDTO)
        {
            var orderItem = orderItemCreatedDTO.Adapt<OrderItem>();
            _repository.Create(orderItem);
            _unitOfWork.Commit();
        }
    }
}
