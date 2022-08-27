using Ecommerce.Data;

namespace Ecommerce.Store.Entities
{
    public class Order : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set;}
        public Guid StoreId { get; set; }
        public int OrderNumber { get; set; }
        public int OrderStatus { get; set; }

        public IList<OrderedProduct>? OrderedProducts { get; set; }
    }
}
