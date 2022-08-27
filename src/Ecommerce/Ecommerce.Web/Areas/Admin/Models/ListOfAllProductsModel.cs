using Ecommerce.Common;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class ListOfAllProductsModel 
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ListOfAllProductsModel(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public object? GetAllProducts(DataTablesAjaxRequestModel dataTableModel, Guid StoreId)
        {
            var data = _productService.GetActiveProducts(
                    StoreId,
                    dataTableModel.PageIndex,
                    dataTableModel.PageSize,
                    dataTableModel.SearchText,
                    dataTableModel.GetSortText(
                        new string[] {"Name",
                                      "UnitPrice"}));
            return new
            {//_categoryService.GetCategory(x.CategoryId).Name)
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from productInfo in data.Products
                        select new string[]
                        {
                            (productInfo.ProductImages!=null)?
                                productInfo.ProductImages.Select(x => x.Url).FirstOrDefault().ToString():string.Empty,//->0
                            productInfo.Name,//->1
                            (productInfo.ProductCategories!=null)?
                            String.Join(",", productInfo.ProductCategories.Select(x =>
                            {
                                var res = _categoryService.GetCategory(x.CategoryId);
                                return "[{"+res.Id+"}^{"+res.Name+"}]";                           
                            }         
                            )):string.Empty,//->2
                            (productInfo.ProductInventory!=null)?
                            productInfo.ProductInventory.Quantity.ToString():string.Empty,//->3
                            productInfo.UnitPrice.ToString(),//->4
                            productInfo.DiscountedPrice.ToString(),//->5
                            Calculate.Discount((double)productInfo.UnitPrice,
                                (double)productInfo.DiscountedPrice),//->6
                            productInfo.ActiveStatus.ToString(),//->7
                            productInfo.Featured.ToString(),//->8
                            productInfo.Id.ToString(),//->9
                            productInfo.StoreId.ToString()//->10
                        }).ToArray()
            };
        }
    }
}
