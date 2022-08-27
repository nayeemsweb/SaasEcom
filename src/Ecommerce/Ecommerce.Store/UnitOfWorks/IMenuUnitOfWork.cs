using Ecommerce.Data;
using Ecommerce.Store.Repositories;

namespace Ecommerce.Store.UnitOfWorks
{
    public interface IMenuUnitOfWork : IUnitOfWork
    {
        IAdminMenuSecRepository AdminMenuSecRepository { get; }
        IAdminMenuGroupRepository AdminMenuGroupRepository { get; }
        IAdminMenuItemRespository AdminMenuItemRespository { get; }

    }
}
