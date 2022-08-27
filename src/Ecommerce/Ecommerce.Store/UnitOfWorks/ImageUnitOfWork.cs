using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Store.UnitOfWorks
{
    public class ImageUnitOfWork : UnitOfWork, IImageUnitOfWork
    {
        public IImageRepository ImageRepository { get; private set; }


        public ImageUnitOfWork(IStoreDbContext storeDbContext,
            IImageRepository imageRepository) : base((DbContext)storeDbContext)
        {
            ImageRepository = imageRepository;
        }
    }
}
