using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Microsoft.EntityFrameworkCore;
using AdminMenuGroup = Ecommerce.Store.Entities.AdminMenuGroup;

namespace Ecommerce.Store.Repositories
{
    public class AdminMenuGroupRepository : Repository<AdminMenuGroup, Guid>, IAdminMenuGroupRepository
    {
        public AdminMenuGroupRepository(IStoreDbContext context) : base((DbContext)context)
        {

        }
    }
}
