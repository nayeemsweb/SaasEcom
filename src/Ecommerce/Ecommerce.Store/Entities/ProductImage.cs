using Ecommerce.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.Entities
{
    public class ProductImage : BaseEntity, IEntity<Guid>
    {       
        public Guid Id { get; set; }
        public string? Url { get; set; }
        public Guid ProductId { get; set; }//foregin key of product
        public Product? Product { get; set; }

    }
}
