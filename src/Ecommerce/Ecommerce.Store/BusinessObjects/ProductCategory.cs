using System.ComponentModel;
using Ecommerce.Data;

namespace Ecommerce.Store.BusinessObjects
{
    public class ProductCategory 
    {
        public Guid ProductId { get; set; }
        public Guid CategoryId { get; set; }
        public Product? Product { get; set; }
        public Category? Category { get; set; }
    }
}
