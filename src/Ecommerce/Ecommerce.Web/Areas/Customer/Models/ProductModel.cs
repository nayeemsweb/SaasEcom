using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using Microsoft.Data.SqlClient;

namespace Ecommerce.Web.Areas.Customer.Models
{

    public class ProductModel
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public decimal MinimumAmount{ get; set; } 
        public decimal MaximumAmount { get; set; }
        public IList<Product> Products { get; set; }

        public Guid _StoreId { get; set; }//from view

        public ProductModel(IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IList<Product> GetAllProducts()
        {
            var records = _productService.GetGridProducts(_StoreId, 1, 9, "", "Name");
            Products = records.products;
            return Products;
        }
        
        public object GetFilteredProducts(string sortOrder,int pageIndex)
        {
            var records  = _productService.GetGridProducts(_StoreId, pageIndex, 9,"",sortOrder);
            return new
            {
                recordsTotal = records.total,
                recordsFiltered = records.totalDisplay,
                filteredProducts = records.products
            };

        }
        public void setStoreId(Guid storeId)
        {
            _StoreId = storeId;
        }

        public int GetProductsCount()
        {
            return _productService.GetProductCount(_StoreId);
        }

        public IList<Category> GetCategories()
        {
            return _categoryService.GetCategories(_StoreId);// temporary hardcoded storeId 
        }
        public IList<Product> GetLatestProducts()
        {
            return _productService.GetLatestProducts(_StoreId);
        }

    }
}
