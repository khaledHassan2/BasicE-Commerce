using BasicE_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicE_Commerce.Context.Configurations
{
    public class CartConfig : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne(c=>c.User).WithMany(u=>u.Carts).HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(
               new Cart { Id = 1, UserId = 1, CreateAt = new DateTime(2025, 1, 1) },
               new Cart { Id = 2, UserId = 2, CreateAt = new DateTime(2025, 2, 1) }
           );
        }
    }
}
