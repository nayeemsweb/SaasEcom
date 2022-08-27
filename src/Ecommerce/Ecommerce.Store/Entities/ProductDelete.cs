using Ecommerce.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.Entities
{
    public class ProductDelete : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public Guid ProductId { get; set; }
        public DateTime TriggeredOn { get; set; }
    }
}
