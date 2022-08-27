using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.BusinessObjects
{
    public class ProductDelete : BaseClass
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public Guid ProductId { get; set; }
        public DateTime TriggeredOn { get; set; }
    }
}
