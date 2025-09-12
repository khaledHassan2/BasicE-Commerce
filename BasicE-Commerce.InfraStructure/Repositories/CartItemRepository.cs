using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.InfraStructure.Repositories
{
    public class CartItemRepository : GenericRepository<CartItem, int>, ICartItemRepository
    {
        public CartItemRepository(BasicEcommerceDbContext context) : base(context)
        {
        }
    }
}
