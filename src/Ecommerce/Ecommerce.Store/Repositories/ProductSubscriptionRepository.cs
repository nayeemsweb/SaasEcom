using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.Repositories
{
    public class ProductSubscriptionRepository : Repository<ProductSubscriptionNotification, Guid>, IProductSubscriptionRepository
    { 
        public ProductSubscriptionRepository(IStoreDbContext context) : base((DbContext)context)
        {

        }
    }
}
