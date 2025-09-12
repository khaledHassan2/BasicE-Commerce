using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.Cart;
using BasicE_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.IServices.IAdminServices
{
	public interface IAdminCartService : IAdminService<Cart, int, CartDTO, CartCreatedDTO, ICartRepository>
	{
	}
}
