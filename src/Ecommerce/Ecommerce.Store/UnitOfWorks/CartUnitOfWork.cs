using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.UnitOfWorks
{
    public class CartUnitOfWork : UnitOfWork, ICartUnitOfWork
    {
        public ICartRepository CartRepository { get; private set; }
        

        public CartUnitOfWork(IStoreDbContext storeDbContext,
            ICartRepository cartRepository) : base((DbContext)storeDbContext)
        {
            CartRepository = cartRepository;
        }
    }
}
