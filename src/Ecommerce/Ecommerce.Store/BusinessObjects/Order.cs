using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.BusinessObjects
{
    public class Order : BaseClass
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid StoreId { get; set; }
        public int OrderNumber { get; set; }
        public int OrderStatus { get; set; }
        public List<OrderedProduct>? OrderedProducts { get; set; }
    }
}
