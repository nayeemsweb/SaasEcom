using Ecommerce.Store.BusinessObjects;

namespace Ecommerce.Store.Services
{
    public interface ISubscriptionPlanService
    {
        void CreateSubscriptionPlan(SubscriptionPlan subscriptionPlan);
        void DeleteSubscriptionPlan(Guid id);
        void EditSubscriptionPlan(SubscriptionPlan subscriptionPlan);
        SubscriptionPlan GetSubscriptionPlan(Guid id);
        (int total, int totalDisplay, IList<SubscriptionPlan> records) GetSubscriptionPlanes(int pageIndex,
            int pageSize, string searchText, string orderBy);
        IList<SubscriptionPlan> GetSubscriptionPlanes(Guid StoreId);
        IList<SubscriptionPlan> GetSubscriptionPlans();//get all subscription plan
        IList<SubscriptionPlan> GetPublicSubscriptionPlans();//get all subscription plan
    }
}
