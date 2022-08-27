using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Microsoft.EntityFrameworkCore;
using AdminMenuSec = Ecommerce.Store.Entities.AdminMenuSection;

namespace Ecommerce.Store.Repositories
{
    public class AdminMenuSecRepository : Repository<AdminMenuSec, Guid>, IAdminMenuSecRepository
    {
        public AdminMenuSecRepository(IStoreDbContext context) : base((DbContext)context)
        {

        }
    }
}
