using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class ProductSubscriptionArchivedModel
    {
        private IProductSubscriptionService _productSubscriptionService;
        private readonly IProductService _productService;
        private ILifetimeScope _scope;
        private IMapper _mapper;

        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? PhoneNo { get; set; }
        public DateTime Time { get; set; }
        public Guid StoreId { get; set; }
        public Guid ProductId { get; set; }

        public Product Product { get; set; }
        public string ProductImageUrl { get; set; }

        public ProductSubscriptionArchivedModel()
        {

        }

        public ProductSubscriptionArchivedModel(IMapper mapper, IProductSubscriptionService productSubscriptionService, IProductService productService)
        {
            _productSubscriptionService = productSubscriptionService;
            _productService = productService;
            _mapper = mapper;
        }

        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _productSubscriptionService = _scope.Resolve<IProductSubscriptionService>();
            _mapper = _scope.Resolve<IMapper>();
        }

        public void ArchiveSubscriptionNotification()
        {
            var productSubscriptionNotification = _mapper.Map<ProductSubscriptionNotification>(this);

            //_productSubscriptionService.ArchiveSubscriptionNotification(productSubscriptionNotification);
        }

        public void LoadData(Guid id)
        {
            var productSubscriptionNotification = _productSubscriptionService.GetProductSubscriptionNotification(id);
             
             Product = _productService.GetProductById(productSubscriptionNotification.ProductId);
             
             foreach(var productImage in Product.ProductImages)
             {
                if(Product.Id == productImage.ProductId)
                {
                    ProductImageUrl = productImage.Url;
                }
             }
            _mapper.Map(productSubscriptionNotification, this);
        }
      
    }
}