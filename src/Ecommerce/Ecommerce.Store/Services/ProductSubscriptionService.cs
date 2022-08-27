using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.UnitOfWorks;
using ProductSubscriptionNotificationEntity = Ecommerce.Store.Entities.ProductSubscriptionNotification;

namespace Ecommerce.Store.Services
{
    public class ProductSubscriptionService : IProductSubscriptionService
    {
        private readonly IProductSubscriptionUnitOfWork _productSubscriptionUnitOfWork;
        private readonly IMapper _mapper;

        public ProductSubscriptionService(IMapper mapper,
            IProductSubscriptionUnitOfWork productSubscriptionUnitOfWork)
        {
            _productSubscriptionUnitOfWork = productSubscriptionUnitOfWork;
            _mapper = mapper;
        }


        public void CreateProductSubscriptionNotification(ProductSubscriptionNotification productSubscriptionNotification)
        {
            var productSubscriptionCount = _productSubscriptionUnitOfWork.ProductSubscriptionNotifications
                .GetCount(x => x.Email == productSubscriptionNotification.Email);

            var entity = _mapper.Map<ProductSubscriptionNotificationEntity>(productSubscriptionNotification);

            _productSubscriptionUnitOfWork.ProductSubscriptionNotifications.Add(entity);
            _productSubscriptionUnitOfWork.Save();


        }

        public (int total, int totalDisplay, IList<ProductSubscriptionNotification> records) GetproductSubscriptionNotifications(int pageIndex,
       int pageSize, string searchText, string orderBy)
        {
            var result = _productSubscriptionUnitOfWork.ProductSubscriptionNotifications.GetDynamic(x => x.Email.Contains(searchText) && x.IsArchived == false,
                orderBy, string.Empty, pageIndex, pageSize, true);

            List<ProductSubscriptionNotification> productSubscriptionNotifications = new List<ProductSubscriptionNotification>();
            foreach (ProductSubscriptionNotificationEntity productSubscriptionNotification in result.data)
            {
                productSubscriptionNotifications.Add(_mapper.Map<ProductSubscriptionNotification>(productSubscriptionNotification));
            }

            return (result.total, result.totalDisplay, productSubscriptionNotifications);
        }

        public (int total, int totalDisplay, IList<ProductSubscriptionNotification> records) GetAllArchivedSubscriptions(int pageIndex,
         int pageSize, string searchText, string orderBy)
        {
            var result = _productSubscriptionUnitOfWork.ProductSubscriptionNotifications.GetDynamic(x => x.Email.Contains(searchText) && x.IsArchived == true,
                orderBy, string.Empty, pageIndex, pageSize, true);

            List<ProductSubscriptionNotification> productSubscriptionNotifications = new List<ProductSubscriptionNotification>();
            foreach (ProductSubscriptionNotificationEntity productSubscriptionNotification in result.data)
            {
                productSubscriptionNotifications.Add(_mapper.Map<ProductSubscriptionNotification>(productSubscriptionNotification));
            }

            return (result.total, result.totalDisplay, productSubscriptionNotifications);
        }

        //public void DeleteProduct(Guid id)
        //{
        //    _productUnitOfWork.Products.Remove(id);
        //    _productUnitOfWork.Save();
        //}

        //public void EditProduct(Product product)
        //{
        //    var productEntity = _productUnitOfWork.Products.GetById(product.Id);

        //    productEntity = _mapper.Map(product, productEntity);

        //    _productUnitOfWork.Save();
        //}
        //public void ChangeVisibility(Guid id)
        //{
        //    var productEntity = _productUnitOfWork.Products.GetById(id);

        //    productEntity.ActiveStatus = (productEntity.ActiveStatus) ? false : true;
        //    _productUnitOfWork.Save();
        //}


        //public int GetProductCount()
        //{
        //    return _productUnitOfWork.Products.GetAll().Count();

        //}


