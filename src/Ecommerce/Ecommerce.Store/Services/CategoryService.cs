using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.UnitOfWorks;
using CategoryEntity = Ecommerce.Store.Entities.Category;

namespace Ecommerce.Store.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryUnitOfWork _categoryUnitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper,
            ICategoryUnitOfWork categoryUnitOfWork)
        {
            _categoryUnitOfWork = categoryUnitOfWork;
            _mapper = mapper;
        }

        public void CreateCategory(Category category)
        {
            var categoryCount = _categoryUnitOfWork.Categories
                .GetCount(x => x.Name == category.Name);

            var entity = _mapper.Map<CategoryEntity>(category);

            _categoryUnitOfWork.Categories.Add(entity);
            _categoryUnitOfWork.Save();
        }

        public void DeleteCategory(Guid id)
        {
            _categoryUnitOfWork.Categories.Remove(id);
            _categoryUnitOfWork.Save();
        }

        public void EditCategory(Category category)
        {
            var categoryEntity = _categoryUnitOfWork.Categories.GetById(category.Id);

            categoryEntity = _mapper.Map(category, categoryEntity);

            _categoryUnitOfWork.Save();
        }

        public Category GetCategory(Guid id)
        {
            var categoryEntity = _categoryUnitOfWork.Categories.GetById(id);

            var category = _mapper.Map<Category>(categoryEntity);

            return category;
        }

        public (int total, int totalDisplay, IList<Category> records) GetCategories(Guid StoreId, int pageIndex,
            int pageSize, string searchText, string orderBy)
        {
            var result = _categoryUnitOfWork.Categories.GetDynamic(x => x.Name.Contains(searchText) && x.StoreId==StoreId,
                orderBy, string.Empty, pageIndex, pageSize, true);

            List<Category> categorys = new List<Category>();
            foreach (CategoryEntity category in result.data)
            {
                categorys.Add(_mapper.Map<Category>(category));
            }

            return (result.total, result.totalDisplay, categorys);
        }

        public IList<Category> GetCategories(Guid StoreId)
        {
            var categoryEntities = _categoryUnitOfWork.Categories.Get(x=>x.StoreId==StoreId, string.Empty);

            List<Category> categories = new List<Category>();

            foreach (CategoryEntity entity in categoryEntities)
            {
                categories.Add(_mapper.Map<Category>(entity));
            }

            return categories;
        }
        public IList<ProductCategory> GetActiveProductsByCategoryId(string storedProcedureName, 
            int pageIndex, int pageSize, Guid CategoryId)
        {
            var entities = _categoryUnitOfWork.Categories.getActiveProductsByCategoryId(storedProcedureName, 
                            pageIndex, pageSize, CategoryId.ToString());

            var results = new List<ProductCategory>();
            foreach (var entity in entities)
                results.Add(_mapper.Map<ProductCategory>(entity));

            return results;
        }

    }
}
