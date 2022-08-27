using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class ProductDeleteModel
    {
        private readonly IProductService _productService;
        private readonly IProductRestoreService _productRestoreService;

        public ProductDeleteModel(IProductService productService, IProductRestoreService productRestoreService)
        {
            _productService = productService;
            _productRestoreService = productRestoreService;
        }

        //public  void Delete(Guid id)
        //{
        //    _productService.DeleteProduct(id);
        //}
        public void makeTrash(Guid ProductId, Guid StoreId)
        {
            var product = _productService.GetProductByProductAndStoreId(ProductId, StoreId);
            product.Featured = false;//removed from feature
            product.ActiveStatus = false;//removed from feed
            product.DeleteQueue = true;//moved to delete queue

            var trashedProduct = new ProductDelete();
            trashedProduct.ProductId = product.Id;//product id assigned
            trashedProduct.StoreId = product.StoreId;//store id assigned
            trashedProduct.TriggeredOn = DateTime.Now;//delete triggered time

            //edited as it moved to trash table
            _productService.EditProduct(product);
            _productRestoreService.Add(trashedProduct);//added to trash table
            //_productService.DeleteProduct(id);
        }

        public void Restore(Guid productId)
        {
            var product = _productService.GetProductById(productId);
            product.Featured = false;// reamin removed from feature after restore
            product.ActiveStatus = false;// reamin removed from feed after restore
            product.DeleteQueue = false;//moved from delete queue

            //edited as it moved from trash table
            _productService.EditProduct(product);

            var trashedProduct = _productRestoreService.GetTrashByProductId(productId);
            _productRestoreService.Remove(trashedProduct.Id);//removed from trash table
        }
        public void ForceDelete(Guid productId)
        {
            var product = _productService.GetProductById(productId);
            var trashedProduct = _productRestoreService.GetTrashByProductId(productId);

            _productService.DeleteProduct(product.Id);//removed from product table;
            _productRestoreService.Remove(trashedProduct.Id);//removed from trash table
        }
    }
}
