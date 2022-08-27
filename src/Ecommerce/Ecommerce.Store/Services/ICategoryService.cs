

using Ecommerce.Store.BusinessObjects;

namespace Ecommerce.Store.Services
{
    public interface ICategoryService
    {
        void CreateCategory(Category category);
        void DeleteCategory(Guid id);
        void EditCategory(Category category);
        Category GetCategory(Guid id);
        (int total, int totalDisplay, IList<Category> records) GetCategories(Guid StoreId, int pageIndex,
            int pageSize, string searchText, string orderBy);
        IList<Category> GetCategories(Guid StoreId);
        IList<ProductCategory> GetActiveProductsByCategoryId(string storedProcedureName,
            int pageIndex, int pageSize, Guid CategoryId);
        

    }
}
