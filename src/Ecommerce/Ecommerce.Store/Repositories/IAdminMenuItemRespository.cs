using Ecommerce.Data;
using AdminMenuItem = Ecommerce.Store.Entities.AdminMenuItem;
namespace Ecommerce.Store.Repositories
{
    public interface IAdminMenuItemRespository : IRepository<AdminMenuItem, Guid>
    {
    }
}