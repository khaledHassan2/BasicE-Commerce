using BasicE_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicE_Commerce.Context.Configurations
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
           builder.HasKey(o=>o.Id);
            builder.Property(o => o.Status).IsRequired().HasMaxLength(25);
            builder.HasOne(o => o.User).WithMany(u => u.Orders).HasForeignKey(o => o.UserId).OnDelete(DeleteBehavior.Restrict);
           // builder.HasData(
           //    new Order { Id = 1, UserId = 1, CartId = 1, OrderDate = new DateTime(2025, 1, 1), Status = "Pending" },
           //    new Order { Id = 2, UserId = 2, CartId = 2, OrderDate = new DateTime(2025, 1, 2), Status = "Completed" }
           //);
        }
    }
}
