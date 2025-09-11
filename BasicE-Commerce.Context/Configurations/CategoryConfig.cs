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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.Description)
                .HasMaxLength(200);
            builder.HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasData(
              new Category { Id = 1, Name = "Electronics", Description = "Electronic devices" },
              new Category { Id = 2, Name = "Accessories", Description = "Computer accessories" }
          );
        }
    }
}
