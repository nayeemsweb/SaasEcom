using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using System.ComponentModel.DataAnnotations;
using ProductBO = Ecommerce.Store.BusinessObjects.Product;
using ProductCategoryBO = Ecommerce.Store.BusinessObjects.ProductCategory;
namespace Ecommerce.Web.Areas.Admin.Models

{
    public class ProductEditModel
    {

        private IProductService _productService;
        private IImageService _imageService;
        private ILifetimeScope _scope;
        private IMapper _mapper;

        public Guid Id { get; set; }

        [Required, StringLength(100, ErrorMessage = "Name should be less than 100 letters")]
        public string Name { get; set; }

        [Required, StringLength(5000, ErrorMessage = "Description should be less than 5000 characters")]
        public string Description { get; set; }


        [Range(10, 50000, ErrorMessage = "Price should be between 0 and 5000")]

        [Required]
        public decimal UnitPrice { get; set; }

        public decimal DiscountedPrice { get; set; }

        public string? Status { get; set; }
        public bool ActiveStatus { get; set; }

        public List<ProductCategoryBO>? ProductCategories { get; set; }
        public List<ProductImage>? ProductImages { get; set; }

        public Guid _StoreId { get; set; }//from View


        public string? ImageUrlsParam { get; set; }
        public ProductEditModel()
        {

        }

        public ProductEditModel(IProductService productService, IMapper mapper,
                                IImageService imageService)
        {
            _productService = productService;
            _imageService = imageService;
            _mapper = mapper;
        }

        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _productService = _scope.Resolve<IProductService>();
            _mapper = _scope.Resolve<IMapper>();
        }
        public void EditProduct(IList<string> imageUrls)
        {
            var product = _mapper.Map<ProductBO>(this);

            if (this.Status == "Active")
                product.ActiveStatus = true;
            else
                product.ActiveStatus = false;


            product.ProductImages = new List<ProductImage>();

            foreach (var images in imageUrls)
            {
                product.ProductImages?.Add(new ProductImage
                {
                    Url = images,
                });
            }


            product.StoreId = _StoreId;
            
            _productService.EditProduct(product);
        }

        internal void LoadData(Guid id)
        {
            var product = _productService.GetProductById(id);
            _mapper.Map(product, this);
            if (product.ActiveStatus == true)
                this.Status = "Active";
            else
                this.Status = "Draft";

            

        }

        internal void setStoreId(Guid StoreId)
        {
            _StoreId = StoreId;
        }
    }
}
