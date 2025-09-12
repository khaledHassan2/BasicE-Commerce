using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.InfraStructure.Repositories
{
    public class CartRepository : GenericRepository<Cart, int>, ICartRepository
    {
        public CartRepository(BasicEcommerceDbContext context) : base(context)
        {
        }
    }
}
