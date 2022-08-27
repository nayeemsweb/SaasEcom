using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.UnitOfWorks
{
    public class CategoryUnitOfWork : UnitOfWork, ICategoryUnitOfWork
    {
        public ICategoryRepository Categories { get; private set; }
        public CategoryUnitOfWork(IStoreDbContext storeDbContext,
            ICategoryRepository categoryRepository) : base((DbContext)storeDbContext)
        {
            Categories = categoryRepository;
        }
    }
}
