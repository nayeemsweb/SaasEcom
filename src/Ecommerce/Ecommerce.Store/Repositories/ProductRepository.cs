using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.Repositories
{
    public class ProductRepository : Repository<Product, Guid>, IProductRepository
    {
        public ProductRepository(IStoreDbContext context) : base((DbContext)context)
        {

        }
    }
}
