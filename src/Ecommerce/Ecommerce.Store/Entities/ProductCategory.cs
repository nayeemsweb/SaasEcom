using System.ComponentModel;
using Ecommerce.Data;

namespace Ecommerce.Store.Entities
{
    public class ProductCategory//middle table
    {
        public Guid ProductId { get; set; }//foregin key of product table
        public Product? Product { get; set; }
        public Guid CategoryId { get; set; }//foregin key of category table
        public Category? Category { get; set; }
    }
}
