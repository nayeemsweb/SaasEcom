using System.ComponentModel;
using Ecommerce.Data;

namespace Ecommerce.Store.BusinessObjects
{
    public class AdminMenuSection : BaseClass
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public string SectionName { get; set; }
        public int DisplayOrder { get; set; }

    }
}
