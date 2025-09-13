using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.Application.IServices.IUserServices
{
    public interface IUserProductService : IUserService<Product, int, UserProductDTO, ProductCreatedDTO, IProductRepository>
    {
        public List<UserProductDTO> GetProductsByCategory(int categoryId);
    }
}
