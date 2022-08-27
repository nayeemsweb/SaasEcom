using Ecommerce.Data;
using Ecommerce.Store.Entities;

namespace Ecommerce.Store.Repositories
{
    public interface ICategoryRepository : IRepository<Category, Guid>
    {
        IList<ProductCategory> getActiveProductsByCategoryId(string storedProcedureName, 
            int pageIndex, int pageSize, string InputCategoryId);
    }
}
