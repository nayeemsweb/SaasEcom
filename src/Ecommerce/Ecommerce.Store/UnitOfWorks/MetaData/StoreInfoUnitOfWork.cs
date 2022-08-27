using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Repositories.MetaData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.UnitOfWorks.MetaData
{
    public class StoreInfoUnitOfWork : UnitOfWork, IStoreInfoUnitOfWork
    {
        public IStoreInfoRepository StoreInfoRepository { get; private set; }

        public StoreInfoUnitOfWork(IStoreDbContext storeDbContext,
            IStoreInfoRepository storeInfoRepository) : base((DbContext)storeDbContext)
        {
            StoreInfoRepository = storeInfoRepository;
        }
    }
}
