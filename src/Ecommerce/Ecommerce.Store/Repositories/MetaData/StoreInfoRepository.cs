using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Microsoft.EntityFrameworkCore;
using EcomStoreEntity = Ecommerce.Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.Repositories.MetaData
{
    public class StoreInfoRepository : Repository<EcomStoreEntity.Store, Guid>, IStoreInfoRepository
    {
        public StoreInfoRepository(IStoreDbContext context) : base((DbContext)context)
        {

        }
    }
}
