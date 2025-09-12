using BasicE_Commerce.DTOs.CartDTOs;
using BasicE_Commerce.DTOs.CartItemDTOs;
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
            TypeAdapterConfig<Cart, CartDTO>.NewConfig();
            TypeAdapterConfig<Cart, AdminCartDTO>.NewConfig();
            TypeAdapterConfig<Cart, UserCartDTO>.NewConfig();
            TypeAdapterConfig<Cart, CartCreatedDTO>.NewConfig();


            TypeAdapterConfig<CartItem, CartItemDTO>.NewConfig();
            TypeAdapterConfig<CartItem, AdminCartItemDTO>.NewConfig();
            TypeAdapterConfig<CartItem, UserCartItemDTO>.NewConfig();
            TypeAdapterConfig<CartItem, CartItemCreatedDTO>.NewConfig();


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
