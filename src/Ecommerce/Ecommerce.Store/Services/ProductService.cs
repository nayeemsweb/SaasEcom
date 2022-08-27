using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Exceptions;
using Ecommerce.Store.UnitOfWorks;
using ProductEntity = Ecommerce.Store.Entities.Product;

namespace Ecommerce.Store.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductUnitOfWork _productUnitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper,
            IProductUnitOfWork productUnitOfWork)
        {
            _productUnitOfWork = productUnitOfWork;
            _mapper = mapper;
        }


        public void CreateProduct(Product product)
        {
            var productCount = _productUnitOfWork.Products
                .GetCount(x => x.Name == product.Name && x.StoreId==product.StoreId);

            if (productCount == 0)
            {
                var entity = _mapper.Map<ProductEntity>(product);

                _productUnitOfWork.Products.Add(entity);
                _productUnitOfWork.Save();
            }
            else
                throw new DuplicateException("product with same name already exists");
        }

        public void DeleteProduct(Guid id)
        {
            _productUnitOfWork.Products.Remove(id);
            _productUnitOfWork.Save();
        }

        public void EditProduct(Product product)
        {

            var productCount = _productUnitOfWork.Products
              .GetCount(x => x.Name == product.Name && x.Id != product.Id && x.StoreId==product.StoreId);

            if (productCount == 0)
            {

                var productEntity = _productUnitOfWork.Products.Get(x => x.Id.Equals(product.Id),
                                    "ProductImages").FirstOrDefault();

                product.CreatedAt = productEntity.CreatedAt;

                productEntity.ProductImages = null;


                productEntity = _mapper.Map(product, productEntity);

                _productUnitOfWork.Save();

            }
            else
                throw new DuplicateException("Product name already exists");
        }
        public void ChangeVisibility(Guid id)
        {
            var productEntity = _productUnitOfWork.Products.GetById(id);

            productEntity.ActiveStatus = (productEntity.ActiveStatus) ? false : true;
            _productUnitOfWork.Save();
        }
        public void ChangeFeatureProperty(Guid id)
        {
            var productEntity = _productUnitOfWork.Products.GetById(id);

            productEntity.Featured = (productEntity.Featured) ? false : true;
            _productUnitOfWork.Save();
        }


        public int GetProductCount()
        {
            return _productUnitOfWork.Products.GetAll().Count();

        }
        public int GetProductCount(Guid StoreId)
        {
            return _productUnitOfWork.Products.Get(x=>x.StoreId==StoreId&&x.ActiveStatus, string.Empty).Count();

        }

        public (int total, int totalDisplay, IList<Product> Products) GetProducts(Guid StoreId, int pageIndex,
            int pageSize, string searchText, string orderBy)
        {
            var result = _productUnitOfWork.Products.GetDynamic(x => x.StoreId == StoreId
                && x.Name.Contains(searchText),
                orderBy, "ProductImages,ProductCategories,ProductInventory", pageIndex, pageSize, true);

            List<Product> products = new List<Product>();
            foreach (ProductEntity product in result.data)
            {
                products.Add(_mapper.Map<Product>(product));
            }

            return (result.total, result.totalDisplay, products);
        }

        public (int total, int totalDisplay, IList<Product> products)
            GetGridProducts(Guid StoreId, int pageIndex, int pageSize,
            string searchText, string orderBy)
        {
            var result = _productUnitOfWork.Products.GetDynamic(
                x => x.Name.Contains(searchText) && x.ActiveStatus == true && x.StoreId==StoreId,
                orderBy, "ProductImages,ProductCategories,Reviews", pageIndex, pageSize, true
                );

            List<Product> products = new List<Product>();
            foreach (ProductEntity product in result.data)
            {
                products.Add(_mapper.Map<Product>(product));
            }

            return (result.total, result.totalDisplay, products);
        }


        public Product GetProductById(Guid Id)
        {
            var result = _productUnitOfWork.
                Products.Get(x => x.Id.Equals(Id),
                "ProductImages,ProductCategories,Reviews").FirstOrDefault();

            var product = _mapper.Map<Product>(result);
            return product;
        }
        public Product GetActiveProductById(Guid Id)
        {
            var product = _productUnitOfWork.Products.Get(x => x.Id == Id && x.ActiveStatus,
                            "ProductImages,ProductCategories,Reviews").FirstOrDefault();
            return _mapper.Map<Product>(product);
        }

        public Product GetProductForWishlistById(Guid Id)
        {
            var result = _productUnitOfWork.
                Products.Get(x => x.Id.Equals(Id),
                "ProductImages").FirstOrDefault();
            var product = _mapper.Map<Product>(result);
            return product;
        }

        public IList<Product> GetProducts()
        {
            var productEntities = _productUnitOfWork.Products.GetAll();

            List<Product> products = new List<Product>();

            foreach (ProductEntity entity in productEntities)
            {
                products.Add(_mapper.Map<Product>(entity));
            }

            return products;
        }


        //get Price for an invidual Product by Id 

        public decimal GetProductPrice(Guid Id, Guid StoreId)
        {
            var result = _productUnitOfWork.
                Products.Get(x => x.Id.Equals(Id) &&
                x.StoreId.Equals(StoreId), string.Empty).FirstOrDefault();

            var product = _mapper.Map<Product>(result);

            return product.UnitPrice - product.DiscountedPrice;
        }


        //fetch product from db with specific store
        public IList<Product> GetProducts(Guid StoreId)
        {
            var productEntities = _productUnitOfWork.Products.
                    GetDynamic(x => x.StoreId == StoreId, "", "ProductImages,ProductCategories," +
                    "ProductInventory", false);

            List<Product> products = new List<Product>();

            foreach (ProductEntity entity in productEntities)
            {
                products.Add(_mapper.Map<Product>(entity));
            }

            return products;
        }

        public (int total, int totalDisplay, IList<Product> Products) GetActiveProducts(Guid StoreId, int pageIndex, int pageSize, string searchText, string orderBy)
        {
            var result = _productUnitOfWork.Products.GetDynamic(x => x.StoreId == StoreId
                && x.Name.Contains(searchText) && !x.DeleteQueue,
                orderBy, "ProductImages,ProductCategories,ProductInventory", pageIndex, pageSize, true);

            List<Product> products = new List<Product>();
            foreach (ProductEntity product in result.data)
            {
                products.Add(_mapper.Map<Product>(product));
            }

            return (result.total, result.totalDisplay, products);
        }
        public IList<Product> GetFeaturedProducts()
        {
            var productEntities = _productUnitOfWork.Products.GetDynamic
                (x => x.Featured, null,
                "ProductImages,ProductCategories,ProductInventory", false);
            List<Product> products = new List<Product>();
            foreach (ProductEntity product in productEntities)
            {
                products.Add(_mapper.Map<Product>(product));
            }
            return products;
        }
        public IList<Product> GetFeaturedProducts(Guid StoreId)
        {
            var productEntities = _productUnitOfWork.Products.GetDynamic
                (x => x.StoreId == StoreId && x.Featured, null,
                "ProductImages,ProductCategories,ProductInventory", false);
            List<Product> products = new List<Product>();
            foreach (ProductEntity product in productEntities)
            {
                products.Add(_mapper.Map<Product>(product));
            }
            return products;
        }
        public IList<Product> GetFeaturedProducts(Guid StoreId, int pageIndex, int pageSize, string searchText, string orderBy)
        {
            var productEntites = _productUnitOfWork.Products.GetDynamic(x => x.StoreId == StoreId && x.Featured,
                orderBy, "ProductImages", pageIndex, pageSize, true);
            List<Product> Products = new List<Product>();
            foreach (var product in productEntites.data)
                Products.Add(_mapper.Map<Product>(product));
            return Products;
        }


        public Product GetProductByProductAndStoreId(Guid productId, Guid StoreId)
        {
            var productEntity = _productUnitOfWork.Products.Get(x => x.Id == productId
               && x.StoreId == StoreId, string.Empty).FirstOrDefault();

            return _mapper.Map<Product>(productEntity);
        }

        public IList<Product> GetProductsByProductAndStoreId(Guid productId, Guid StoreId)
        {
            var productEntity = _productUnitOfWork.Products.Get(x => x.Id == productId
                            && x.StoreId == StoreId, string.Empty);

            IList<Product> products = new List<Product>();
            foreach (var product in productEntity)
                _mapper.Map(product, products);
            return products;
        }

        public (int total, int totalDisplay, IList<Product> trashedProducts) GetTrashedProducts(Guid StoreId,
            int pageIndex, int pageSize, string searchText, string orderBy)
        {
            var result = _productUnitOfWork.Products.GetDynamic(x => x.StoreId == StoreId && x.DeleteQueue,
                orderBy, "ProductImages,ProductCategories,ProductInventory", pageIndex, pageSize, true);


            IList<Product> trashedProducts = new List<Product>();
            foreach (var product in result.data)
            {
                trashedProducts.Add(_mapper.Map<Product>(product));
            }

            return (result.total, result.totalDisplay, trashedProducts);
        }

        public Product GetProductImageById(Guid Id)
        {
            var result = _productUnitOfWork.
                 Products.Get(x => x.Id.Equals(Id),
                 "ProductImages").FirstOrDefault();

            var product = _mapper.Map<Product>(result);
            return product;
        }

        public IList<Product> GetLatestProducts(Guid StoreId)
        {
            var date = DateTime.Now.AddDays(-7);
            var result = _productUnitOfWork.Products.
                          Get(x => x.StoreId == StoreId && x.CreatedAt >= date, "ProductImages");

            List<Product> products = new List<Product>();

            foreach (ProductEntity entity in result)
            {
                products.Add(_mapper.Map<Product>(entity));
            }

            return products;

        }


    }
}

