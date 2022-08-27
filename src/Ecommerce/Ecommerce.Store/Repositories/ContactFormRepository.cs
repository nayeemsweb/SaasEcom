using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.Repositories
{
    public class ContactFormRepository : Repository<ContactForm, Guid>, IContactFormRepository
    { 
        public ContactFormRepository(IStoreDbContext context) : base((DbContext)context)
        {

        }
    }
}
