using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.UnitOfWorks;
using SubscriptionPlanEntity = Ecommerce.Store.Entities.SubscriptionPlan;


namespace Ecommerce.Store.Services
{
    public class SubscriptionPlanService : ISubscriptionPlanService
    {
        private readonly ISubscriptionPlanUnitOfWork _subscriptionPlanUnitOfWork;
        private readonly IMapper _mapper;

        public SubscriptionPlanService(ISubscriptionPlanUnitOfWork subscriptionPlanUnitOfWork, IMapper mapper)
        {
            _subscriptionPlanUnitOfWork = subscriptionPlanUnitOfWork;
            _mapper = mapper;
        }

        public void CreateSubscriptionPlan(SubscriptionPlan subscriptionPlan)
        {
            var subscriptionPlanCount = _subscriptionPlanUnitOfWork.SubscriptionPlans
                .GetCount(x => x.PlanName == subscriptionPlan.PlanName);

            var entity = _mapper.Map<SubscriptionPlanEntity>(subscriptionPlan);

            _subscriptionPlanUnitOfWork.SubscriptionPlans.Add(entity);
            _subscriptionPlanUnitOfWork.Save();
        }

        public void DeleteSubscriptionPlan(Guid id)
        {
            _subscriptionPlanUnitOfWork.SubscriptionPlans.Remove(id);
            _subscriptionPlanUnitOfWork.Save();
        }

        public void EditSubscriptionPlan(SubscriptionPlan subscriptionPlan)
        {
            var subscriptionPlanEntity = _subscriptionPlanUnitOfWork.SubscriptionPlans.GetById(subscriptionPlan.Id);

            subscriptionPlanEntity = _mapper.Map(subscriptionPlan, subscriptionPlanEntity);

            _subscriptionPlanUnitOfWork.Save();
        }

        public SubscriptionPlan GetSubscriptionPlan(Guid id)
        {
            var subscriptionPlanEntity = _subscriptionPlanUnitOfWork.SubscriptionPlans.GetById(id);

            var subscriptionPlan = _mapper.Map<SubscriptionPlan>(subscriptionPlanEntity);

            return subscriptionPlan;
        }

        public (int total, int totalDisplay, IList<SubscriptionPlan> records) GetSubscriptionPlanes(int pageIndex,
            int pageSize, string searchText, string orderBy)
        {
            var result = _subscriptionPlanUnitOfWork.SubscriptionPlans.GetDynamic(x => x.PlanName.Contains(searchText),
                orderBy, string.Empty, pageIndex, pageSize, true);

            List<SubscriptionPlan> subscriptionPlans = new List<SubscriptionPlan>();
            foreach (SubscriptionPlanEntity subscriptionPlan in result.data)
            {
                subscriptionPlans.Add(_mapper.Map<SubscriptionPlan>(subscriptionPlan));
            }

            return (result.total, result.totalDisplay, subscriptionPlans);
        }

        public IList<SubscriptionPlan> GetSubscriptionPlanes(Guid StoreId)
        {
            var subscriptionPlanEntities = _subscriptionPlanUnitOfWork.SubscriptionPlans.GetAll();

            List<SubscriptionPlan> categories = new List<SubscriptionPlan>();

            foreach (SubscriptionPlanEntity entity in subscriptionPlanEntities)
            {
                categories.Add(_mapper.Map<SubscriptionPlan>(entity));
            }

            return categories;
        }
        public IList<SubscriptionPlan> GetSubscriptionPlans()
        {
            var subscriptionEntities=_subscriptionPlanUnitOfWork.SubscriptionPlans.GetAll();
            
            var subscriptionPlans = new List<SubscriptionPlan>();
            foreach(var entity in subscriptionEntities)
                subscriptionPlans.Add(_mapper.Map<SubscriptionPlan>(entity));
            
            return subscriptionPlans;
        }
        public IList<SubscriptionPlan> GetPublicSubscriptionPlans()
        {
            var subscriptionEntities = _subscriptionPlanUnitOfWork.SubscriptionPlans.Get(x=>x.PublicPlan, string.Empty);

            var subscriptionPlans = new List<SubscriptionPlan>();
            foreach (var entity in subscriptionEntities)
                subscriptionPlans.Add(_mapper.Map<SubscriptionPlan>(entity));

            return subscriptionPlans;
        }
    }
}
