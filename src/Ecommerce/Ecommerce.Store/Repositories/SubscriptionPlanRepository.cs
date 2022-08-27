using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.Repositories
{
    public class SubscriptionPlanRepository : Repository<SubscriptionPlan, Guid>, ISubscriptionPlanRepository
    {
        public SubscriptionPlanRepository(IStoreDbContext context) : base((DbContext)context)
        {

        }
    }
}
