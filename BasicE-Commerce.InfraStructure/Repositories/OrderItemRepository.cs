using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.InfraStructure.Repositories
{
    public class OrderItemRepository : GenericRepository<OrderItem, int>, IOrderItemRepository
    {
        public OrderItemRepository(BasicEcommerceDbContext context) : base(context)
        {
        }
    }
}
