using System.ComponentModel;
using Ecommerce.Data;

namespace Ecommerce.Store.BusinessObjects
{
    public class AdminMenuItem: BaseClass
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public Guid MenuSectionId { get; set; }
        public Guid MenuGroupId { get; set; }
        public string MenuItemName { get; set; }
        public string MenuItemIcon { get; set; }
        public int DisplayOrder { get; set; }
    }
}
