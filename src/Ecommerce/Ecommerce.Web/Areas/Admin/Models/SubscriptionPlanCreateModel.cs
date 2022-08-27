using Autofac;
using AutoMapper;
using Ecommerce.Store;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using System.ComponentModel.DataAnnotations;
using STORE = Ecommerce.Store.Entities.Store;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class SubscriptionPlanCreateModel
    {
        public Guid Id { get; set; }
        [StringLength(100, ErrorMessage = "Name should be less than 100 chars")]
        public string PlanName { get; set; }
        public long PlanPrice { get; set; }
        public int ProductUploadLimit { get; set; }
        public long StorageLimit { get; set; }
        public PlanColor PlanColor { get; set; }

        public IList<STORE>? Stores { get; set; }

        private ISubscriptionPlanService _subscriptionPlanService;
        private ILifetimeScope _lifetimeScope;
        private IMapper _mapper;

        public SubscriptionPlanCreateModel()
        {

        }

        public SubscriptionPlanCreateModel(IMapper mapper, ISubscriptionPlanService subscriptionPlanService)
        {
            _subscriptionPlanService = subscriptionPlanService;
            _mapper = mapper;
        }

        public void Resolve(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
            _subscriptionPlanService = _lifetimeScope.Resolve<ISubscriptionPlanService>();
            _mapper = _lifetimeScope.Resolve<IMapper>();
        }

        internal void CreateSubscriptionPlan()
        {
            var subscriptionPlan = _mapper.Map<SubscriptionPlan>(this);

            _subscriptionPlanService.CreateSubscriptionPlan(subscriptionPlan);
        }
    }
}
