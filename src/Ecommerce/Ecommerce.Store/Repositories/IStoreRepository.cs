using Ecommerce.Data;
using StoreE = Ecommerce.Store.Entities.Store;

namespace Ecommerce.Store.Repositories
{
    public interface IStoreRepository : IRepository<StoreE, Guid>
    {
    }
}
