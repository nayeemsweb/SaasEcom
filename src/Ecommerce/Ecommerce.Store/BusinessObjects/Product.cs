using System.ComponentModel;
using Ecommerce.Store.Entities;
using SE = Ecommerce.Store.Entities.Store;

namespace Ecommerce.Store.BusinessObjects
{
    public class Product : BaseClass
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool ActiveStatus { get; set; }
        public bool Featured { get; set; }
        public bool DeleteQueue { get; set; }//triggering delete queue
        public List<ProductImage>? ProductImages { get; set; }
        public List<ProductCategory>? ProductCategories { get; set; }
        public List<Review>? Reviews { get; set; }
        public Inventory? ProductInventory { get; set; }

    }
}
