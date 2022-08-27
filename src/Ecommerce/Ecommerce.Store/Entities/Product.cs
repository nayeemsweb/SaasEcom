using System.ComponentModel;
using Ecommerce.Data;

namespace Ecommerce.Store.Entities
{
    public class Product : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool ActiveStatus { get; set; }
        public bool Featured { get; set; }

        //StoreId not any foreign key, it's using for safety
        public Guid StoreId { get; set; }//foreign key of store table
        //public Store? Store { get; set; }//navigation of store table

        public bool DeleteQueue { get; set; }//triggering delete queue

        public IList<Review>? Reviews { get; set; }
        public IList<ProductImage>? ProductImages { get; set; }
        public IList<ProductCategory>? ProductCategories { get; set; }
        public Inventory? ProductInventory { get; set; }


    }
}
