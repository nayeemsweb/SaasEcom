using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using STORE = Ecommerce.Store.BusinessObjects.Store;
namespace Ecommerce.Web.Areas.Customer.Models
{
    public class ShopIndexModel
    {
        private ILifetimeScope _scope;
        private ICategoryService _categoryService;
        private IProductService _productService;
        private IStoreService _storeService;
        private IMapper _mapper;
        private Guid _storeId;//will get from view
        public STORE store;

    


        // public List<STORE>? Stores { get; set; }

        public ShopIndexModel()
        {

        }
        public ShopIndexModel(ILifetimeScope scope,
            ICategoryService categoryService,
            IProductService productService,
            IStoreService storeService,
            IMapper mapper)
        {
            _scope = scope;
            _categoryService = categoryService;
            _productService = productService;
            _storeService = storeService;
            _mapper = mapper;
        }
        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _categoryService = _scope.Resolve<ICategoryService>();
            _productService = _scope.Resolve<IProductService>();
            _storeService = _scope.Resolve<IStoreService>();
            _mapper = _scope.Resolve<IMapper>();
        }
        internal void setStoreId(string storeId)
        {
            _storeId = new Guid(storeId);
        }
        public IList<Category> GetCategories()
        {
            return _categoryService.GetCategories(_storeId);
        }
        public STORE getStoreInfo()
        {
            var store = _storeService.GetStore(_storeId);
            return store;
        }
        public IList<Product> FeaturedProducts()
        {
            //return _productService.GetFeaturedProducts(_storeId);
            return _productService.GetFeaturedProducts();
        }

        internal object loadFeatureProduct(int steps, int volume)
        {
            return _productService.GetFeaturedProducts(_storeId, steps, volume, null, null);
        }
    }
}
