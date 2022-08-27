using System.ComponentModel;
using Ecommerce.Data;

namespace Ecommerce.Store.Entities
{
    public class AdminMenuSection : BaseEntity,IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public string SectionName { get; set; }
        public int DisplayOrder { get; set; }

    }
}
