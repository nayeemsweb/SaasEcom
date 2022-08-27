using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.Repositories
{
    public class OrderRepository : Repository<Order, Guid>, IOrderRepository
    {
        public OrderRepository(IStoreDbContext context) : base((DbContext)context)
        {

        }
    }
}
