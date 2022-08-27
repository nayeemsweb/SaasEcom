using System.ComponentModel;
using Ecommerce.Data;

namespace Ecommerce.Store.Entities
{
    public class Cart : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid StoreId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
