using Ecommerce.Store.Entities;

namespace Ecommerce.Store.Services
{
    public interface IEmailService
    {
        void CreateEmail(string subject, string body, string receiverEmail, string receiverName, NotificationType notificationType);
        IList<EmailMessage> GetUnsendEmails();
    }
}
