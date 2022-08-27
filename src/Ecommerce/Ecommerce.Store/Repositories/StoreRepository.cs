using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Microsoft.EntityFrameworkCore;
using StoreE = Ecommerce.Store.Entities.Store;

namespace Ecommerce.Store.Repositories
{
    public class StoreRepository : Repository<StoreE, Guid>, IStoreRepository
    {
        public StoreRepository(IStoreDbContext context) : base((DbContext)context)
        {

        }
    }
}
