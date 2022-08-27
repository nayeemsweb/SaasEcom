using Autofac;
using AutoMapper;
using Ecommerce.Store;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using System.ComponentModel.DataAnnotations;
using STORE = Ecommerce.Store.BusinessObjects.Store;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class SubscriptionPlanModel
    {
        private ILifetimeScope _scope;
        private ISubscriptionPlanService _SubscriptionPlanService;
        private IMapper _mapper;

        public string PlanId{get;set; }//only for view hidden
        public Guid Id { get; set; }
        public string PlanName { get; set; }
        public long PlanPrice { get; set; }
        public int ProductUploadLimit { get; set; }
        public double StorageLimit { get; set; }
        public string PlanColor { get; set; }
        public bool PublicPlan { get; set; }
        
        
        // public List<STORE>? Stores { get; set; }

        public SubscriptionPlanModel()
        {

        }
        public SubscriptionPlanModel(ILifetimeScope scope, 
            ISubscriptionPlanService SubscriptionPlanService, IMapper mapper)
        {
            _scope = scope;
            _SubscriptionPlanService = SubscriptionPlanService;
            _mapper = mapper;
        }
        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _SubscriptionPlanService = _scope.Resolve<ISubscriptionPlanService>();
            _mapper = _scope.Resolve<IMapper>();
        }
        public void AddPlan()
        {
            var plan = _mapper.Map<SubscriptionPlan>(this);
            _SubscriptionPlanService.CreateSubscriptionPlan(plan);
        }
        public IList<SubscriptionPlan> getPlans()
        {
            return _SubscriptionPlanService.GetSubscriptionPlans();            
        }
        public SubscriptionPlan GetPlan(Guid Id)
        {
            return _SubscriptionPlanService.GetSubscriptionPlan(Id);
        }
        public void EditPlan()
        {
            var plan = _mapper.Map<SubscriptionPlan>(this);
            _SubscriptionPlanService.EditSubscriptionPlan(plan);
        }
        public IList<SubscriptionPlan> getPublicPlans()
        {
            return _SubscriptionPlanService.GetSubscriptionPlans();
        }
        public void Delete(Guid id)
        {
            _SubscriptionPlanService.DeleteSubscriptionPlan(id);
        }

        public void DeletePlan(Guid Id)
        {
            _SubscriptionPlanService.DeleteSubscriptionPlan(Id);
        }
    }
}
