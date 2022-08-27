using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.BusinessObjects
{
    public class ProductSubscriptionNotification 
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? PhoneNo { get; set; }
        public DateTime Time { get; set; }
        public Guid StoreId { get; set; }
        public Guid ProductId { get; set; }
    }
}
