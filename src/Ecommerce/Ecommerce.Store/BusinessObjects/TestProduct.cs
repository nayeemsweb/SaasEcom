using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.BusinessObjects
{
    public class TestProduct : BaseClass
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        [DisplayName("Unit Price")]
        public decimal UnitPrice { get; set; }
        [DisplayName("Image File")]
        public string? ImageUrl { get; set; }

        
    }
}
