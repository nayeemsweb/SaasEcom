using Ecommerce.Data;
using Ecommerce.Store.Repositories;

namespace Ecommerce.Store.UnitOfWorks
{
    public interface ICategoryUnitOfWork : IUnitOfWork
    {
        ICategoryRepository Categories { get; }
    }
}
