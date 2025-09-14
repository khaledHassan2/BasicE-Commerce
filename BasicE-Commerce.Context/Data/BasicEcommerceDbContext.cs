using BasicE_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BasicE_Commerce.Context.Data
{
    public class BasicEcommerceDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=itiBasicEcommerce;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);

        }
    }
}
