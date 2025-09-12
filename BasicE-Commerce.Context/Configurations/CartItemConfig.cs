using BasicE_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Context.Configurations
{
    public class CartItemConfig : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(ci => ci.Id);
            builder.HasOne(ci => ci.Cart).WithMany(c => c.CartItems).HasForeignKey(ci => ci.CartID)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(ci => ci.Product).WithMany(p => p.CartItems).HasForeignKey(ci => ci.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
           // builder.HasData(
           //    new CartItem { Id = 1, CartID = 1, ProductId = 1, Quantity = 1 },
           //    new CartItem { Id = 2, CartID = 1, ProductId = 2, Quantity = 2 },
           //    new CartItem { Id = 3, CartID = 2, ProductId = 3, Quantity = 1 }
           //);
        }
    }
}
