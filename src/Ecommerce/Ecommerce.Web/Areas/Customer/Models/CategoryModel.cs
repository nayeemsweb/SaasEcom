using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using Ecommerce.Data;


namespace Ecommerce.Web.Areas.Customer.Models
{
    public class CategoryModel
    {
        private ILifetimeScope _scope;
        private ICategoryService _categoryService;
        private IProductService _productService;
        private IStoreService _storeService;
        private IMapper _mapper;

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Guid StoreId { get; set; }


        private Guid _categoryId;//will come from View

        public CategoryModel()
        {

        }
        public CategoryModel(ILifetimeScope scope,
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

        internal void setCategoryId(Guid categoryId)
        {
            _categoryId = categoryId;
        }

        internal void getCurrentCategory()
        {
            var currentCategory = _categoryService.GetCategory(_categoryId);
            _mapper.Map(currentCategory, this);
        }

        internal IList<Category> getCategories()//get other categories of that shop
        {
            return _categoryService.GetCategories(Id);
        }

       



        //load required products filtered by category
        //pagination done with store procedure
        //from ProductCategories -> Products
        internal IList<Product> LoadProducts(int pageIndex, int pageSize)
        {
            string StoreProcedureName = "GetActiveProductByCategoryId";
            
            var productCategories = _categoryService.GetActiveProductsByCategoryId(StoreProcedureName, 
                        pageIndex, pageSize, _categoryId);

            var products = new List<Product>();
            foreach(var item in productCategories)
                products.Add(_productService.GetActiveProductById(item.ProductId));

            return products;
        }

        
    }
}
