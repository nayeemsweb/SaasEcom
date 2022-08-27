namespace Ecommerce.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
