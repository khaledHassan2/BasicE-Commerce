using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.Services.UserServices
{
    public class UserProductService : UserService<Product, int, UserProductDTO, ProductCreatedDTO, IProductRepository>,
        IUserProductService
    {
		private readonly IProductRepository _ProductRepository; 
		public UserProductService(IUnitOfWork unitOfWork, IGenericRepository<Product, int> repository) : base(unitOfWork, repository)
        {
        }

		public List<UserProductDTO> GetProductsByCategory(int categoryId)
		{
			var products = _ProductRepository.Get(filter: e => e.CategoryId == categoryId);
			var productsDto = products.Adapt<List<UserProductDTO>>();
			return productsDto;
		}
	}
}
