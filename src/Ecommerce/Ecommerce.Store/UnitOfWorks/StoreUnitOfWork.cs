using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.UnitOfWorks
{
    public class StoreUnitOfWork : UnitOfWork, IStoreUnitOfWork
    {
        public IStoreRepository Stores { get; private set; }
        public IEmailMessageRepository EmailMessages { get; private set; }
        public StoreUnitOfWork(IStoreDbContext storeDbContext,
            IStoreRepository storeRepository,
            IEmailMessageRepository emailMessageRepository) : base((DbContext)storeDbContext)
        {
            Stores = storeRepository;
            EmailMessages = emailMessageRepository;
        }
    }
}
