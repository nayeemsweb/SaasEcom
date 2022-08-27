using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.Repositories
{
    public class WishlistRepository : Repository<Wishlist, Guid>, IWishlistRepository
    {
        public WishlistRepository(IStoreDbContext context) : base((DbContext)context)
        {

        }
    }
}
