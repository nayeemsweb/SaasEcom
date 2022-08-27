using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Customer.Models
{
    public class ProductSubscriptionNotificationModel
    {
        private IProductSubscriptionService _productSubscriptionService;
        private ILifetimeScope _lifetimeScope;
        private IMapper _mapper;

        public ProductSubscriptionNotificationModel()
        {

        }
        public ProductSubscriptionNotificationModel(IProductSubscriptionService productSubscriptionService, IMapper mapper)
        {
            _productSubscriptionService = productSubscriptionService;
            _mapper = mapper;
        }
        public Guid Id { get; set; }        
        public string? Email { get; set; }
        public string? PhoneNo { get; set; }       
        public Guid ProductId { get; set; }



        public void Resolve(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
            _productSubscriptionService = _lifetimeScope.Resolve<IProductSubscriptionService>();
            _mapper = _lifetimeScope.Resolve<IMapper>();
        }
      

        public void SaveSubscriptionData()
        {
            var productSubscriptionNotification = _mapper.Map<ProductSubscriptionNotification>(this);

            _productSubscriptionService.CreateProductSubscriptionNotification(productSubscriptionNotification);

        }
    }
}

