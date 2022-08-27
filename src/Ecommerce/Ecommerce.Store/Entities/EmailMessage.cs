using Ecommerce.Data;

namespace Ecommerce.Store.Entities
{
    public class EmailMessage : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public NotificationType? NotificationType { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverEmail { get; set; }
        public DateTime SendTime { get; set; }
        public EmailStatus EmailStatus { get; set; }
    }
}
