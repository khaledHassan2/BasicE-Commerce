
using BasicE_Commerce.DTOs.CategoryDTOs;
using BasicE_Commerce.DTOs.OrderDTOs;
using BasicE_Commerce.DTOs.OrderItemDTOs;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.DTOs.UserDTOs;
using BasicE_Commerce.Models;
using Mapster;

namespace BasicE_Commerce.DTOs.mapping
{
    public static class MapsterConfig
    {
        public static void BasicECommerceMapsterConfiguration()
        {
            TypeAdapterConfig<Category, CategoryDTO>.NewConfig();
            TypeAdapterConfig<Category, AdminCategoryDTO>.NewConfig();
            TypeAdapterConfig<Category, UserCategoryDTO>.NewConfig();
            TypeAdapterConfig<Category, CategoryCreatedDTO>.NewConfig();

            TypeAdapterConfig<Order, OrderDTO>.NewConfig();
            TypeAdapterConfig<Order, AdminOrderDTO>.NewConfig();
            TypeAdapterConfig<Order, UserOrderDTO>.NewConfig();
            TypeAdapterConfig<Order, OrderCreatedDTO>.NewConfig();

            TypeAdapterConfig<OrderItem, OrderItemDTO>.NewConfig();
            TypeAdapterConfig<OrderItem, AdminOrderItemDTO>.NewConfig();
            TypeAdapterConfig<OrderItem, UserOrderItemDTO>.NewConfig();
            TypeAdapterConfig<OrderItem, OrderItemCreatedDTO>.NewConfig();
            TypeAdapterConfig<OrderItem, orderItemDetailsDTO>.NewConfig()
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Quantity, src => src.Quantity)
            .Map(dest => dest.ProductName, src => src.Product.Name)
            .Map(dest => dest.Description, src => src.Product.Description)
            .Map(dest => dest.Stock, src => src.Product.Stock)
            .Map(dest => dest.Price, src => src.Product.Price);


            TypeAdapterConfig<Product, ProductDTO>.NewConfig();
            TypeAdapterConfig<Product, AdminProductDTO>.NewConfig();
            TypeAdapterConfig<Product, UserProductDTO>.NewConfig();
            TypeAdapterConfig<Product, ProductCreatedDTO>.NewConfig();

            TypeAdapterConfig<User, UserDTO>.NewConfig();
            TypeAdapterConfig<User, AdminUserDTO>.NewConfig();
            TypeAdapterConfig<User, UserUserDTO>.NewConfig();
            TypeAdapterConfig<User, UserCreatedDTO>.NewConfig();

        }
    }
}
