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
    public class ProductRestoreUnitOfWork : UnitOfWork, IProductRestoreUnitOfWork
    {
        public IProductRestoreRepository ProductRestore { get; private set; }

        public ProductRestoreUnitOfWork(IStoreDbContext storeDbContext,
            IProductRestoreRepository productRestoreRepository) : base((DbContext)storeDbContext)
        {
            ProductRestore = productRestoreRepository;
        }
    }
}
