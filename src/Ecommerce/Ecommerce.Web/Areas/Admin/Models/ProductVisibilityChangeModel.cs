using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class ProductVisibilityChangeModel
    {
        private readonly IProductService _productService;
        public ProductVisibilityChangeModel(IProductService productService)
        {
            _productService = productService;
        }
        public void changeVisibility(Guid id)
        {
            var product = _productService.GetProductById(id);
            product.Featured = false;//for unpublishing product, it's also will remove from feature
            
            //edited as it removed from feature
            _productService.EditProduct(product);
            _productService.ChangeVisibility(id);
        }
    }
}
