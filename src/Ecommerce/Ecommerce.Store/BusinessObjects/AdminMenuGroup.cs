using System.ComponentModel;
using Ecommerce.Data;
using Ecommerce.Store.Entities;

namespace Ecommerce.Store.BusinessObjects
{
    public class AdminMenuGroup: BaseClass
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public string GroupName { get; set; }
        public string IconClass { get; set; }
        public int DisplayOrder { get; set; }

    }
}
