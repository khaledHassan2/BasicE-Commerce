using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.CartDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.IServices.IUserServices
{
    internal interface IUserCartService : IUserService<Cart, int, UserCartDTO, CartCreatedDTO, ICartRepository>
    {
    }
}
