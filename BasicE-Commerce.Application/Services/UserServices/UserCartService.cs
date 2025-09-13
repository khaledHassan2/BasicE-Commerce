using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.DTOs.CartDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.Services.UserServices
{
    public class UserCartService : UserService<Cart, int, UserCartDTO, CartCreatedDTO, ICartRepository>, IUserCartService
    {
        public UserCartService(IUnitOfWork unitOfWork, IGenericRepository<Cart, int> repository) : base(unitOfWork, repository)
        {
        }
    }
}
