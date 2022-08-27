using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Microsoft.EntityFrameworkCore;
using AdminMenuItem = Ecommerce.Store.Entities.AdminMenuItem;

namespace Ecommerce.Store.Repositories
{
    public class AdminMenuItemRespository : Repository<AdminMenuItem, Guid>, IAdminMenuItemRespository
    {
        public AdminMenuItemRespository(IStoreDbContext context) : base((DbContext)context)
        {

        }
    }
}
