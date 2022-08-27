using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class ProductFeatureChangeModel
    {
        private readonly IProductService _productService;
        public ProductFeatureChangeModel(IProductService productService)
        {
            _productService = productService;
        }
        public void changeFeatureProperty(Guid id)
        {
            _productService.ChangeFeatureProperty(id);
        }
    }
}
