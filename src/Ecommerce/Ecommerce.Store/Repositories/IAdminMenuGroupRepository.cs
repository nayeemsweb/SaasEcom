using Ecommerce.Data;
using AdminMenuGroupSec = Ecommerce.Store.Entities.AdminMenuGroup;
namespace Ecommerce.Store.Repositories
{
    public interface IAdminMenuGroupRepository : IRepository<AdminMenuGroupSec, Guid>
    {

    }
}