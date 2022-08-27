using Ecommerce.Data;
using Ecommerce.Store.Repositories;

namespace Ecommerce.Store.UnitOfWorks
{
    public interface IProductSubscriptionUnitOfWork : IUnitOfWork
    {
        IProductSubscriptionRepository ProductSubscriptionNotifications { get; }
    }
}