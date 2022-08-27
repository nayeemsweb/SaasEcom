using Ecommerce.Data;
using Ecommerce.Store.Repositories;

namespace Ecommerce.Store.UnitOfWorks
{
    public interface ICartUnitOfWork : IUnitOfWork
    {
        ICartRepository CartRepository { get; }
    

    }
}
