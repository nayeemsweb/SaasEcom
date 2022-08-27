using Ecommerce.Store.Services;
using Ecommerce.Utility;
using NT = Ecommerce.Store.Entities.NotificationType;
using ES = Ecommerce.Store.Entities.EmailStatus;
using MimeKit;

namespace Ecommerce.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger; 
        private readonly IEmailSender _emailSender;
        private readonly IEmailService _emailService;

        private SmtpConfiguration _smtpConfiguration;

        public Worker(ILogger<Worker> logger, 
            IEmailSender emailSender,
            IEmailService emailService)
        {
            _logger = logger;
            _emailSender = emailSender;
            _emailService = emailService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var emails = _emailService.GetUnsendEmails();
                if (emails != null)
                {
                    foreach (var email in emails)
                    {
                        try
                        {
                            //Message = body

                            _emailSender.Send(email.Subject, email.Message,
                                email.ReceiverEmail, email.ReceiverName);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError("Unable to Send email to " + email.ReceiverEmail + " :", ex.Message);
                        }
                    }
                }
                await Task.Delay(10000, stoppingToken); //delay 10 sec
            }
        }
    }
}