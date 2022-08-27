using Ecommerce.Common;
using Ecommerce.Store;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using STORE = Ecommerce.Store.Entities.Store;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class SubscriptionPlanListModel
    {
        public Guid Id { get; set; }
        public string PlanName { get; set; }
        public long PlanPrice { get; set; }
        public int ProductUploadLimit { get; set; }
        public long StorageLimit { get; set; }
        public PlanColor PlanColor { get; set; }

        public IList<STORE>? Stores { get; set; }

        private readonly ISubscriptionPlanService _subscriptionPlanService;

        public SubscriptionPlanListModel(ISubscriptionPlanService subscriptionPlanService)
        {
            _subscriptionPlanService = subscriptionPlanService;
        }

        public object GetPagedSubscriptionPlanes(DataTablesAjaxRequestModel model)
        {
            var data = _subscriptionPlanService.GetSubscriptionPlanes(
                model.PageIndex,
                model.PageSize,
                model.SearchText,
                model.GetSortText(new string[] { "PlanName", "PlanPrice", "ProductUploadLimit", "StorageLimit", "PlanColor" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string?[]
                        {
                            record.PlanName,
                            record.PlanPrice.ToString(),
                            record.ProductUploadLimit.ToString(),
                            record.StorageLimit.ToString(),
                            record.PlanColor.ToString(),
                            record.Id.ToString()
                        }
                    ).ToArray()
            };
        }

        public IList<SubscriptionPlan> GetAllSubscriptionPlans()
        {
            return _subscriptionPlanService.GetSubscriptionPlans();
        }
    }
}
