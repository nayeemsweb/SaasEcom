using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.UnitOfWorks
{
    public class MenuUnitOfWork : UnitOfWork, IMenuUnitOfWork
    {
        public IAdminMenuSecRepository AdminMenuSecRepository { get; private set; }
        public IAdminMenuGroupRepository AdminMenuGroupRepository { get; private set; }

        public IAdminMenuItemRespository AdminMenuItemRespository { get; private set; }

        public MenuUnitOfWork(IStoreDbContext storeDbContext,
            IAdminMenuSecRepository adminMenuSecRepository,
            IAdminMenuGroupRepository adminMenuGroupRepository,
            IAdminMenuItemRespository adminMenuItemRespository) : base((DbContext)storeDbContext)
        {
            AdminMenuSecRepository = adminMenuSecRepository;
            AdminMenuGroupRepository = adminMenuGroupRepository;
            AdminMenuItemRespository = adminMenuItemRespository;
        }
    }
}
