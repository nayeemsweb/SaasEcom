using Ecommerce.Store.Entities;
using Ecommerce.Store.UnitOfWorks;

namespace Ecommerce.Store.Services
{
    public class EmailService : IEmailService
    {
        private readonly IStoreUnitOfWork _storeUnitOfWork;

        public EmailService(IStoreUnitOfWork storeUnitOfWork)
        {
            _storeUnitOfWork = storeUnitOfWork;
        }

        public void CreateEmail(string subject, string body, string receiverEmail, 
                                string receiverName, 
                                NotificationType notificationType)
        {
            var email = new EmailMessage
            {
                Subject = subject,
                Message = body,
                ReceiverEmail = receiverEmail,
                ReceiverName = receiverName,
                SendTime = DateTime.Now,
                NotificationType = notificationType,
                EmailStatus = 0

            };

            _storeUnitOfWork.EmailMessages.Add(email);
            _storeUnitOfWork.Save();
        }

        public IList<EmailMessage> GetUnsendEmails()
        {
            return _storeUnitOfWork.EmailMessages.Get(x => x.EmailStatus == (Entities.EmailStatus) 0, "");
        }
    }
}
