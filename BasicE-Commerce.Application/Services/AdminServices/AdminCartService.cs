using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.DTOs.CartDTOs;
using BasicE_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.Services.AdminServices
{
    internal class AdminCartService : AdminService<Cart, int, CartDTO, CartCreatedDTO, ICartRepository>,
        IAdminCartService
    {
        public AdminCartService(IUnitOfWork unitOfWork, ICartRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
