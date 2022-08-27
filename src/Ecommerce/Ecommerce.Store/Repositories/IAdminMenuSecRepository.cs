using Ecommerce.Data;
using AdminMenuSec = Ecommerce.Store.Entities.AdminMenuSection;


namespace Ecommerce.Store.Repositories
{
    public interface IAdminMenuSecRepository : IRepository<AdminMenuSec, Guid>
    {
    }
}
