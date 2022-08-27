using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.Repositories
{
    public class ImageRepository : Repository<ProductImage, Guid>, IImageRepository
    {
        public ImageRepository(IStoreDbContext context) : base((DbContext)context)
        {
        }
    }
}
