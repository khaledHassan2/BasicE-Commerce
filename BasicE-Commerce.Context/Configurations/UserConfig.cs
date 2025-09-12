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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Password).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Role).IsRequired().HasMaxLength(50).HasDefaultValue("user");
           // builder.HasData(
           //    new User { Id = 1, Name = "Khaled Mahmoud", Email = "khaled@example.com", Password = "123456", Role = "user" },
           //    new User { Id = 2, Name = "Ali Hassan", Email = "ali@example.com", Password = "123456", Role = "admin" }
           //);
        }
    }
}
