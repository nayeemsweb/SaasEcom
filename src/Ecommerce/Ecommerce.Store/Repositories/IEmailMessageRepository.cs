using Ecommerce.Data;
using Ecommerce.Store.Entities;

namespace Ecommerce.Store.Repositories
{
    public interface IEmailMessageRepository : IRepository<EmailMessage, Guid>
    {
    }
}
