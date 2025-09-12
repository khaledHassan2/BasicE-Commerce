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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
           builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
              builder.Property(p => p.Description).HasMaxLength(500);
              builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
                builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId) ;
                builder.Property(p => p.Stock).IsRequired();
           // builder.HasData(
           //    new Product { Id = 1, Name = "Laptop", Description = "High performance laptop", Stock = 10, Price = 1200, CategoryId = 1 },
           //    new Product { Id = 2, Name = "Mouse", Description = "Wireless mouse", Stock = 50, Price = 50, CategoryId = 2 },
           //    new Product { Id = 3, Name = "Keyboard", Description = "Mechanical keyboard", Stock = 30, Price = 100, CategoryId = 2 }
           //);


        }
    }
}
