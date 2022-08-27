using Ecommerce.Data;
using Ecommerce.Store.Repositories;

namespace Ecommerce.Store.UnitOfWorks
{
    public interface IStoreUnitOfWork : IUnitOfWork
    {
        IStoreRepository Stores { get; }
        IEmailMessageRepository EmailMessages { get; }
    }
}
