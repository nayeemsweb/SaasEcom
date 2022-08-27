using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using System.ComponentModel.DataAnnotations;
using ProductBO = Ecommerce.Store.BusinessObjects.Product;
using ProductCategoryBO = Ecommerce.Store.BusinessObjects.ProductCategory;
namespace Ecommerce.Web.Areas.Admin.Models

{
    public class ProductImageModel
    {

        private IProductService _productService;
        private ILifetimeScope _scope;
        private IMapper _mapper;
        private IWebHostEnvironment _webHostEnvironment;

        public String URL { get; set; }
        public long Size { get; set; }
        //public List<Dictionary<String, long>> Urls { get; set; }
        public ProductImageModel()
        {

        }

        public ProductImageModel(IProductService productService, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _productService = productService;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
        }

        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _productService = _scope.Resolve<IProductService>();
            _mapper = _scope.Resolve<IMapper>();
        }
        public List<ProductImageModel> GetImagesByProductId(Guid productId)
        {
            var product = _productService.GetProductImageById(productId);
            //this.Urls = new List<Dictionary<String,long>>();
            var images = new List<ProductImageModel>();
            long size = 0;
            if (product.ProductImages.Count > 0)
            {
                foreach (var image in product.ProductImages)
                {
                    var currentDirectory = Directory.GetCurrentDirectory();
                    //var imagePhysicalUrl = Path.Combine(_webHostEnvironment.WebRootPath, "Files",
                    //image.Url);
                    var imagePhysicalUrl = currentDirectory + "//wwwroot/" + image.Url; 
                    FileInfo fi = new FileInfo(imagePhysicalUrl);
                    if (fi.Exists)
                    {
                        size = fi.Length;
                    }
                  
                    images.Add(new ProductImageModel() { URL = image.Url, Size = size });

                }
            }
            else
            {
                images.Add(new ProductImageModel() { URL = "Not image Found", Size = 0 });
            }
            

            return images;
        }

        
    }
}
