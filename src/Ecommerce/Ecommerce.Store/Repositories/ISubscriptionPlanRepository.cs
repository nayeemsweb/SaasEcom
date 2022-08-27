using Ecommerce.Data;
using Ecommerce.Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.Repositories
{
    public interface ISubscriptionPlanRepository : IRepository<SubscriptionPlan, Guid>
    {
    }
}
