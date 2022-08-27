using Ecommerce.Store.BusinessObjects;

namespace Ecommerce.Store.Services
{
    public interface IWishlistService
    {
        void CreateProduct(Wishlist product);
        void DeleteProduct(Guid Id);
        IList<Wishlist> GetProducts();



    }
}