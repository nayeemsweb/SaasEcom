using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using System.ComponentModel.DataAnnotations;
using ProductCategoryBO = Ecommerce.Store.BusinessObjects.ProductCategory;
using ProductBO = Ecommerce.Store.BusinessObjects.Product;
using InventoryBO = Ecommerce.Store.BusinessObjects.Inventory;
namespace Ecommerce.Web.Areas.Admin.Models
{
    public class ProductAddModel
    {
        private IProductService _productService;
        private ILifetimeScope _scope;
        private IMapper _mapper;

        [Required, StringLength(100, ErrorMessage = "Name should be less than 100 letters")]
        public string Name { get; set; }

        [Required, StringLength(5000, ErrorMessage = "Description should be less than 5000 characters")]
        public string Description { get; set; }

        [Range(10, 50000, ErrorMessage = "Price should be between 10 and 50000")]

        [Required]
        public decimal UnitPrice { get; set; }

        public decimal DiscountedPrice { get; set; }

        public string? Status { get; set; }

        public string? ImageUrlsParam { get; set; }

        public string? CategoriesId { get; set; }

        public List<ProductImage>? ProductImages { get; set; }

        public bool ActiveStatus { get; set; }

        public Guid _StoreId { get; set; }//from view

        //[Required]
        //public int  StockQuantity { get; set; }
        public List<ProductCategoryBO>? ProductCategories { get; set; }

        public ProductAddModel()
        {

        }

        public ProductAddModel(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _productService = _scope.Resolve<IProductService>();
            _mapper = _scope.Resolve<IMapper>();
        }
        internal void setStoreId(Guid StoreId)
        {
            _StoreId = StoreId;
        }

        public void CreateProduct(IList<string> imageUrls, string[] categoriesId)
        {

            var product = _mapper.Map<ProductBO>(this);
            if (this.Status == "Active")
                product.ActiveStatus = true;
            else
                product.ActiveStatus = false;

            product.ProductImages = new List<ProductImage>();
            product.ProductCategories = new List<ProductCategoryBO>();
            foreach (var images in imageUrls)
            {
                product.ProductImages?.Add(new ProductImage
                {
                    Url = images,
                });
            }

            foreach (var id in categoriesId)
            {
                if (id == "default")
                {
                    product.ProductCategories?.Add(new ProductCategoryBO
                    {
                        CategoryId = new Guid("C405483E-B35C-4C4E-9E7E-387B5527F0B7")
                    });
                }
                else
                {
                    product.ProductCategories?.Add(new ProductCategoryBO
                    {
                        CategoryId = new Guid(id)
                    });
                }
                      
            }

            product.StoreId = _StoreId;
            if (product.DiscountedPrice > product.UnitPrice)
            {
                throw new Exception("Discounted price cant be greater than unit price");
            }
            else
               _productService.CreateProduct(product);
        }

    }
}

