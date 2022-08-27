using System;
using System.Collections.Generic;
using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.Repositories
{
    public class ProductRestoreRepository: Repository<ProductDelete, Guid>, IProductRestoreRepository
    {
        public ProductRestoreRepository(IStoreDbContext context) : base((DbContext)context)
        {

        }
    }
}
