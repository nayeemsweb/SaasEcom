using Ecommerce.Data;
using EcomStoreEntity = Ecommerce.Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.Repositories.MetaData
{
    public interface IStoreInfoRepository : IRepository<EcomStoreEntity.Store, Guid>
    {
    }
}
