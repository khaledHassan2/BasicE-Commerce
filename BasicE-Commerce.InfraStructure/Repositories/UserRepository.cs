using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.Models;

namespace BasicE_Commerce.InfraStructure.Repositories
{
    public class UserRepository : GenericRepository<User, int>, IUserRepository
    {
        public UserRepository(BasicEcommerceDbContext context) : base(context)
        {
        }
    }
}
