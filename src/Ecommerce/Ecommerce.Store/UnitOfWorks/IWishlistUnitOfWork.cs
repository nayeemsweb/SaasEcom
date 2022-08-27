using Ecommerce.Data;
using Ecommerce.Store.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.UnitOfWorks
{
    public interface IWishlistUnitOfWork : IUnitOfWork
    {
        IWishlistRepository Wishlists { get; }
    }
}
