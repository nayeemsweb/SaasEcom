using Ecommerce.Data;
using Ecommerce.Store.Repositories;

namespace Ecommerce.Store.UnitOfWorks
{
    public interface IContactFormUnitOfWork : IUnitOfWork
    {
        IContactFormRepository ContactForms { get; }
    }
}