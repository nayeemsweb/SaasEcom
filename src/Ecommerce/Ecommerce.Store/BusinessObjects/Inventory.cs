using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.BusinessObjects
{
    public class Inventory : BaseClass
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public Guid ProductId { get; set; } //foreign key of product table
        public Product? Product { get; set; }
    }
}