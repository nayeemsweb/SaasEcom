using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.Repositories
{
    public class CartRepository : Repository<Cart, Guid>, ICartRepository
    {
        public CartRepository(IStoreDbContext context) : base((DbContext)context)
        {

        }
    }
}
