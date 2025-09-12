using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.IServices.IAdminServices
{
    public interface IAdminProductService : IAdminService<Product, int, AdminProductDTO, ProductCreatedDTO, IProductRepository>
    {
    }
}
