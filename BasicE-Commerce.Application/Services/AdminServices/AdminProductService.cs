using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.Services.AdminServices
{
    public class AdminProductService :
        AdminService<Product, int, AdminProductDTO, ProductCreatedDTO, IProductRepository>
        , IAdminProductService
    {
        public AdminProductService(IUnitOfWork unitOfWork, IProductRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
