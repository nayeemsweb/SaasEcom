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
    public class ProductUnitOfWork: UnitOfWork, IProductUnitOfWork
    {
        public IProductRepository Products { get; private set; }
        public IProductRestoreRepository ProductRestore { get; private set; }

        public ProductUnitOfWork(IStoreDbContext storeDbContext,
            IProductRepository productRepository,
            IProductRestoreRepository productRestoreRepository) : base((DbContext)storeDbContext)
        {
            Products = productRepository;
            ProductRestore = productRestoreRepository;
        }
    }
}