        //public (int total, int totalDisplay, IList<Product> Products) GetProducts(Guid StoreId, int pageIndex,
        //    int pageSize, string searchText, string orderBy)
        //{
        //    var result = _productUnitOfWork.Products.GetDynamic(x => x.StoreId == StoreId
        //        && x.Name.Contains(searchText),
        //        orderBy, "ProductImages,ProductCategories,ProductInventory", pageIndex, pageSize, true);

        //    List<Product> products = new List<Product>();
        //    foreach (ProductEntity product in result.data)
        //    {
        //        products.Add(_mapper.Map<Product>(product));
        //    }

        //    return (result.total, result.totalDisplay, products);
        //}

        //public (int total, int totalDisplay, IList<Product> products)
        //    GetProducts(int pageIndex, int pageSize,
        //    string searchText, string orderBy)
        //{
        //    var result = _productUnitOfWork.Products.GetDynamic(
        //        x => x.Name.Contains(searchText),
        //        orderBy, "ProductImages,ProductCategories,Reviews", pageIndex, pageSize, true
        //        );


        //    List<Product> products = new List<Product>();
        //    foreach (ProductEntity product in result.data)
        //    {
        //        products.Add(_mapper.Map<Product>(product));
        //    }

        //    return (result.total, result.totalDisplay, products);
        //}


        //public Product GetProductById(Guid id)
        //{
        //    var result = _productUnitOfWork.
        //        Products.Get(x => x.Id.Equals(id),
        //        "ProductImages,ProductCategories,Reviews");

        //    var product = _mapper.Map<Product>(result[0]);

        //    return product;
        //}


        //public IList<Product> GetProducts()
        //{
        //    var productEntities = _productUnitOfWork.Products.GetAll();

        //    List<Product> products = new List<Product>();

        //    foreach (ProductEntity entity in productEntities)
        //    {
        //        products.Add(_mapper.Map<Product>(entity));
        //    }

        //    return products;
        //}


        ////fetch product from db with specific store
        //public IList<Product> GetProducts(Guid StoreId)
        //{
        //    var productEntities = _productUnitOfWork.Products.
        //            GetDynamic(x => x.StoreId == StoreId, "", "ProductImages,ProductCategories,ProductInventory", false);

        //    List<Product> products = new List<Product>();

        //    foreach (ProductEntity entity in productEntities)
        //    {
        //        products.Add(_mapper.Map<Product>(entity));
        //    }

        //    return products;
        //}

        public void DeleteProductSubscriptionNotification(Guid id)
        {
            _productSubscriptionUnitOfWork.ProductSubscriptionNotifications.Remove(id);
            _productSubscriptionUnitOfWork.Save();
        }

        public void EditProductSubscriptionNotification(ProductSubscriptionNotification productSubscriptionNotification)
        {
            var productSubscriptionNotificationCount = _productSubscriptionUnitOfWork.ProductSubscriptionNotifications
                .GetCount(x => x.Email == productSubscriptionNotification.Email
                && x.Id != productSubscriptionNotification.Id);

            if (productSubscriptionNotificationCount == 0)
            {
                var productSubscriptionNotificationEntity = _productSubscriptionUnitOfWork.ProductSubscriptionNotifications.GetById(productSubscriptionNotification.Id);

                productSubscriptionNotificationEntity = _mapper.Map(productSubscriptionNotification, productSubscriptionNotificationEntity);

                _productSubscriptionUnitOfWork.Save();
            }
            //else
            //    throw new DuplicateException("Course name already exists");
        }

        public void ArchiveNotification(Guid id)
        {                    
                var productSubscriptionNotificationEntity = _productSubscriptionUnitOfWork.ProductSubscriptionNotifications.GetById(id);
                
                productSubscriptionNotificationEntity.IsArchived = true;               

                _productSubscriptionUnitOfWork.Save();
            
        }

        public ProductSubscriptionNotification GetProductSubscriptionNotification(Guid id)
        {
            var productSubscriptionEntity = _productSubscriptionUnitOfWork.ProductSubscriptionNotifications.GetById(id);

            var productSubscriptionNotification = _mapper.Map<ProductSubscriptionNotification>(productSubscriptionEntity);

            return productSubscriptionNotification;
        }


    }
}

