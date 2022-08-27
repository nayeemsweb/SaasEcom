using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.UnitOfWorks
{
    public class WishlistUnitOfWork : UnitOfWork, IWishlistUnitOfWork
    {
        public IWishlistRepository Wishlists { get; private set; }
        public WishlistUnitOfWork(IStoreDbContext storeDbContext,
            IWishlistRepository wishlistRepository) : base((DbContext)storeDbContext)
        {
            Wishlists = wishlistRepository;
        }
    }
}
