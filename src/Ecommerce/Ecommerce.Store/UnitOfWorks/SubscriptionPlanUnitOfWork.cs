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
    public class SubscriptionPlanUnitOfWork : UnitOfWork, ISubscriptionPlanUnitOfWork
    {
        public ISubscriptionPlanRepository SubscriptionPlans { get; private set; }
        public SubscriptionPlanUnitOfWork(IStoreDbContext storeDbContext,
            ISubscriptionPlanRepository subscriptionPlanRepository) : base((DbContext)storeDbContext)
        {
            SubscriptionPlans = subscriptionPlanRepository;
        }
 
    }
}
