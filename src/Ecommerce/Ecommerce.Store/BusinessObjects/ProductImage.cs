using Ecommerce.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.BusinessObjects
{
    public class ProductImage : BaseClass
    {
        public Guid Id { get; set; }
        public Guid? StoreId { get; set; }
        public Guid ProductId { get; set; }
        public string? Url { get; set; }
        public Product? Product { get; set; }
        public Store? Store { get; set; }
    }
}
