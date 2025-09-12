using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.CartItem;
using BasicE_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.IServices.IAdminServices
{
	public interface IAdminCartItemService : IAdminService<CartItem, int, CartItemDTO, CartItemCreatedDTO, ICartItemRepository>
	{
	}
}
