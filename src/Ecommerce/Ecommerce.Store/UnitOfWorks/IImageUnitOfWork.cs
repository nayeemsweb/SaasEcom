using Ecommerce.Data;
using Ecommerce.Store.Repositories;

namespace Ecommerce.Store.UnitOfWorks
{
    public interface IImageUnitOfWork : IUnitOfWork
    {
        IImageRepository ImageRepository {get;}


    }
}
