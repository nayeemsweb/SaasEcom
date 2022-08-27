using Ecommerce.Data;

namespace Ecommerce.Store.Entities
{
    public class SubscriptionPlan : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string PlanName { get; set; }
        public long PlanPrice { get; set; }
        public int ProductUploadLimit { get; set; }
        public double StorageLimit { get; set; }
        public string? PlanColor { get; set; }
        public bool PublicPlan { get; set; }

        //public IList<Store>? Stores { get; set; }
    }
}
