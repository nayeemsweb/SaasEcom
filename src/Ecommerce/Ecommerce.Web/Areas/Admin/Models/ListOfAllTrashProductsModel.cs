using Ecommerce.Common;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class ListOfAllTrashProductsModel
    {
        private readonly IProductRestoreService _productRestoreService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ListOfAllTrashProductsModel(IProductService productService, 
            ICategoryService categoryService, IProductRestoreService productRestoreService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _productRestoreService = productRestoreService;
        }

        public object? GetAllTrashProducts(DataTablesAjaxRequestModel dataTableModel, Guid StoreId)
        {
            var data = _productService.GetTrashedProducts(
                    StoreId,
                    dataTableModel.PageIndex,
                    dataTableModel.PageSize,
                    dataTableModel.SearchText,
                    dataTableModel.GetSortText(
                        new string[] {"Name",
                                      "UnitPrice"}));
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from productInfo in data.trashedProducts
                        select new string[]
                        {
                           (productInfo.ProductImages!=null)?
                                productInfo.ProductImages.Select(x => x.Url).FirstOrDefault().ToString():string.Empty,
                            productInfo.Name,
                            (productInfo.ProductCategories!=null)?
                            String.Join(",", productInfo.ProductCategories.Select(x =>
                                            _categoryService.GetCategory(x.CategoryId).Name)):string.Empty,
                            (productInfo.ProductInventory!=null)?
                            productInfo.ProductInventory.Quantity.ToString():string.Empty,
                            productInfo.UnitPrice.ToString(),
                            (productInfo!=null)?
                            _productRestoreService.GetTrashByProductId(productInfo.Id).TriggeredOn.ToString("F"):string.Empty,
                            productInfo.Id.ToString()
                        }).ToArray()
            };
        }
    }
}