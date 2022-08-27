using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.Repositories
{
    public class EmailMessageRepository : Repository<EmailMessage, Guid>, IEmailMessageRepository
    {
        public EmailMessageRepository(IStoreDbContext context) : base((DbContext)context)
        {
        }
    }
}
