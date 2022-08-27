using Ecommerce.Data;

namespace Ecommerce.Store.Entities
{
    public class OrderedProduct : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; } //foreign key of Order
        public Order? Order { get; set; }
        public string? ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
