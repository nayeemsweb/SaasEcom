using Ecommerce.Common;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class CategoryListModel
    {
        private readonly ICategoryService _categoryService;
        private Guid _StoreId { get; set; }

        public CategoryListModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        internal void setStoreId(Guid StoreId)
        {
            _StoreId = StoreId;
        }

        public object GetPagedCategories(DataTablesAjaxRequestModel model)
        {
            var data = _categoryService.GetCategories(_StoreId,
                model.PageIndex,
                model.PageSize,
                model.SearchText,
                model.GetSortText(new string[] { "Name", "Description" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string?[]
                        {
                                record.Name,
                                record.Description,
                                record.Id.ToString()
                        }
                    ).ToArray()
            };
        }

        public IList<Category> GetCategories(Guid storeId)
        {
            return _categoryService.GetCategories(storeId);
        }
    }
}
