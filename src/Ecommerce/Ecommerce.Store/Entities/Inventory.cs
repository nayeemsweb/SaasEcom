using Ecommerce.Data;

namespace Ecommerce.Store.Entities
{
    public class Inventory : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }//foreign key of product table
        public Product? Product { get; set; }

    }
}
