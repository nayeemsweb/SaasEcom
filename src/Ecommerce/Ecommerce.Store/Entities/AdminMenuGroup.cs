using System.ComponentModel;
using Ecommerce.Data;

namespace Ecommerce.Store.Entities
{
    public class AdminMenuGroup : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public string GroupName { get; set; }
        public string IconClass { get; set; }
        public int DisplayOrder { get; set; }

    }
}
