using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.UnitOfWorks
{
    public class ContactFormUnitOfWork : UnitOfWork, IContactFormUnitOfWork
    {
        public IContactFormRepository ContactForms { get; private set; }
        public ContactFormUnitOfWork(IStoreDbContext storeDbContext,
            IContactFormRepository contactFormRepository) : base((DbContext)storeDbContext)
        {
            ContactForms = contactFormRepository;
        }
    }
}
