using Ecommerce.Data;
using Ecommerce.Store.Repositories.MetaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.UnitOfWorks.MetaData
{
    public interface IStoreInfoUnitOfWork : IUnitOfWork
    {
        IStoreInfoRepository StoreInfoRepository { get; }
    }
}
