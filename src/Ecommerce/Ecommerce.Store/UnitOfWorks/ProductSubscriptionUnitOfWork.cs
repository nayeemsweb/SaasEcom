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
    public class ProductSubscriptionUnitOfWork : UnitOfWork, IProductSubscriptionUnitOfWork
    {
        public IProductSubscriptionRepository ProductSubscriptionNotifications { get; private set; }
        public ProductSubscriptionUnitOfWork(IStoreDbContext storeDbContext,
            IProductSubscriptionRepository productSubscriptionRepository) : base((DbContext)storeDbContext)
        {
            ProductSubscriptionNotifications = productSubscriptionRepository;
        }
    }
}
