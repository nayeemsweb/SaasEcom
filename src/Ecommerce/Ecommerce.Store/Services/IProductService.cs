using Ecommerce.Store.BusinessObjects;

namespace Ecommerce.Store.Services
{
    public interface IProductService
    {
        void CreateProduct(Product product);
        void DeleteProduct(Guid id);
        void EditProduct(Product product);
        void ChangeVisibility(Guid id);
        void ChangeFeatureProperty(Guid id);
        IList<Product> GetProducts();
        IList<Product> GetProducts(Guid StoreId);//fetch product with relative storeId

        (int total, int totalDisplay, IList<Product> Products) GetActiveProducts(Guid StoreId, int pageIndex, int pageSize, string searchText, string orderBy);
        IList<Product> GetFeaturedProducts(Guid StoreId);
        IList<Product> GetFeaturedProducts(Guid StoreId, int pageIndex, int pageSize, string searchText, string orderBy);
        IList<Product> GetFeaturedProducts();
        (int total, int totalDisplay, IList<Product> Products) GetProducts(Guid StoreId, int pageIndex, int pageSize, string searchText, string orderBy);

        (int total, int totalDisplay, IList<Product> products)
            GetGridProducts(Guid StoreId, int pageIndex, int pageSize,
            string searchText, string orderBy);

        int GetProductCount();
        int GetProductCount(Guid StoreId);
        Product GetProductById(Guid Id);
        Product GetActiveProductById(Guid Id);
        Product GetProductImageById(Guid Id);
        Product GetProductByProductAndStoreId(Guid productId, Guid StoreId);
        IList<Product> GetProductsByProductAndStoreId(Guid productId, Guid StoreId);
        Product GetProductForWishlistById(Guid Id);

        public (int total, int totalDisplay, IList<Product> trashedProducts) GetTrashedProducts(Guid StoreId, int pageIndex,
           int pageSize, string searchText, string orderBy);

        decimal GetProductPrice(Guid Id, Guid StoreId);

        IList<Product> GetLatestProducts(Guid StoreId);
    }
}