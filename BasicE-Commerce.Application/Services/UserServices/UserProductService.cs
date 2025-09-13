using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.Models;
using Mapster;

namespace BasicE_Commerce.Application.Services.UserServices
{
    public class UserProductService : UserService<Product, int, UserProductDTO, ProductCreatedDTO, IProductRepository>,
        IUserProductService
    {
		private readonly IProductRepository _ProductRepository; 
		public UserProductService(IUnitOfWork unitOfWork, IProductRepository productRepository) : base(unitOfWork, productRepository)
        {
			_ProductRepository = productRepository;
        }

		public List<UserProductDTO> GetProductsByCategory(int categoryId)
		{
			var products = _ProductRepository.Get(filter: e => e.CategoryId == categoryId);
			var productsDto = products.Adapt<List<UserProductDTO>>();
			return productsDto;
		}
	}
}
